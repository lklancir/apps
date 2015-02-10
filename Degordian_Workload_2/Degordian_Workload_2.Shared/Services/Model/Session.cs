using System;
using System.Collections.Generic;
using System.Text;

namespace Degordian_Workload_2.Services.Model
{
    public class Session
    {
        public string AccessToken { get; set; }
        public string Id { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Provider { get; set; }
    }
}
