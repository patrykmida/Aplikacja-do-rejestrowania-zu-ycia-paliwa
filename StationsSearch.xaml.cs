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
    public partial class StationsSearch : ContentPage
    {
        public StationsSearch()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            loadData();
        }
        async private void loadData() {
            var towns = new List<string>();


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://smartspalanie.5v.pl");

            Ojson ojson = new Ojson();
            ojson.town = (string)town.SelectedItem;
            ojson.type = (string)type.SelectedItem;
            var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/spalanie/getTowns.php", content);

            var result = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(result) && result != "null")
            {
                JArray obj = JArray.Parse(result);
                foreach (var line in obj)
                {
                    towns.Add((string)line["town"]);
                }
                town.ItemsSource = towns;
            }
        }
        async private void new_station(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewStation());
        }

        private class Result
        {
            public Result(string name, string street, string price)
            {
                Name = name;
                Street = street;
                Price = price;
            }

            public string Name { get; internal set; }
            public string Street { get; internal set; }
            public string Price { get; internal set; }
        }

        List<Result> resultslist = new List<Result>
        {
        };

        async private void search(object sender, EventArgs e)
        {
            resultslist.Clear();
            if (!string.IsNullOrEmpty((string)town.SelectedItem) && !string.IsNullOrEmpty((string)type.SelectedItem))
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://smartspalanie.5v.pl");

                Ojson ojson = new Ojson();
                ojson.town = (string)town.SelectedItem;
                ojson.type = (string)type.SelectedItem;
                var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("/spalanie/searchStations.php", content);

                var result = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(result) && result!="null")
                {
                    JArray obj = JArray.Parse(result);
                    foreach (var line in obj)
                    {
                        resultslist.Add(new Result((string)line["name"], (string)line["street"], (string)line["price"] + " zł/l"));

                    }
                    results.ItemsSource = resultslist;
                }
                else
                {
                    await DisplayAlert("Informacja", "Brak dancyh", "Zamknij");
                }
            }
        }

        private class Ojson
        {
            public string town;
            public string type;
        }
    }
}