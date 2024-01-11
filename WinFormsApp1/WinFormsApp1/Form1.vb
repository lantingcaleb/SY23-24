Imports System.Configuration
Imports System.IO

Public Class Form1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outfile As New StreamWriter("Data.txt")
        outfile.Write(F1.Text)
        outfile.Write("|")
        outfile.Write(F2.Text)
        outfile.Write("|")
        outfile.Write(F3.Text)
        outfile.Write("|")
        outfile.Write(F4.Text)
        outfile.Write("|")
        outfile.Write(F5.Text)
        outfile.Write("|")
        outfile.Write("|")
        outfile.WriteLine(PictureBox1.ImageLocation)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
End Class
