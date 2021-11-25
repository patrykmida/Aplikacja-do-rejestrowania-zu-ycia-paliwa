using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSpalanie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tips : ContentPage
    {
        public Tips()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}