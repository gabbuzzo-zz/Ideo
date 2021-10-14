using Ideo.Models;
using Ideo.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ideo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        HttpClient _client = new HttpClient();
        public MainPage()
        {
            InitializeComponent();
            var b = this.BindingContext;
        }

        private async void OnShareIdeaClick(object sender, EventArgs e)
        {
            var post = new Post()
            {
                Id = Guid.NewGuid(),
                SharedFile = "",
                Description = "new Project based on Web Api .core",
                IsAccepted = true,
                PublishDate = DateTime.Now,
                RefusedCause = "",
                Tags = null,
                Title = "Progetto web"
            };
            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            var json = JsonConvert.SerializeObject(post);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync(uri+"post/",content);
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine("Funziona:" + response.IsSuccessStatusCode);
            }

        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}