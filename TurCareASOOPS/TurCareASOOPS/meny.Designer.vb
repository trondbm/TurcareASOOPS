﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class meny
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
        Me.btnLeggTilAnsatt = New System.Windows.Forms.Button()
        Me.btnLeggTilVare = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSjekkLager = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLeggTilAnsatt
        '
        Me.btnLeggTilAnsatt.Location = New System.Drawing.Point(70, 57)
        Me.btnLeggTilAnsatt.Name = "btnLeggTilAnsatt"
        Me.btnLeggTilAnsatt.Size = New System.Drawing.Size(119, 54)
        Me.btnLeggTilAnsatt.TabIndex = 0
        Me.btnLeggTilAnsatt.Text = "Legg til ny person"
        Me.btnLeggTilAnsatt.UseVisualStyleBackColor = True
        '
        'btnLeggTilVare
        '
        Me.btnLeggTilVare.Location = New System.Drawing.Point(242, 57)
        Me.btnLeggTilVare.Name = "btnLeggTilVare"
        Me.btnLeggTilVare.Size = New System.Drawing.Size(119, 54)
        Me.btnLeggTilVare.TabIndex = 1
        Me.btnLeggTilVare.Text = "Legg til vare"
        Me.btnLeggTilVare.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(403, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 54)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Statistikk"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSjekkLager
        '
        Me.btnSjekkLager.Location = New System.Drawing.Point(70, 143)
        Me.btnSjekkLager.Name = "btnSjekkLager"
        Me.btnSjekkLager.Size = New System.Drawing.Size(119, 54)
        Me.btnSjekkLager.TabIndex = 3
        Me.btnSjekkLager.Text = "Sjekk lagerstatus"
        Me.btnSjekkLager.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(242, 143)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 54)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Salg"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(403, 143)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 54)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Utleie"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(70, 306)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(119, 54)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(242, 233)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(119, 54)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Kurs"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(403, 306)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(119, 54)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hovedmeny"
        '
        'meny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 372)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnSjekkLager)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnLeggTilVare)
        Me.Controls.Add(Me.btnLeggTilAnsatt)
        Me.Name = "meny"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLeggTilAnsatt As Button
    Friend WithEvents btnLeggTilVare As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnSjekkLager As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label1 As Label
End Class
