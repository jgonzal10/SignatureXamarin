using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace nexttime.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddPatientAsync(T patient);
        Task<bool> UpdatePatientAsync(T patient);
        Task<bool> DeletePatientAsync(string id);
        Task<T> GetPatientAsync(string id);
        Task<IEnumerable<T>> GetPatientsAsync(bool forceRefresh = false);



    }
}
