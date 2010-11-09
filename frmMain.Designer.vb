<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnable
        '
        Me.btnEnable.Location = New System.Drawing.Point(84, 61)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(107, 23)
        Me.btnEnable.TabIndex = 0
        Me.btnEnable.Text = "Enable Proxy"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(84, 150)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(107, 23)
        Me.btnDisable.TabIndex = 1
        Me.btnDisable.Text = "Disable Proxy"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.btnEnable)
        Me.Name = "frmMain"
        Me.Text = "Proxy Switcher"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnable As System.Windows.Forms.Button
    Friend WithEvents btnDisable As System.Windows.Forms.Button

End Class
