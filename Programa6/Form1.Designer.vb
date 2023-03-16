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
        txtDatos = New TextBox()
        txtResultado = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' txtDatos
        ' 
        txtDatos.Location = New Point(80, 135)
        txtDatos.Name = "txtDatos"
        txtDatos.Size = New Size(125, 27)
        txtDatos.TabIndex = 0
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(405, 135)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(125, 27)
        txtResultado.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(80, 196)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "GUARDAD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(405, 196)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 3
        Button2.Text = "CARGAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtResultado)
        Controls.Add(txtDatos)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDatos As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
