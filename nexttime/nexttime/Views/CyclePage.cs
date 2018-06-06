using System;

using Xamarin.Forms;

namespace nexttime.Views
{
    public class CyclePage : ContentPage
    {
        public CyclePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

