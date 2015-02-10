using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation.Collections;


namespace Cimbalino.Toolkit.Serives
{
    public interface IApplicationDataService
    {
        IPropertySet LocalSettings { get; }
        IPropertySet RoamingSettings { get; }
    }

    public class ApplicationDataService : IApplicationDataService
    {
        public IPropertySet LocalSettings
        {
            get { return Windows.Storage.ApplicationData.Current.LocalSettings.Values; }
        }

        public IPropertySet RoamingSettings
        {
            get { return Windows.Storage.ApplicationData.Current.RoamingSettings.Values; }
        }
    }
}
