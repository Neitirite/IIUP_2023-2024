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
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        Label2 = New Label()
        Label3 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(506, 45)
        Label1.TabIndex = 0
        Label1.Text = "Тест на тему ""Прикладное ПО"""
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProgressBar1.Location = New Point(1291, 20)
        ProgressBar1.Maximum = 10
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(459, 28)
        ProgressBar1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(1291, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 21)
        Label2.TabIndex = 2
        Label2.Text = "Вопрос 1 из 10"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(12, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(230, 45)
        Label3.TabIndex = 3
        Label3.Text = "Текст вопроса"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.Anchor = AnchorStyles.Left
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        RadioButton1.Location = New Point(24, 142)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(83, 25)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Ответ 1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.Anchor = AnchorStyles.Left
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        RadioButton2.Location = New Point(24, 191)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(83, 25)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "Ответ 2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.Anchor = AnchorStyles.Left
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        RadioButton3.Location = New Point(24, 239)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(83, 25)
        RadioButton3.TabIndex = 4
        RadioButton3.TabStop = True
        RadioButton3.Text = "Ответ 3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.Anchor = AnchorStyles.Left
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        RadioButton4.Location = New Point(24, 288)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(83, 25)
        RadioButton4.TabIndex = 4
        RadioButton4.TabStop = True
        RadioButton4.Text = "Ответ 4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.Teal
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(24, 334)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 44)
        Button1.TabIndex = 5
        Button1.Text = "Проверить"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1755, 397)
        Controls.Add(Button1)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Button1 As Button

End Class
