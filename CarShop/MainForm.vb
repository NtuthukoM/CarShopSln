Public Class MainForm
    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click

        Dim client = New NewClientForm
        client.MdiParent = Me
        client.Show()
    End Sub
End Class
