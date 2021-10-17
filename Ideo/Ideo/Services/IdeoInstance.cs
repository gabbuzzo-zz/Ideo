using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace Ideo.Services
{
    public class IdeoInstance : HttpClient
    {
        public HttpClient client { get; set; }
        Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
        public string Token { get; set; }
        public DateTime AccessTokenExpirationDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public IdeoInstance()
        {
            var handler = new HttpClientHandler()
            {
                ClientCertificateOptions = ClientCertificateOption.Automatic
            };

            handler.ServerCertificateCustomValidationCallback +=
                            (sender, certificate, chain, errors) =>
                            {
                                return true;
                            };
            var client = new HttpClient(handler);
            this.client = client;
        }
        public bool IsConnected()
        {
            client = new HttpClient();
            var response = client.GetAsync(uri+"swagger/");
            return response.Result.IsSuccessStatusCode;
        }
    }
}
