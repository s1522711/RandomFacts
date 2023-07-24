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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Timer1 = New Timer(components)
        GroupBox1 = New GroupBox()
        DeSel = New RadioButton()
        EnSel = New RadioButton()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        DayFact = New RadioButton()
        RanFact = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 30)
        Button1.TabIndex = 0
        Button1.Text = "Get Fact!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 500
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DeSel)
        GroupBox1.Controls.Add(EnSel)
        GroupBox1.Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 48)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(147, 75)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sprache"
        ' 
        ' DeSel
        ' 
        DeSel.AutoSize = True
        DeSel.BackColor = Color.Transparent
        DeSel.Location = New Point(6, 47)
        DeSel.Name = "DeSel"
        DeSel.Size = New Size(84, 24)
        DeSel.TabIndex = 1
        DeSel.Text = "Deutsch"
        DeSel.UseVisualStyleBackColor = False
        ' 
        ' EnSel
        ' 
        EnSel.AutoSize = True
        EnSel.Checked = True
        EnSel.Location = New Point(6, 22)
        EnSel.Name = "EnSel"
        EnSel.Size = New Size(75, 24)
        EnSel.TabIndex = 0
        EnSel.TabStop = True
        EnSel.Text = "English"
        EnSel.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(165, 12)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.ScrollBars = ScrollBars.Both
        TextBox1.Size = New Size(316, 192)
        TextBox1.TabIndex = 3
        TextBox1.Text = "Please Press The Button to Start!"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DayFact)
        GroupBox2.Controls.Add(RanFact)
        GroupBox2.Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(12, 129)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(147, 75)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Fact Type"
        ' 
        ' DayFact
        ' 
        DayFact.AutoSize = True
        DayFact.BackColor = Color.Transparent
        DayFact.Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DayFact.Location = New Point(6, 47)
        DayFact.Name = "DayFact"
        DayFact.Size = New Size(137, 24)
        DayFact.TabIndex = 1
        DayFact.Text = "Fact of the Day"
        DayFact.UseVisualStyleBackColor = False
        ' 
        ' RanFact
        ' 
        RanFact.AutoSize = True
        RanFact.Checked = True
        RanFact.Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point)
        RanFact.Location = New Point(6, 22)
        RanFact.Name = "RanFact"
        RanFact.Size = New Size(116, 24)
        RanFact.TabIndex = 0
        RanFact.TabStop = True
        RanFact.Text = "Random Fact"
        RanFact.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(492, 216)
        Controls.Add(GroupBox2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimumSize = New Size(508, 255)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fact Generator"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DeSel As RadioButton
    Friend WithEvents EnSel As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DayFact As RadioButton
    Friend WithEvents RanFact As RadioButton
End Class
