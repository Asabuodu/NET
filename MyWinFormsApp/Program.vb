' Friend Module Program

'     <STAThread()>
'     Friend Sub Main(args As String())
'         Application.SetHighDpiMode(HighDpiMode.SystemAware)
'         Application.EnableVisualStyles()
'         Application.SetCompatibleTextRenderingDefault(False)
'         Application.Run(New Form1)
'     End Sub

' End Module


' Module Program
'     Sub Main()
'         Application.EnableVisualStyles()
'         Application.SetCompatibleTextRenderingDefault(False)
'         Application.Run(New Form1()) 'Or TemperatureConverter/FutureValueCalculator
'     End Sub
' End Module



Imports System.Windows.Forms

Module Program
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1()) ' Replace with your startup form
    End Sub
End Module