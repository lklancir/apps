using Degordian_Workload_2.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Degordian_Workload_2.Services.Interfaces
{
    public interface ISessionProvider
    {
        Task<Session> LoginAsync();
        void Logout();

    }
}
