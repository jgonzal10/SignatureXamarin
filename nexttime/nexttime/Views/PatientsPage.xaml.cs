using System;
using System.Collections.Generic;
using nexttime.ViewModels;
using Xamarin.Forms;
using nexttime.Models;
using System.Linq;
using System.Text;
using Xamarin.Forms.Xaml;

namespace nexttime.Views
{
    public partial class PatientsPage : ContentPage
    {

        PatientsViewModel patientModel;
        public PatientsPage()
        {
            InitializeComponent();
            BindingContext = patientModel = new PatientsViewModel();
        }


        async void OnPatientSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var patient = args.SelectedItem as Patient;
            if (patient == null)
                return;

            await Navigation.PushAsync(new PatientDetailPage(new PatientDetailViewModel(patient)));

            // Manually deselect item.
            PatientsListView.SelectedItem = null;
        }

        async void AddPatient_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewPatientPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (patientModel.Patients.Count == 0)
                patientModel.LoadPatientsCommand.Execute(null);
        }
    }
}
