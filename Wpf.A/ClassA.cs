using System.Windows;

namespace Wpf.A
{

    public enum ItemsA
    {
        Value1,
        Value2,
        Value3
    }

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
