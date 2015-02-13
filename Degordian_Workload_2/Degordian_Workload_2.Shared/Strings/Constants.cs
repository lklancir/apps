using System;
using System.Collections.Generic;
using System.Text;

namespace Degordian_Workload_2.Strings
{
    public class Constants
    {
#if !WINDOWS_PHONE_APP
        public const string GoogleCallbackUrl = "urn:ietf:wg:oauth:2.0:oob";
#else
        public const string GoogleCallbackUrl = "http://localhost";
#endif
        public const string GoogleClientId = "124165219727-61vvf5a7ke8sen09qsrv6q1bjrj5kj73.apps.googleusercontent.com";
        public const string GoogleClientSecret = "Z1Zm_u964zCCMiu9c0b16kiJ";
        public const string LoginToken = "LoginToken";
        public const string GoogleProvider = "google";

    }
}
