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
    public partial class Compare : ContentPage
    {


        List<Result> resultslist = new List<Result>
        {
        };


        public Compare()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            loadData();
        }

        async private void loadData()
        {
            Ojson ojson = new Ojson();
            ojson.id = App.Lid;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://smartspalanie.5v.pl");
            var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/spalanie/compare.php", content);

            var json = await response.Content.ReadAsStringAsync();
            if (json != "null")
            {
          
                JArray obj = JArray.Parse(json);
                foreach (var line in obj)
                {
                    resultslist.Add(new Result((int)line["id"], (string)line["username"], (string)line["ua"]+" l/100 km"));
                }
                results.ItemsSource = resultslist;
            }
            else
            {
                await DisplayAlert("Informacja", "Brak danych", "Zamknij");
            }
        }

        private class Result
        {
            public Result(int id, string username, string fuel)
            {
                Id = id;
                Username = username;
                Fuel = fuel;
            }

            public int Id { get; internal set; }
            public string Username { get; internal set; }
            public string Fuel { get; internal set; }
        }

        async private void results_details(object sender, ItemTappedEventArgs e)
        {
            var users_l = (ListView)sender;
            Result user = (Result)users_l.SelectedItem;
            await Navigation.PushAsync(new UserVehicle(id: user.Id));

        }

        private class Ojson
        {
            public int id;
        }
    }
}