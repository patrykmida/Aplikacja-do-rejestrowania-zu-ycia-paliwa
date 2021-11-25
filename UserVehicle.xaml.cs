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
    public partial class UserVehicle : ContentPage
    {
        public UserVehicle(int id)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            loadData(id);
        }
        async private void loadData(int id)
        {
            Ojson ojson = new Ojson();
            ojson.id = id;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://smartspalanie.5v.pl");
            var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/spalanie/getVehicle.php", content);
            var result = await response.Content.ReadAsStringAsync();
            var res = JObject.Parse(result);

            title.Text = (string)res["brand"];
            title.Text += " ";
            title.Text += (string)res["model"];
            desc.Text = (string)res["description"];
            u3.Text = (string)res["u3"];
            u6.Text = (string)res["u6"];
            ua.Text = (string)res["ua"];
            u3.Text += " l/100 km";
            u6.Text += " l/100 km";
            ua.Text += " l/100 km";
        }

        private class Ojson
        {
            public int id;
        }
    }
}