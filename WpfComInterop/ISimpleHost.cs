using System.Runtime.InteropServices;

namespace Wpf.ComInterop
{
    [ComVisible(true)]
    [Guid("08008D0C-8010-4DFE-AF87-524AF6BA370E")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ISimpleHost
    {
        void ShowWindow();

    }
}
