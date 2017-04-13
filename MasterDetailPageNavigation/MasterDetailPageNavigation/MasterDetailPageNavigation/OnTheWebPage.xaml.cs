using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnTheWebPage : ContentPage
    {
        public OnTheWebPage()
        {
            InitializeComponent();

            var browser = new WebView();
            browser.Source = "https://sites.google.com/valuedapps.com/valuedapps/home";
            Content = browser;
        }
    }
}
