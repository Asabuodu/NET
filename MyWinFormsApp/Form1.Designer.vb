Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

Friend WithEvents btnCalculate As Button
    Friend WithEvents txtArray As TextBox
    Friend WithEvents txtk As TextBox
    Friend WithEvents txtResult As TextBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtArray = New System.Windows.Forms.TextBox()
        Me.txtk = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(20, 100)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 30)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        '
        'txtArray
        '
        Me.txtArray.Location = New System.Drawing.Point(20, 20)
        Me.txtArray.Name = "txtArray"
        Me.txtArray.Size = New System.Drawing.Size(200, 20)
        Me.txtArray.TabIndex = 1
        '
        'txtk
        '
        Me.txtk.Location = New System.Drawing.Point(20, 60)
        Me.txtk.Name = "txtk"
        Me.txtk.Size = New System.Drawing.Size(100, 20)
        Me.txtk.TabIndex = 2
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(20, 150)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(200, 20)
        Me.txtResult.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtk)
        Me.Controls.Add(Me.txtArray)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Array Divider"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' Friend WithEvents btnCalculate As Button
    ' Friend WithEvents txtArray As TextBox
    ' Friend WithEvents txtk As TextBox
    ' Friend WithEvents txtResult As TextBox
End Class