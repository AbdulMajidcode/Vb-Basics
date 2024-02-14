Public Class welcomingForm

    Private Sub welcomingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub


    Private Sub loadbtn_Click(sender As Object, e As EventArgs) Handles loadbtn.Click
        objDemo.Show()
    End Sub



    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub
End Class