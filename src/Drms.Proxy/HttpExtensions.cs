namespace Drms.Proxy
{
    public static class HttpExtensions
    {
      

        public static async Task<HttpRequestMessage> CreateProxiedHttpRequest(this HttpContext context, string uriString)
        {
            var uri = new Uri(uriString);
            var request = context.Request;

            var requestMessage = new HttpRequestMessage();
            var requestMethod = request.Method;
            var usesStreamContent = true; // When using other content types, they specify the Content-Type header, and may also change the Content-Length.

            // Write to request content, when necessary.
            if (!HttpMethods.IsGet(requestMethod) &&
                !HttpMethods.IsHead(requestMethod) &&
                !HttpMethods.IsDelete(requestMethod) &&
                !HttpMethods.IsTrace(requestMethod))
            {
                int requestLen = (int)request.ContentLength;
                byte[] buffer = new byte[requestLen];
                int numButesRead = 0;
                while (numButesRead < requestLen)
                {
                    int readBytes = await request.Body.ReadAsync(buffer, numButesRead, requestLen - numButesRead);
                    numButesRead += readBytes;
                }
                context.Request.Body.Position = 0;
                requestMessage.Content = new StreamContent(request.Body);
                
            }

            // Copy the request headers.
            foreach (var header in request.Headers)
            {
                if (!usesStreamContent && (header.Key.Equals("Content-Type", StringComparison.OrdinalIgnoreCase) || header.Key.Equals("Content-Length", StringComparison.OrdinalIgnoreCase)))
                    continue;
                if (!requestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value.ToArray()))
                    requestMessage.Content?.Headers.TryAddWithoutValidation(header.Key, header.Value.ToArray());
            }

            // Set destination and method.
            requestMessage.Headers.Host = uri.Authority;
            requestMessage.RequestUri = uri;
            requestMessage.Method = new HttpMethod(requestMethod);

            return requestMessage;
        }

        public static Task<HttpResponseMessage> SendProxiedHttpRequestAsync(this HttpContext context, HttpRequestMessage message, HttpClient httpClient)
        {
            return httpClient.SendAsync(message, HttpCompletionOption.ResponseHeadersRead, context.RequestAborted);
        }

        public static Task WriteProxiedHttpResponseAsync(this HttpContext context, HttpResponseMessage responseMessage)
        {
            var response = context.Response;

            response.StatusCode = (int)responseMessage.StatusCode;
            foreach (var header in responseMessage.Headers)
            {
                response.Headers[header.Key] = header.Value.ToArray();
            }

            foreach (var header in responseMessage.Content.Headers)
            {
                response.Headers[header.Key] = header.Value.ToArray();
            }

            response.Headers.Remove("transfer-encoding");

            return responseMessage.Content.CopyToAsync(response.Body);
        }

    }
}

