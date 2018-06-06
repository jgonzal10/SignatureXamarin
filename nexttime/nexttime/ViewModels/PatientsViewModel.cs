using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using nexttime.Models;
using nexttime.Views;

namespace nexttime.ViewModels
{
    public class PatientsViewModel : BaseViewModel
    {
        public ObservableCollection<Patient> Patients { get; set; }
        public Command LoadPatientsCommand { get; set; }

        public PatientsViewModel()
        {
            Title = "Browse";
            Patients = new ObservableCollection<Patient>();
            LoadPatientsCommand = new Command(async () => await ExecuteLoadPatientsCommand());

            MessagingCenter.Subscribe<NewPatientPage, Patient>(this, "AddPatient", async (obj, patient) =>
            {
                var _patient = patient as Patient;
                Patients.Add(_patient);
                await DataStore.AddPatientAsync(_patient);
            });
        }

        async Task ExecuteLoadPatientsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Patients.Clear();
                var patients = await DataStore.GetPatientsAsync(true);
                foreach (var patient in patients)
                {
                    Patients.Add(patient);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}