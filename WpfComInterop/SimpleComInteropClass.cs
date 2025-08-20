using System.Runtime.InteropServices;
using System.Windows;
using Wpf.A;

namespace Wpf.ComInterop
{

    [ComVisible(true)]
    [Guid("B1EB22FA-4E77-4CD8-AE56-2C4D17716DD2")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("Wpf.ComInterop.SimpleComInteropClass")]
    public class SimpleComInteropClass : ISimpleHost
    {

        private ClassA _a;

        public SimpleComInteropClass()
        {
            //_a = new ClassA();
            //_a.DoA();
        }

        public void ShowWindow()
        {
            try
            {
                SimpleWindow window = new SimpleWindow();
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error creating window: {1}{0}{0}{2}", Environment.NewLine, ex.Message, ex.InnerException), "Error");
            }
        }
    }

}
