using System.Windows;

namespace Wpf.A
{

    public class ClassA
    {

        public ClassA()
        {
            A = "Hello from ClassA";
        }

        public string A { get; set; }

        public void DoA()
        {
            MessageBox.Show(A);
        }

    }

}
