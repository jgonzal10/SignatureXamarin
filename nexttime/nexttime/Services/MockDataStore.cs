using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using nexttime.Models;

[assembly: Xamarin.Forms.Dependency(typeof(nexttime.Services.MockDataStore))]
namespace nexttime.Services
{
    public class MockDataStore : IDataStore<Patient>
    {
        List<Patient> patients;

        public MockDataStore()
        {
            patients = new List<Patient>();
            var mockPatients = new List<Patient>
            {
                new Patient { Id = Guid.NewGuid().ToString(), Name = "Ricky", Age="10" },
                new Patient { Id = Guid.NewGuid().ToString(), Name = "Dallas", Age="17" },
                new Patient { Id = Guid.NewGuid().ToString(), Name = "Rosa", Age="18" },
                new Patient { Id = Guid.NewGuid().ToString(), Name = "Raul", Age="13" },
                new Patient { Id = Guid.NewGuid().ToString(), Name = "Mo", Age="12" },
                new Patient { Id = Guid.NewGuid().ToString(), Name = "dy", Age="16" },

            };

            foreach (var patient in mockPatients)
            {
                patients.Add(patient);
            }
        }

        public async Task<bool> AddPatientAsync(Patient patient)
        {
            patients.Add(patient);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdatePatientAsync(Patient patient)
        {
            var _patient = patients.Where((Patient arg) => arg.Id == patient.Id).FirstOrDefault();
            patients.Remove(_patient);
            patients.Add(patient);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeletePatientAsync(string id)
        {
            var _patient = patients.Where((Patient arg) => arg.Id == id).FirstOrDefault();
            patients.Remove(_patient);

            return await Task.FromResult(true);
        }

        public async Task<Patient> GetPatientAsync(string id)
        {
            return await Task.FromResult(patients.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Patient>> GetPatientsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(patients);
        }
    }
}