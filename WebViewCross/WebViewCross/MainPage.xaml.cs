using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewCross
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Browser.HeightRequest = 1000;
            Browser.WidthRequest = 1000;
            Browser.Source = "http://github.com/jgonzal10";
        }

        private void webOnNavigating(Object sender, WebNavigationEvent e){
            lblStatus.Text = "Loading Git";

        }
        private void webOnEndNavigating(Object sender, WebNavigationEvent e){
            lblStatus.Text = "Done!!";
        }
    }
}
