<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaunchLangSel
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LaunchLangSel))
        BtnEn = New Button()
        BtnDe = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' BtnEn
        ' 
        BtnEn.FlatAppearance.BorderSize = 2
        BtnEn.FlatStyle = FlatStyle.Flat
        BtnEn.ForeColor = Color.Transparent
        BtnEn.Image = My.Resources.Resources.Flag_of_Great_Britain_17071800_3_287x172
        BtnEn.Location = New Point(12, 54)
        BtnEn.Name = "BtnEn"
        BtnEn.Size = New Size(287, 172)
        BtnEn.TabIndex = 0
        BtnEn.Text = "English"
        BtnEn.UseVisualStyleBackColor = True
        ' 
        ' BtnDe
        ' 
        BtnDe.FlatAppearance.BorderSize = 2
        BtnDe.FlatStyle = FlatStyle.Flat
        BtnDe.ForeColor = Color.Transparent
        BtnDe.Image = My.Resources.Resources.Flag_of_Germany_287x172
        BtnDe.Location = New Point(305, 54)
        BtnDe.Name = "BtnDe"
        BtnDe.Size = New Size(287, 172)
        BtnDe.TabIndex = 1
        BtnDe.Text = "Deutsch"
        BtnDe.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(114, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 21)
        Label1.TabIndex = 2
        Label1.Text = "In what language you would like to receive your facts?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(114, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(379, 21)
        Label2.TabIndex = 3
        Label2.Text = "In welcher Sprache möchten Sie Ihre Fakten erhalten?"
        ' 
        ' LaunchLangSel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(605, 236)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnDe)
        Controls.Add(BtnEn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "LaunchLangSel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fact Generator Language Select"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnEn As Button
    Friend WithEvents BtnDe As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
