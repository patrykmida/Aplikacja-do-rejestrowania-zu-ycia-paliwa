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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async private void register(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(password1.Text) && !string.IsNullOrEmpty(password2.Text) && !string.IsNullOrEmpty(mail.Text) && !string.IsNullOrEmpty(username.Text))
            {
                if (password1.Text == password2.Text)
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://smartspalanie.5v.pl");

                    Ojson ojson = new Ojson();
                    ojson.username = username.Text;
                    ojson.mail = mail.Text;
                    ojson.password = password1.Text;

                    var content = new StringContent(JsonConvert.SerializeObject(ojson), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("/spalanie/register.php", content);

                    error.TextColor = Color.FromHex("#F0F4EF");
                    error.Text = "Zarejestrowano";


                }
                else
                {
                    error.Text = "Hasła się nie zgadzają";
                }
            }
            else
            {
                error.Text = "Uzupełnij wszystkie dane";
            }
        }

        private class Ojson
        {
            public string username { get; set; }
            public string mail { get; set; }
            public string password { get; set; }
        }
    }
}