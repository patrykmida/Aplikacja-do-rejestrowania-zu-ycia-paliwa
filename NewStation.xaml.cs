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
    public partial class NewStation : ContentPage
    {
        public NewStation()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async private void save(object sender, EventArgs e)
        {
            Ojson ojson = new Ojson();
            ojson.name = name.Text;
            ojson.town = town.Text;
            ojson.street = street.Text;
            ojson.type = (string)picker.SelectedItem;
            ojson.price = price.Text.Replace(',', '.');
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://smartspalanie.5v.pl");
            var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/spalanie/newStation.php", content);
            var result = await response.Content.ReadAsStringAsync();
            await Navigation.PopAsync();
        }

        private class Ojson
        {
            public string name;
            public string town;
            public string street;
            public string type;
            public string price;
        }
    }
}