<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informationPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chequeingDisplay = New System.Windows.Forms.Label()
        Me.savingDisplay = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.displayName = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(38, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chequing: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(57, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Savings:"
        '
        'chequeingDisplay
        '
        Me.chequeingDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chequeingDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chequeingDisplay.Location = New System.Drawing.Point(167, 65)
        Me.chequeingDisplay.Name = "chequeingDisplay"
        Me.chequeingDisplay.Size = New System.Drawing.Size(361, 29)
        Me.chequeingDisplay.TabIndex = 2
        Me.chequeingDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'savingDisplay
        '
        Me.savingDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savingDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.savingDisplay.Location = New System.Drawing.Point(172, 110)
        Me.savingDisplay.Name = "savingDisplay"
        Me.savingDisplay.Size = New System.Drawing.Size(356, 29)
        Me.savingDisplay.TabIndex = 3
        Me.savingDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(12, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 174)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "WITHDRAW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(273, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 174)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "DEPOSIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(12, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(255, 174)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "TRANSFER"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(273, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(255, 174)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "INTERAC E-TRANSFER"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'displayName
        '
        Me.displayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.displayName.Location = New System.Drawing.Point(55, 14)
        Me.displayName.Name = "displayName"
        Me.displayName.Size = New System.Drawing.Size(444, 51)
        Me.displayName.TabIndex = 8
        Me.displayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Location = New System.Drawing.Point(413, 544)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(115, 49)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "SIGN OUT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(12, 544)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 49)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "ACCOUNT HISTORY"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'informationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 600)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.displayName)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.savingDisplay)
        Me.Controls.Add(Me.chequeingDisplay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "informationPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chequeingDisplay As Label
    Friend WithEvents savingDisplay As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents displayName As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
End Class
