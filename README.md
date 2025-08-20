## WPF COM-Interop demo
This is a simple WPF Class Library project (`Wpf.ComInterop`) designed to illustrate a problem using a `UserControl` from a secondary assembly (`Wpf.A`) when using COM-Interop. A VB6 project is included to replicate the issue.

## Replicating the issue
1. Build the Solution.
2. Using [dscom32](https://github.com/dspace-group/dscom), export a TLB file: `dscom32 tlbexport "(your path)\Wpf.ComInterop.Demo\bin\x86\Debug\net8.0-windows10.0.19041.0\Wpf.ComInterop.dll"`
3. Using [dscom32](https://github.com/dspace-group/dscom), register the TLB file: `dscom32 tlbregister "(your path)\Wpf.ComInterop.Demo\bin\x86\Debug\net8.0-windows10.0.19041.0\Wpf.ComInterop.tlb"`
4. Using RegSvr32, register the comhost.dll file: `regsvr32 "(your path)\Wpf.ComInterop.Demo\bin\x86\Debug\net8.0-windows10.0.19041.0\Wpf.ComInterop.comhost.dll"`
5. Open the VB6 project (`WpfComInteropTestbench.vbp`) and add a Reference to `Wpf_ComInterop`.
6. Run the project. `MainForm` should display.
7. Click the **Show Window** button. A message box should appear with a `System.IO.FileNotFoundException`:<img width="407" height="640" alt="image" src="https://github.com/user-attachments/assets/cdaf3e52-72f4-4e8f-b582-8a438f943b25" />

In `SimpleComInteropClass.cs`, there is an instance of `ClassA` from the `Wpf.A` assembly that is declared but never used. If you uncomment the following lines in the constructor, the `ShowWindow` will now work as expected from VB6:

```
public SimpleComInteropClass()
{
    _a = new ClassA();
    _a.DoA();
}
```

<img width="379" height="234" alt="image" src="https://github.com/user-attachments/assets/c5a10baa-d080-4842-8bbf-4d77e58022c1" />
