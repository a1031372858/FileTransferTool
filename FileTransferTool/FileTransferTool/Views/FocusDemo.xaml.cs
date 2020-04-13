using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FileTransferTool.Views
{
    /// <summary>
    /// FocusDemo.xaml の相互作用ロジック
    /// </summary>
    public partial class FocusDemo : Window
    {
        private HomeView _homeView = new HomeView();
        public FocusDemo()
        {
            InitializeComponent();
        }

        private void ControlA_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _homeView.Show();
        }
    }
}
