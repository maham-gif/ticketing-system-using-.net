<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Button2 = New Button()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(109, 202)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(230, 31)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19F)
        Label1.Location = New Point(228, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 51)
        Label1.TabIndex = 1
        Label1.Text = "Create An Account"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(346, 454)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 2
        Button1.Text = "Sigin"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(109, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 25)
        Label2.TabIndex = 3
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(487, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 25)
        Label3.TabIndex = 5
        Label3.Text = "Last Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(487, 202)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(230, 31)
        TextBox2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(109, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 25)
        Label4.TabIndex = 7
        Label4.Text = "Phone Number"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(109, 341)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(230, 31)
        TextBox3.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(487, 454)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 8
        Button2.Text = "SignUp"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(503, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 25)
        Label5.TabIndex = 10
        Label5.Text = "Password"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(490, 341)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(230, 31)
        TextBox4.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8F)
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(153, 459)
        Label6.Name = "Label6"
        Label6.Size = New Size(192, 21)
        Label6.TabIndex = 11
        Label6.Text = "Already Have An Account?"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(972, 589)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
End Class
