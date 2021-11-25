using Newtonsoft.Json;
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
    public partial class NewRoute : ContentPage
    {
        public NewRoute()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async private void new_route(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dist.Text) && !string.IsNullOrEmpty(start.Text) && !string.IsNullOrEmpty(end.Text) && !string.IsNullOrEmpty(fuel_usage.Text))
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://smartspalanie.5v.pl");

                Ojson ojson = new Ojson();
                ojson.dist = dist.Text.Replace(',', '.');
                ojson.start = start.Text;
                ojson.end = end.Text;
                ojson.fuel_usage = fuel_usage.Text.Replace(',', '.');
                ojson.id = App.Lid;

                var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("/spalanie/newRoute.php", content);
                
                await Navigation.PushAsync(new Profile());

            }
        }

        private class Ojson
        {
            public string dist;
            public string start;
            public string end;
            public string fuel_usage;
            public int id;
        }
    }
}