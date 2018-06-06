using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignaturePad.Forms;
using Xamarin.Forms;

namespace Firmando
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, System.EventArgs e)
        {
            Stream image = await PadView.GetImageStreamAsync(SignatureImageFormat.Jpeg); 
        }

        private void ClearButton_Clicked(object sender, System.EventArgs e)
        {
            PadView.Clear();
        }
    }
}
