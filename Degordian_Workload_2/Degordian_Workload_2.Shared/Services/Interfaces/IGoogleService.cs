using System;
using System.Collections.Generic;
using System.Text;
using Degordian_Workload_2.Services.Model;
using System.Threading.Tasks;

namespace Degordian_Workload_2.Services.Interfaces
{
    public interface IGoogleService : ISessionProvider
    {
#if WINDOWS_PHONE_APP
        Task<Session> Finalize(Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs args);
#endif
    }
}
