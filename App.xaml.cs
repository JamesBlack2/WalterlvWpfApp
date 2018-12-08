using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WalterlvWpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            this.Startup += App_Startup;
           
        }
        private void App_Startup(object sender, StartupEventArgs e)
        {
            MessageBox.Show("fasdf");
        }
    }
}
