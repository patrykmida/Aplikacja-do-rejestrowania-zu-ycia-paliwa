using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSpalanie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Route : ContentPage
    {
        private int Id;
        public Route(int id)
        {
            Id = id;
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            loadData();
        }
        private async Task loadData()
        {
            Ojson ojson = new Ojson();
            ojson.id = Id;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://smartspalanie.5v.pl");
            var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/spalanie/getRoute.php", content);
            var result = await response.Content.ReadAsStringAsync();
            var res = JObject.Parse(result);

            date.Text = (string)res["date"];
            start.Text = (string)res["start"];
            dist.Text = (string)res["dist"];
            end.Text = (string)res["end"];
            fuel_usage.Text = (string)res["fuel_usage"];

        }

        private class Ojson
        {
            public int id;
        }
    }
}