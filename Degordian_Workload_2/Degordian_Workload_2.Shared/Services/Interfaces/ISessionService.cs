using Degordian_Workload_2.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace Degordian_Workload_2.Services.Interfaces
{
    public interface ISessionService
    {
        Session GetSession();

        Task<bool?> LoginAsync(string provider);

        void Logout();

#if WINDOWS_PHONE_APP
        Task<bool> Finalize(WebAuthenticationBrokerContinuationEventArgs args);
#endif
    }
}
