using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Degordian_Workload_2.Services.Interfaces
{
    public interface ILogManager
    {
        void Init(string key);
        Task LogAsync(Exception e);
        Task CloseAsync();
    }
}
