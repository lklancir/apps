using Degordian_Workload_2.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.Activation;
using Degordian_Workload_2.Services;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Degordian_Workload_2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
#if WINDOWS_PHONE_APP
       public sealed partial class LoginView : Page, IWebAuthenticationContinuable
#else
    public sealed partial class LoginView : Page
#endif
    {
        public LoginView()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var viewModel = (LoginViewModel)DataContext;
            viewModel.NavigationService.RemoveBackEntry();
            base.OnNavigatedTo(e);
        }

#if WINDOWS_PHONE_APP
        public void ContinueWebAuthentication(Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs args)
        {
            var viewModel = (LoginViewModel) DataContext;
            viewModel.Finalize(args);
        }
#endif
    }
}
