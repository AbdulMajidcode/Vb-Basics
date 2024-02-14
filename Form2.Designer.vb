<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class objDemo
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
        displaytest = New GroupBox()
        sampletest = New TextBox()
        font = New GroupBox()
        rbnTahoma = New RadioButton()
        rbnMagneto = New RadioButton()
        rbnGaramond = New RadioButton()
        PictureBox1 = New PictureBox()
        fontstyle1 = New GroupBox()
        bolditalic = New CheckBox()
        bold = New CheckBox()
        italic = New CheckBox()
        fontColor1 = New GroupBox()
        rbnred = New RadioButton()
        rbnblue = New RadioButton()
        rbngreen = New RadioButton()
        loadpicbtn = New Button()
        extbutton = New Button()
        displaytest.SuspendLayout()
        font.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        fontstyle1.SuspendLayout()
        fontColor1.SuspendLayout()
        SuspendLayout()
        ' 
        ' displaytest
        ' 
        displaytest.Controls.Add(sampletest)
        displaytest.Location = New Point(12, 26)
        displaytest.Name = "displaytest"
        displaytest.Size = New Size(300, 150)
        displaytest.TabIndex = 0
        displaytest.TabStop = False
        displaytest.Text = "Display Test"
        ' 
        ' sampletest
        ' 
        sampletest.Location = New Point(37, 57)
        sampletest.Name = "sampletest"
        sampletest.Size = New Size(150, 31)
        sampletest.TabIndex = 0
        sampletest.Text = "Sample Test"
        ' 
        ' font
        ' 
        font.Controls.Add(rbnTahoma)
        font.Controls.Add(rbnMagneto)
        font.Controls.Add(rbnGaramond)
        font.Location = New Point(357, 26)
        font.Name = "font"
        font.Size = New Size(688, 150)
        font.TabIndex = 1
        font.TabStop = False
        font.Text = "Font"
        ' 
        ' rbnTahoma
        ' 
        rbnTahoma.AutoSize = True
        rbnTahoma.Location = New Point(474, 55)
        rbnTahoma.Name = "rbnTahoma"
        rbnTahoma.Size = New Size(99, 29)
        rbnTahoma.TabIndex = 4
        rbnTahoma.TabStop = True
        rbnTahoma.Text = "Tahoma"
        rbnTahoma.UseVisualStyleBackColor = True
        ' 
        ' rbnMagneto
        ' 
        rbnMagneto.AutoSize = True
        rbnMagneto.Location = New Point(267, 46)
        rbnMagneto.Name = "rbnMagneto"
        rbnMagneto.Size = New Size(109, 29)
        rbnMagneto.TabIndex = 3
        rbnMagneto.TabStop = True
        rbnMagneto.Text = "Magneto"
        rbnMagneto.UseVisualStyleBackColor = True
        ' 
        ' rbnGaramond
        ' 
        rbnGaramond.AutoSize = True
        rbnGaramond.Location = New Point(22, 44)
        rbnGaramond.Name = "rbnGaramond"
        rbnGaramond.Size = New Size(121, 29)
        rbnGaramond.TabIndex = 2
        rbnGaramond.TabStop = True
        rbnGaramond.Text = "Garamond"
        rbnGaramond.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(49, 233)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(339, 210)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' fontstyle1
        ' 
        fontstyle1.Controls.Add(bolditalic)
        fontstyle1.Controls.Add(bold)
        fontstyle1.Controls.Add(italic)
        fontstyle1.Location = New Point(468, 207)
        fontstyle1.Name = "fontstyle1"
        fontstyle1.Size = New Size(300, 236)
        fontstyle1.TabIndex = 5
        fontstyle1.TabStop = False
        fontstyle1.Text = "Font Style"
        ' 
        ' bolditalic
        ' 
        bolditalic.AutoSize = True
        bolditalic.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        bolditalic.Location = New Point(29, 162)
        bolditalic.Name = "bolditalic"
        bolditalic.Size = New Size(126, 29)
        bolditalic.TabIndex = 2
        bolditalic.Text = "Bold Italic"
        bolditalic.UseVisualStyleBackColor = True
        ' 
        ' bold
        ' 
        bold.AutoSize = True
        bold.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bold.Location = New Point(29, 103)
        bold.Name = "bold"
        bold.Size = New Size(77, 29)
        bold.TabIndex = 1
        bold.Text = "Bold"
        bold.UseVisualStyleBackColor = True
        ' 
        ' italic
        ' 
        italic.AutoSize = True
        italic.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        italic.Location = New Point(29, 46)
        italic.Name = "italic"
        italic.Size = New Size(77, 29)
        italic.TabIndex = 0
        italic.Text = "Italic"
        italic.UseVisualStyleBackColor = True
        ' 
        ' fontColor1
        ' 
        fontColor1.Controls.Add(rbnred)
        fontColor1.Controls.Add(rbnblue)
        fontColor1.Controls.Add(rbngreen)
        fontColor1.Location = New Point(817, 218)
        fontColor1.Name = "fontColor1"
        fontColor1.Size = New Size(300, 214)
        fontColor1.TabIndex = 0
        fontColor1.TabStop = False
        fontColor1.Text = "Font Color"
        ' 
        ' rbnred
        ' 
        rbnred.AutoSize = True
        rbnred.Location = New Point(36, 141)
        rbnred.Name = "rbnred"
        rbnred.Size = New Size(67, 29)
        rbnred.TabIndex = 2
        rbnred.TabStop = True
        rbnred.Text = "&Red"
        rbnred.UseVisualStyleBackColor = True
        ' 
        ' rbnblue
        ' 
        rbnblue.AutoSize = True
        rbnblue.Location = New Point(36, 91)
        rbnblue.Name = "rbnblue"
        rbnblue.Size = New Size(70, 29)
        rbnblue.TabIndex = 1
        rbnblue.TabStop = True
        rbnblue.Text = "&Blue"
        rbnblue.UseVisualStyleBackColor = True
        ' 
        ' rbngreen
        ' 
        rbngreen.AutoSize = True
        rbngreen.Location = New Point(36, 46)
        rbngreen.Name = "rbngreen"
        rbngreen.Size = New Size(83, 29)
        rbngreen.TabIndex = 0
        rbngreen.TabStop = True
        rbngreen.Text = "&Green"
        rbngreen.UseVisualStyleBackColor = True
        ' 
        ' loadpicbtn
        ' 
        loadpicbtn.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loadpicbtn.Location = New Point(60, 468)
        loadpicbtn.Name = "loadpicbtn"
        loadpicbtn.Size = New Size(215, 34)
        loadpicbtn.TabIndex = 6
        loadpicbtn.Text = "&Load Picture"
        loadpicbtn.UseVisualStyleBackColor = True
        ' 
        ' extbutton
        ' 
        extbutton.Location = New Point(865, 456)
        extbutton.Name = "extbutton"
        extbutton.Size = New Size(169, 34)
        extbutton.TabIndex = 7
        extbutton.Text = "E&XIT"
        extbutton.UseVisualStyleBackColor = True
        ' 
        ' objDemo
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1210, 532)
        Controls.Add(extbutton)
        Controls.Add(loadpicbtn)
        Controls.Add(fontColor1)
        Controls.Add(fontstyle1)
        Controls.Add(PictureBox1)
        Controls.Add(font)
        Controls.Add(displaytest)
        Name = "objDemo"
        Text = "Object Demonstratios"
        displaytest.ResumeLayout(False)
        displaytest.PerformLayout()
        font.ResumeLayout(False)
        font.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        fontstyle1.ResumeLayout(False)
        fontstyle1.PerformLayout()
        fontColor1.ResumeLayout(False)
        fontColor1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents displaytest As GroupBox
    Friend WithEvents sampletest As TextBox
    Friend WithEvents font As GroupBox
    Friend WithEvents rbnTahoma As RadioButton
    Friend WithEvents rbnMagneto As RadioButton
    Friend WithEvents rbnGaramond As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents fontstyle1 As GroupBox
    Friend WithEvents fontColor1 As GroupBox
    Friend WithEvents bolditalic As CheckBox
    Friend WithEvents bold As CheckBox
    Friend WithEvents italic As CheckBox
    Friend WithEvents rbnred As RadioButton
    Friend WithEvents rbnblue As RadioButton
    Friend WithEvents rbngreen As RadioButton
    Friend WithEvents loadpicbtn As Button
    Friend WithEvents extbutton As Button
End Class
