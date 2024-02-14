<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcomingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        loadbtn = New Button()
        exitbtn = New Button()
        SuspendLayout()
        ' 
        ' loadbtn
        ' 
        loadbtn.Location = New Point(181, 258)
        loadbtn.Name = "loadbtn"
        loadbtn.Size = New Size(244, 34)
        loadbtn.TabIndex = 0
        loadbtn.Text = "&Load Object Demo"
        loadbtn.UseVisualStyleBackColor = True
        ' 
        ' exitbtn
        ' 
        exitbtn.Location = New Point(529, 258)
        exitbtn.Name = "exitbtn"
        exitbtn.Size = New Size(112, 34)
        exitbtn.TabIndex = 1
        exitbtn.Text = "E&XIT"
        exitbtn.UseVisualStyleBackColor = True
        ' 
        ' welcomingForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(exitbtn)
        Controls.Add(loadbtn)
        Name = "welcomingForm"
        Text = "welcomingForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents loadbtn As Button
    Friend WithEvents exitbtn As Button
End Class
