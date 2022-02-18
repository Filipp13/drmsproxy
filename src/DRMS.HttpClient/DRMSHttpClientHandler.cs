using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DRMS.HttpClient
{
    internal class DRMSHttpClientHandler : HttpClientHandler
    {
        private readonly ProxyMiddlewareOptions options;

        public DRMSHttpClientHandler(IOptions<ProxyMiddlewareOptions> options)
        {
            this.options = options?.Value ?? throw new ArgumentNullException(nameof(options));

            var certificate = new X509Certificate2(this.options.CertificatePath, this.options.CertificatePassword);
            //ClientCertificateOptions = ClientCertificateOption.Manual;
            //SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
            ClientCertificates.Add(certificate);
        }
    }
}
