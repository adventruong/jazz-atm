<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class receiptPage
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.receiptChequeing = New System.Windows.Forms.Label()
        Me.receiptSaving = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 95)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction Complete - Receipt Below"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 66)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Balances:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(28, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 54)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chequing:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(48, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 76)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Saving:"
        '
        'receiptChequeing
        '
        Me.receiptChequeing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiptChequeing.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.receiptChequeing.Location = New System.Drawing.Point(147, 154)
        Me.receiptChequeing.Name = "receiptChequeing"
        Me.receiptChequeing.Size = New System.Drawing.Size(393, 26)
        Me.receiptChequeing.TabIndex = 4
        Me.receiptChequeing.Text = "$"
        Me.receiptChequeing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'receiptSaving
        '
        Me.receiptSaving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiptSaving.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.receiptSaving.Location = New System.Drawing.Point(147, 215)
        Me.receiptSaving.Name = "receiptSaving"
        Me.receiptSaving.Size = New System.Drawing.Size(393, 26)
        Me.receiptSaving.TabIndex = 5
        Me.receiptSaving.Text = "$"
        Me.receiptSaving.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(23, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(493, 100)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CONTINUE BANKING"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(23, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(493, 100)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "SIGN OUT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'receiptPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 535)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.receiptSaving)
        Me.Controls.Add(Me.receiptChequeing)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "receiptPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents receiptChequeing As Label
    Friend WithEvents receiptSaving As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
