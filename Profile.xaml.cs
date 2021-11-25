using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSpalanie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        List<RouteL> routes = new List<RouteL>
            {
                
            };

        public Profile()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            loadData();
            var existingPages = Navigation.NavigationStack.ToList();
            foreach (var page in existingPages)
            {
                Navigation.RemovePage(page);
            }
        }

        bool bExit = true;

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            if (!bExit)
                return false;

            // don't exit the app when back button is pressed
            Device.BeginInvokeOnMainThread(async () =>
            {
                bExit = await DisplayAlert("Informacje", "Czy na pewno chcesz się wylogować?", "Nie", "Tak");
                if (!bExit)
                    await Navigation.PopToRootAsync();
            });
            return bExit;
        }
        async private void loadData()
        {
            routes.Clear();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://smartspalanie.5v.pl");

            Ojson ojson = new Ojson();
            ojson.id = App.Lid;
            var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/spalanie/getHistory.php", content);

            string json= await response.Content.ReadAsStringAsync();
            title.Text = "Witaj ponownie ";
            title.Text += App.Lusername;
            title.Text += "!";
            App.Lx = 0;
            if (json != "null")
            {
                int x = 0;
                JArray obj = JArray.Parse(json);
                foreach (var line in obj)
                {
                    x++;
                    string r = (string)line["start"];
                    r += "->";
                    r += (string)line["end"];
                    routes.Add(new RouteL { Date = (string)line["date"], RouteD = r, Id = (int)line["id"] });

                }
                title2.Text = "Przejechaliśmy już razem ";
                title2.Text += x;
                title2.Text += " tras(y)";
                App.Lx = x;
                routesL.ItemsSource = routes;
            }

        }

        private class RouteL

        {
            public string Date { get; internal set; }
            public string RouteD { get; internal set; }
            public int Id { get; internal set; }

        }
        async private void stations_tapped(object sender, ItemTappedEventArgs e)
        {
            var przejazdy_l = (ListView)sender; 
            RouteL sel = (RouteL)przejazdy_l.SelectedItem;
            await Navigation.PushAsync(new Route(id: sel.Id));
        }

        async private void petrol_stations(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StationsSearch());
        }

        async private void new_route(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewRoute());
        }

        async private void vehicle(object sender, EventArgs e)
        {
            loadData();
            await Navigation.PushAsync(new Vehicle());
        }

        private class Ojson
        {
            public int id;
        }
    }
}