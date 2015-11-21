Public Class Form1

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lixi!
        Dim date1, date2 As Integer
        Dim lixi2 As String
        date1 = DateTimePicker1.Value.ToOADate()
        date2 = DateTimePicker2.Value.ToOADate()
        lixi = Val(TextBox2.Text) * (date2 - date1)
        lixi2 = Str(lixi)
        RichTextBox1.Text = RichTextBox1.Text + lixi2 + vbCrLf

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim saveFile1 As New SaveFileDialog()

        ' Initialize the SaveFileDialog to specify the RTF extension for the file.
        saveFile1.DefaultExt = "*.txt"
        saveFile1.Filter = "TXT Files|*.TXT"

        ' Determine if the user selected a file name from the saveFileDialog.
        If (saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (saveFile1.FileName.Length) > 0 Then

            ' Save the contents of the RichTextBox into the file.
            RichTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub
End Class
