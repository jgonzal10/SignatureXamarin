using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace nexttime.Views
{
    public partial class PeriodDatesPage : ContentPage
    {
        public PeriodDatesPage()
        {
            InitializeComponent();
        }
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            MainLable.Text = e.NewDate.ToString();
        }
    }
}
