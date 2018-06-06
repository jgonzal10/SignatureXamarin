using System;
using System.Collections.Generic;
using nexttime.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nexttime.Views
{
    [XamlCompilation(xamlCompilationOptions: XamlCompilationOptions.Compile)]
    public partial class NewPatientPage : ContentPage
    {
        public Patient Patient { get; set; }
        public NewPatientPage()
        {
            InitializeComponent();

            Patient = new Patient
            {
                Name = "Patient name",
                Age = "32"
            };

            BindingContext = this;
        }


        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddPatient", Patient);
            await Navigation.PopModalAsync();
        }
    }
}
