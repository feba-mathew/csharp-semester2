using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace HelloWorld
{
    public class ImageService
    {
        public ImageModel GetImages()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Client-ID 2280591526449b5");
            client.BaseAddress = new Uri("https://api.imgur.com/3/gallery/t/kitten");

            var result = client.GetAsync("").Result;

            var json = result.Content.ReadAsStringAsync().Result;

            var model = JsonConvert.DeserializeObject<ImageModel>(json);

            return model;
        }
    }
}
