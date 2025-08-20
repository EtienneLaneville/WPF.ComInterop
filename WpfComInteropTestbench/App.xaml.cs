using System.Configuration;
using System.Data;
using System.Windows;
using Wpf.ComInterop;

namespace Wpf.ComInterop.Testbench
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private SimpleComInteropClass? _simpleObject;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Initialize any resources or services needed for the application
            // For example, you might want to set up a service locator or dependency injection container here

            _simpleObject = new SimpleComInteropClass();
            _simpleObject.ShowWindow();


        }

        protected override void OnExit(ExitEventArgs e)
        {
            // Clean up resources or services if necessary
            base.OnExit(e);
        }

    }

}
