using System;

using nexttime.Models;

namespace nexttime.ViewModels
{
    public class PatientDetailViewModel : BaseViewModel
    {
        public Patient Patient { get; set; }
        public PatientDetailViewModel(Patient patient = null)
        {
            Title = patient?.Name;
            Patient = patient;
        }
    }
}
