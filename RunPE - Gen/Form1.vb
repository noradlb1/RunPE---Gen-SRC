Public Class Form1
    Public Function GenStr(ByVal len As Long)
        Dim rnd As New Random
        Dim arb As String = "発表されま時期況を知らせる桜開花桜の開花状"
        Dim result As String = Nothing
        For i = 0 To len
            result = result & arb(rnd.Next(arb.Length))
        Next
        Return result
    End Function
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Dim OP As New SaveFileDialog
        With OP
            .Filter = "RunPE|*.txt"
            .ShowDialog()
        End With
        System.IO.File.WriteAllText(OP.FileName, TextBox1.Text)
        MessageBox.Show("Saved Complete : " & OP.FileName, "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("RunPE Coded By Simon-Benyo" & " | " & "Generator Coded By : Your Name", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratorToolStripMenuItem.Click
        Dim P As String = My.Resources.String1
        Dim R As String
        R = P.Replace("%1%", GenStr(4)).Replace("%2%", GenStr(6)).Replace("%3%", GenStr(8)).Replace("%4%", GenStr(10)) _
            .Replace("%5%", GenStr(12)).Replace("%6%", GenStr(14)).Replace("%7%", GenStr(16)).Replace("%8%", GenStr(18)) _
            .Replace("%9%", GenStr(20)).Replace("%10%", GenStr(22)).Replace("%11%", GenStr(24)).Replace("%12%", GenStr(26)) _
            .Replace("%13%", GenStr(28)).Replace("%14%", GenStr(30)).Replace("%15%", GenStr(32)).Replace("%16%", GenStr(34)) _
            .Replace("%17%", GenStr(36)).Replace("%18%", GenStr(38)).Replace("%19%", GenStr(40)).Replace("%20%", GenStr(42)) _
            .Replace("%21%", GenStr(44)).Replace("%22%", GenStr(46)).Replace("%23%", GenStr(48)).Replace("%24%", GenStr(50))
        TextBox1.Text = (R)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
