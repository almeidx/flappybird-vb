<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MainWindow = New System.Windows.Forms.PictureBox()
        Me.Render = New System.Windows.Forms.Timer(Me.components)
        CType(Me.MainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWindow
        '
        Me.MainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainWindow.Location = New System.Drawing.Point(0, 0)
        Me.MainWindow.Name = "MainWindow"
        Me.MainWindow.Size = New System.Drawing.Size(1000, 1000)
        Me.MainWindow.TabIndex = 0
        Me.MainWindow.TabStop = False
        '
        'Render
        '
        Me.Render.Enabled = True
        Me.Render.Interval = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 1000)
        Me.Controls.Add(Me.MainWindow)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainWindow As PictureBox
    Friend WithEvents Render As Timer
End Class
