﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManufacturerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EngineStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrivetrainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F1 = New System.Windows.Forms.TextBox()
        Me.F2 = New System.Windows.Forms.TextBox()
        Me.F3 = New System.Windows.Forms.TextBox()
        Me.F4 = New System.Windows.Forms.TextBox()
        Me.F5 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ManufacturerToolStripMenuItem, Me.EngineStyleToolStripMenuItem, Me.DrivetrainToolStripMenuItem, Me.YearToolStripMenuItem, Me.TonToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ManufacturerToolStripMenuItem
        '
        Me.ManufacturerToolStripMenuItem.Name = "ManufacturerToolStripMenuItem"
        Me.ManufacturerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ManufacturerToolStripMenuItem.Text = "Manufacturer"
        '
        'EngineStyleToolStripMenuItem
        '
        Me.EngineStyleToolStripMenuItem.Name = "EngineStyleToolStripMenuItem"
        Me.EngineStyleToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EngineStyleToolStripMenuItem.Text = "Engine Style"
        '
        'DrivetrainToolStripMenuItem
        '
        Me.DrivetrainToolStripMenuItem.Name = "DrivetrainToolStripMenuItem"
        Me.DrivetrainToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DrivetrainToolStripMenuItem.Text = "Drivetrain"
        '
        'YearToolStripMenuItem
        '
        Me.YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        Me.YearToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.YearToolStripMenuItem.Text = "Year"
        '
        'TonToolStripMenuItem
        '
        Me.TonToolStripMenuItem.Name = "TonToolStripMenuItem"
        Me.TonToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TonToolStripMenuItem.Text = "1/4 Ton"
        '
        'F1
        '
        Me.F1.Location = New System.Drawing.Point(34, 66)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(125, 27)
        Me.F1.TabIndex = 1
        '
        'F2
        '
        Me.F2.Location = New System.Drawing.Point(34, 131)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(125, 27)
        Me.F2.TabIndex = 2
        '
        'F3
        '
        Me.F3.Location = New System.Drawing.Point(34, 206)
        Me.F3.Name = "F3"
        Me.F3.Size = New System.Drawing.Size(125, 27)
        Me.F3.TabIndex = 3
        '
        'F4
        '
        Me.F4.Location = New System.Drawing.Point(34, 284)
        Me.F4.Name = "F4"
        Me.F4.Size = New System.Drawing.Size(125, 27)
        Me.F4.TabIndex = 4
        '
        'F5
        '
        Me.F5.Location = New System.Drawing.Point(34, 360)
        Me.F5.Name = "F5"
        Me.F5.Size = New System.Drawing.Size(125, 27)
        Me.F5.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(280, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(477, 321)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.F5)
        Me.Controls.Add(Me.F4)
        Me.Controls.Add(Me.F3)
        Me.Controls.Add(Me.F2)
        Me.Controls.Add(Me.F1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManufacturerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EngineStyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrivetrainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F1 As TextBox
    Friend WithEvents F2 As TextBox
    Friend WithEvents F3 As TextBox
    Friend WithEvents F4 As TextBox
    Friend WithEvents F5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
