using Ideo.Models;
using Ideo.ModelViews;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ideo.Services
{
    internal class ApiServices
    {
        public async Task<bool> RegisterUserAsync(
            string email, string password, string confirmPassword)
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

            var model = new RegisterViewModel()
            {
                Email=email,
                Password = password,
                ConfirmPassword = confirmPassword
            };
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var json = JsonConvert.SerializeObject(model);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            try
            {
                var response = await client.PostAsync(
                    Constants.RestUrl + "user/register", httpContent);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return false;
        }

        public async Task<string> LoginAsync(string userName, string password)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", userName),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password")
            };

            var request = new HttpRequestMessage(
                HttpMethod.Post, Constants.RestUrl + "Token");

            request.Content = new FormUrlEncodedContent(keyValues);

            var client = new HttpClient();
            var response = await client.SendAsync(request);

            var content = await response.Content.ReadAsStringAsync();

            var jwtDynamic = JsonConvert.DeserializeObject<object>(content);
            //jwtDynamic.Value<DateTime>(".expires")
            //var accessTokenExpiration =(DateTime)Convert.ToDateTime(jwtDynamic[".expires"]) ;
            //var accessToken = jwtDynamic.Value<string>("access_token");
            var accessTokenInstance = new IdeoInstance();
            //accessTokenInstance.AccessTokenExpirationDate = accessTokenExpiration;
            //accessTokenInstance.Token = accessToken;
            //Debug.WriteLine(accessTokenExpiration);
            //Debug.WriteLine(accessToken);
            Debug.WriteLine(jwtDynamic);
            Debug.WriteLine(content);

            return "";
        }


        #region idea
        //public async Task<List<Idea>> GetIdeasAsync(string accessToken)
        //{
        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
        //        "Bearer", accessToken);

        //    var json = await client.GetStringAsync(Constants.BaseApiAddress + "api/ideas");

        //    var ideas = JsonConvert.DeserializeObject<List<Idea>>(json);

        //    return ideas;
        //}

        //public async Task PostIdeaAsync(Idea idea, string accessToken)
        //{
        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        //    var json = JsonConvert.SerializeObject(idea);
        //    HttpContent content = new StringContent(json);
        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var response = await client.PostAsync(Constants.BaseApiAddress + "api/Ideas", content);
        //}

        //public async Task PutIdeaAsync(Idea idea, string accessToken)
        //{
        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        //    var json = JsonConvert.SerializeObject(idea);
        //    HttpContent content = new StringContent(json);
        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var response = await client.PutAsync(
        //        Constants.BaseApiAddress + "api/Ideas/" + idea.Id, content);
        //}

        //public async Task DeleteIdeaAsync(int ideaId, string accessToken)
        //{
        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        //    var response = await client.DeleteAsync(
        //        Constants.BaseApiAddress + "api/Ideas/" + ideaId);
        //}

        //public async Task<List<Idea>> SearchIdeasAsync(string keyword, string accessToken)
        //{
        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
        //        "Bearer", accessToken);

        //    var json = await client.GetStringAsync(
        //        Constants.BaseApiAddress + "api/ideas/Search/" + keyword);

        //    var ideas = JsonConvert.DeserializeObject<List<Idea>>(json);

        //    return ideas;
        //}

        #endregion    }
    }
}
