using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartSpalanie
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async private void Btn_register(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

        private async void Btn_login(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://smartspalanie.5v.pl");

            Ojson ojson = new Ojson();
            ojson.mail = mail.Text;
            ojson.password = password.Text;
            var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/spalanie/login.php", content);

            var result = await response.Content.ReadAsStringAsync();
            var res = JObject.Parse(result);
            if((int)res["ok"] == 1)
            {
                App.Lid = (int)res["id"];
                App.Lusername = (string)res["username"];

                await Navigation.PushAsync(new Profile());
            }
            else
            {
                error.Text = "Błędne dane logowania";
            }
        }
        private class Ojson
        {
            public string mail { get; set; }
            public string password { get; set; }
        }
    }
}
