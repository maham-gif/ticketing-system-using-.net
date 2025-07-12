<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 674)
        Panel1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Arcade rides = Rs.300      ", "Kidde Area = Rs.200", "Soft Play Area = Rs.200", "Dodging Car /Bumper cars = Rs. 350"})
        ComboBox1.Location = New Point(290, 210)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(251, 33)
        ComboBox1.TabIndex = 1
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Freefall Jump = Rs. 1000", "Zipline (short ) =Rs. 600", "Zipline ( long) =Rs. 2500", "Sky cycling ( 550feet) =Rs. 600", "Wall climbing (50 feet) =Rs.   600" & vbTab, "Archery ( 6 Arrows) =Rs.600", "Airgun Shooting =Rs.600", "Gyroscopic (360 rotating) =Rs. 350/-", "Gaint Swing =Rs. 1000/-  ", "Rocket Bunji =Rs. 1000/-"})
        ComboBox2.Location = New Point(740, 210)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(251, 33)
        ComboBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19F)
        Label1.Location = New Point(283, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 51)
        Label1.TabIndex = 3
        Label1.Text = "Select Rides"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(879, 553)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 4
        Button1.Text = "Ticket"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(289, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 25)
        Label2.TabIndex = 5
        Label2.Text = "Indoor Rides"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(739, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 25)
        Label3.TabIndex = 6
        Label3.Text = "OutDoor Rides"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 19F)
        Label4.Location = New Point(289, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 51)
        Label4.TabIndex = 7
        Label4.Text = "Discounts "
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(302, 396)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(147, 29)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "10% Discount"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(566, 398)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(147, 29)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "20% Discount"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 19F)
        Label5.Location = New Point(302, 473)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 102)
        Label5.TabIndex = 10
        Label5.Text = "Total" & vbCrLf & "=" & vbCrLf
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1143, 662)
        Controls.Add(Label5)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Panel1)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label5 As Label
End Class
