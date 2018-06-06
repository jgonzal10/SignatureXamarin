using System;
using System.Collections.Generic;
using nexttime.Models;
using nexttime.ViewModels;
using Xamarin.Forms;

namespace nexttime.Views
{
    public partial class PatientDetailPage : ContentPage
    {
        PatientDetailViewModel patientModel;
        public PatientDetailPage(PatientDetailViewModel patientModel)
        {
            InitializeComponent();
            BindingContext = this.patientModel = patientModel;
        }
        public PatientDetailPage()
        {
            InitializeComponent();

            var patient = new Patient
            {
                Name = "Item 1",
                Age = "54"
            };

            patientModel = new PatientDetailViewModel(patient);
            BindingContext = patientModel;
        }
    }
}
