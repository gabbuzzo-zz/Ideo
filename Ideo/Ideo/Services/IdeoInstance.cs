using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace Ideo.Services
{
   public class IdeoInstance:HttpClient
    {
        private HttpClient _client;
        Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
        public IdeoInstance()
        {
            
        }
        public bool IsConnected()
        {
            _client = new HttpClient();
            var response = _client.GetAsync(uri);
            return response.Result.IsSuccessStatusCode;
        }
    }
}
