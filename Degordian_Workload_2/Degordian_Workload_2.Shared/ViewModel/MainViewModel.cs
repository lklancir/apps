using Cimbalino.Toolkit.Services;
using Degordian_Workload_2.Common;
using Degordian_Workload_2.Services;
using Degordian_Workload_2.Services.Interfaces;
using Degordian_Workload_2.Services.Model;
using Degordian_Workload_2.Views;
using GalaSoft.MvvmLight;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Degordian_Workload_2.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        private readonly INavigationService _navigationService;
        private readonly ILogManager _logManager;
        private readonly ISessionService _sessionService;

        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(INavigationService navigationService,
            ILogManager logManager, ISessionService sessionService)

        {
            _navigationService = navigationService;
            _logManager = logManager;
            _sessionService = sessionService;
            LogoutCommand = new RelayCommand(
                () =>
                {
                    _sessionService.Logout();

                    // todo navigation
                    _navigationService.Navigate<LoginView>();
                });
            AboutCommand = new RelayCommand(
                async () =>
                {
                    Exception exception = null;
                    try
                    {
                        // todo navigation
                        // _navigationService.Navigate(new Uri(Constants.AboutView, UriKind.Relative));
                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                    }

                    if (exception != null)
                    {
                        await _logManager.LogAsync(exception);
                    }
                });


        }
        public ICommand AboutCommand { get; private set; }

        /// <summary>
        /// Gets the logout command.
        /// </summary>
        /// <value>
        /// The logout command.
        /// </value>
        public ICommand LogoutCommand { get; private set; }

        
        public void FillTable()
        {
           //All logic for filling the table (model) should go here but is instead in MainView.xaml.cs
           // Don't know how to call it
        }

    }
}