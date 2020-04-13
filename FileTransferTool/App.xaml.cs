using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FileTransferTool.ViewModels;

namespace FileTransferTool
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public HomeView LoginView = new HomeView();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            LoginView.DataContext = new HomeViewModel();
            LoginView.Show();
        }
    }
}
