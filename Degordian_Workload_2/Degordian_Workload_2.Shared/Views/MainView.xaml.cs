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
using Degordian_Workload_2.ViewModel;
using System.Collections.ObjectModel;
using Degordian_Workload_2.Services.Model;
using Degordian_Workload_2.Services;
using Degordian_Workload_2.Common;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Degordian_Workload_2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView : Page
    {

        //public ObservableCollection<SpreadSheetModel> table = new ObservableCollection<SpreadSheetModel>();
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        public MainView()
        {
            this.InitializeComponent();
            
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

               

        async private void btrRefreshData_Click(object sender, RoutedEventArgs e)
        {

            var tableData = await DataSource.GetTablesAsync();
            this.DefaultViewModel["Table"] = tableData;

            
        }

        async private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var tableData = await DataSource.GetTablesAsync();
            this.DefaultViewModel["Table"] = tableData;
        }
    }
}
