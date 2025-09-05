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
        Crut = New ComboBox()
        Label1 = New Label()
        Tnombre = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Csexo = New ComboBox()
        Label5 = New Label()
        Tdir = New TextBox()
        Tcomuna = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Crut
        ' 
        Crut.FormattingEnabled = True
        Crut.Location = New Point(103, 25)
        Crut.Margin = New Padding(3, 2, 3, 2)
        Crut.Name = "Crut"
        Crut.Size = New Size(133, 23)
        Crut.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 1
        Label1.Text = "RUT:"
        ' 
        ' Tnombre
        ' 
        Tnombre.Location = New Point(103, 58)
        Tnombre.Margin = New Padding(3, 2, 3, 2)
        Tnombre.Name = "Tnombre"
        Tnombre.Size = New Size(298, 23)
        Tnombre.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 3
        Label2.Text = "NOMBRE:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 4
        Label3.Text = "DIRECCION"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 5
        Label4.Text = "COMUNA"
        ' 
        ' Csexo
        ' 
        Csexo.FormattingEnabled = True
        Csexo.Location = New Point(103, 225)
        Csexo.Margin = New Padding(3, 2, 3, 2)
        Csexo.Name = "Csexo"
        Csexo.Size = New Size(133, 23)
        Csexo.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 7
        Label5.Text = "SEXO:"
        ' 
        ' Tdir
        ' 
        Tdir.Location = New Point(103, 158)
        Tdir.Margin = New Padding(3, 2, 3, 2)
        Tdir.Name = "Tdir"
        Tdir.Size = New Size(298, 23)
        Tdir.TabIndex = 8
        ' 
        ' Tcomuna
        ' 
        Tcomuna.Location = New Point(103, 191)
        Tcomuna.Margin = New Padding(3, 2, 3, 2)
        Tcomuna.Name = "Tcomuna"
        Tcomuna.Size = New Size(188, 23)
        Tcomuna.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(103, 270)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(280, 22)
        Button1.TabIndex = 10
        Button1.Text = "GUARDAR EN BASE DE DATOS!!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(413, 96)
        Controls.Add(Button1)
        Controls.Add(Tcomuna)
        Controls.Add(Tdir)
        Controls.Add(Label5)
        Controls.Add(Csexo)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Tnombre)
        Controls.Add(Label1)
        Controls.Add(Crut)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Clase 4 / 2025"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Crut As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Csexo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tdir As TextBox
    Friend WithEvents Tcomuna As TextBox
    Friend WithEvents Button1 As Button

End Class
