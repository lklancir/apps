﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Degordian_Workload_2.Services.Model
{
    public class ServiceResponse
    {

        public string  access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string id_token { get; set; }
        public string refresh_token { get; set; }
    }
}
