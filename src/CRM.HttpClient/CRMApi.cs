using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace CRM.HttpClient
{
    public class CRMApi : ICRMApi
    {
        private readonly System.Net.Http.HttpClient client;
        private readonly CRMServiceOptions options;
        private readonly JsonSerializerOptions serializerOptions;
        private readonly ILogger<CRMApi> logger;

        public CRMApi(System.Net.Http.HttpClient client,
            IOptions<CRMServiceOptions> options,
            ILogger<CRMApi> logger)
        {
            this.client = client;
            this.options = options.Value ?? throw new ArgumentNullException(nameof(options));
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            this.logger = logger;
        }

        public async Task<bool> CreateDrmsCase(NewCaseRequest createCaseRequest)
        {
            using (var stream = new MemoryStream())
            {
                await JsonSerializer.SerializeAsync(stream, createCaseRequest, serializerOptions)
                    .ConfigureAwait(false);

                var json = Encoding.Default.GetString(stream.ToArray());

                logger.LogInformation("Request for create case {json}", json);

                var response = await client.PostAsync($"/CISIntegra/api/data/{options.ApiVersion}/nav_drmscases",
                    new StringContent(json, Encoding.UTF8, "application/json"))
                    .ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    return true;
                }
                else
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    logger.LogError("Error while create case {responseString}", responseString);
                    return false;
                }
            }
        }

        public async Task<Guid> GetLookupOppotunityByName(string name)
        {
            var stream = await client.GetStreamAsync(
                $"/CISIntegra/api/data/{options.ApiVersion}/opportunities?$select=opportunityid&$filter=name eq '{name}'")
                .ConfigureAwait(false);

            var response = await JsonSerializer.DeserializeAsync<Oppotunity>(stream, serializerOptions);

            if (response is null || response.Value is null)
                return Guid.Empty;

            return response.Value.Count switch
            {
                1 => response.Value[0].Opportunityid,
                _ => Guid.Empty,
            };

        }


        public async Task<ModelForRequest> GetLookups(
            string opportunityName,
            string caserequestor,
            string productName,
            string accountId,
            string countryName,
            string leadEngagementPartner,
            string leadEngagementManager)
        {
            var operations = BuildOperationsNew(
                                opportunityName,
                                caserequestor,
                                productName,
                                accountId,
                                countryName,
                                leadEngagementPartner,
                                leadEngagementManager);

            var model = new ModelForRequest();

            MultipartContent content = new MultipartContent("mixed", "batch_" + Guid.NewGuid());

            foreach (var operation in operations)
            {
                var queryContent = new StringContent($"{operation.RequestCommand}{Environment.NewLine}");
                queryContent.Headers.Remove("Content-Type");
                queryContent.Headers.TryAddWithoutValidation("Content-Type", "application/http");
                queryContent.Headers.TryAddWithoutValidation("Content-Transfer-Encoding", "binary");
                queryContent.Headers.TryAddWithoutValidation("Accept", "application/json");
                content.Add(queryContent);
            }

            var batchRequest = new HttpRequestMessage(HttpMethod.Post, $"/CISIntegra/api/data/{options.ApiVersion}/$batch");

            var request = await content.ReadAsStringAsync();

            logger.LogInformation("Request for lookups {request}", request);

            batchRequest.Content = content;


            var response = await client.SendAsync(batchRequest, HttpCompletionOption.ResponseHeadersRead)
                .ConfigureAwait(false);

            logger.LogInformation($"Response status code {response.StatusCode}", response.StatusCode);
   
            var reader = await MutipartMixedHelper.ParseMultipartMixedRequestAsync(response);

            MultipartSection section;
            int i = 0;

            while ((section = await reader.ReadNextSectionAsync()) != null)
            {
                using (var streamReader = new StreamReader(
                    section.Body, Encoding.UTF8, leaveOpen: true))
                {
                    var body = await streamReader.ReadToEndAsync();
                    var m = Regex.Match(body, @"\{(.|\s)*\}");

                    if(operations[i].Append(m.Value, model))
                    {
                        logger.LogInformation("Parse batch response success: {body}", body);
                    }
                    else
                    {
                        logger.LogError("Failed to parse batch response: {body}", body);
                    }

                    i++;
                }
            }
            
            return model;
        }

        private List<LookupModel> BuildOperationsNew(
          string opportunityName,
          string caserequestor,
          string productName,
          string accountId,
          string countryName,
          string leadEngagementPartner,
          string leadEngagementManager)
        {
            var operations = new List<LookupModel>();
            operations.Add(new Oppotunity(opportunityName, options.ApiVersion, serializerOptions));
            operations.Add(new CaseRequestor(caserequestor, options.ApiVersion, serializerOptions));
            operations.Add(new ClientMemberFirm(accountId, options.ApiVersion, serializerOptions));
            operations.Add(new Product(productName, options.ApiVersion, serializerOptions));
            operations.Add(new Country(countryName, options.ApiVersion, serializerOptions));
            operations.Add(new LeadEngagementPartner(leadEngagementPartner, options.ApiVersion, serializerOptions));
            operations.Add(new LeadEngagementManager(leadEngagementManager, options.ApiVersion, serializerOptions));


            return operations;
        }



        //    private List<(string, Func<string, ModelForRequest, ModelForRequest>)> BuildOperations(
        //    string opportunityName,
        //    string caserequestor,
        //    string productName,
        //    string accountId,
        //    string countryName)
        //{
        //    List<(string, Func<string, ModelForRequest, ModelForRequest>)> operations = new();

        //    operations.Add(new($"GET /CISIntegra/api/data/{options.ApiVersion}/opportunities?$select=opportunityid&$filter=name eq '{opportunityName}' HTTP/1.1",
        //        (response, model) =>
        //        {
        //            var oppotunity = JsonSerializer.Deserialize<Oppotunity>(response, serializerOptions);
        //            model.Oppotunity = oppotunity;
        //            return model;
        //        }));

        //    operations.Add(new($"GET /CISIntegra/api/data/{options.ApiVersion}/systemusers?$select=identityid&$filter=domainname eq '{caserequestor}' HTTP/1.1",
        //        (response, model) =>
        //        {
        //            var caserequestor = JsonSerializer.Deserialize<CaseRequestor>(response, serializerOptions);
        //            model.CaseRequestor = caserequestor;
        //            return model;
        //        }));

        //    operations.Add(new($"GET /CISIntegra/api/data/{options.ApiVersion}/nav_oppproducts?$select=nav_oppproductid&$filter=nav_name eq '{productName}' HTTP/1.1",
        //        (response, model) =>
        //        {
        //            var product = JsonSerializer.Deserialize<Product>(response, serializerOptions);
        //            model.Product = product;
        //            return model;
        //        }));

        //    operations.Add(new($"GET /CISIntegra/api/data/{options.ApiVersion}/accounts?$select=accountid&$filter=accountid eq '{accountId}' HTTP/1.1",
        //        (response, model) =>
        //        {
        //            var client = JsonSerializer.Deserialize<ClientMemberFirm>(response, serializerOptions);
        //            model.ClientMemberFirm = client;
        //            return model;
        //        }));

        //    operations.Add(new($"GET /CISIntegra/api/data/{options.ApiVersion}/nav_countries?$select=nav_countryid&$filter=nav_name eq '{countryName}' HTTP/1.1",
        //        (response, model) =>
        //        {
        //            var country = JsonSerializer.Deserialize<Country>(response, serializerOptions);
        //            model.Country = country;
        //            return model;
        //        }));

        //    return operations;
        //}

    }
}
