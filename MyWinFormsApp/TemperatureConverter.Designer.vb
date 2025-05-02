Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TemperatureConverter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Controls
    Friend WithEvents Calculation As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FahrenheitInt As TextBox
    Friend WithEvents CResult As TextBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        'Add control initialization code here
        'Example:
        Me.Calculation = New System.Windows.Forms.Button()
        Me.FahrenheitInt = New System.Windows.Forms.TextBox()
        Me.CResult = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        '
        'Position controls using Location/Size properties
        '
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.Calculation)
        Me.Controls.Add(Me.FahrenheitInt)
        Me.Controls.Add(Me.CResult)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
    End Sub
End Class