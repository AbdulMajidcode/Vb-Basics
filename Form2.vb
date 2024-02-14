Public Class objDemo


    Private Sub font_Enter(sender As Object, e As EventArgs) Handles rbnGaramond.CheckedChanged,
        rbnMagneto.CheckedChanged,
        rbnTahoma.CheckedChanged

        If rbnGaramond.Checked Then
            sampletest.Font = New Font("Garamond", sampletest.Font.Size)
        ElseIf rbnMagneto.Checked Then
            sampletest.Font = New Font("Magneto", sampletest.Font.Size)
        ElseIf rbnTahoma.Checked Then
            sampletest.Font = New Font("Tahoma", sampletest.Font.Size)

        End If


    End Sub

    Private Sub fontstyle1_Enter(sender As Object, e As EventArgs) Handles italic.CheckedChanged,
            bold.CheckedChanged, bolditalic.CheckedChanged
        Dim fontstyle1 As FontStyle = FontStyle.Regular
        If italic.Checked Then
            fontstyle1 = fontstyle1 Or FontStyle.Italic
        ElseIf bold.Checked Then
            fontstyle1 = fontstyle1 Or FontStyle.Bold
        ElseIf bolditalic.Checked Then
            fontstyle1 = fontstyle1 Or FontStyle.Bold Or FontStyle.Italic
        End If

        displaytest.Font = New Font(displaytest.Font, fontstyle1)

    End Sub

    Private Sub fontColor_Enter(sender As Object, e As EventArgs) Handles rbngreen.CheckedChanged,
    rbnblue.CheckedChanged, rbnred.CheckedChanged
        If rbngreen.Checked Then
            sampletest.ForeColor = Color.Green
        ElseIf rbnblue.Checked Then
            sampletest.ForeColor = Color.Blue
        ElseIf rbnred.Checked Then
            sampletest.ForeColor = Color.Red
        End If

    End Sub

    Private Sub loadpicbtn_Click(sender As Object, e As EventArgs) Handles loadpicbtn.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image files(*.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            If ofd.ShowDialog() =
                    DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(ofd.FileName)
            End If
        End Using

    End Sub

    Private Sub extbutton_Click(sender As Object, e As EventArgs) Handles extbutton.Click
        Me.Close()
    End Sub


End Class