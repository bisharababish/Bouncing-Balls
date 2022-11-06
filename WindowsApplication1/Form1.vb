Public Class Form1
    Dim MoveRight As Boolean
    Dim MoveUp As Boolean

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MoveRight = True Then
            PictureBox1.Left += 5
        Else
            PictureBox1.Left -= 5
        End If

        If MoveUp = True Then
            PictureBox1.Top -= 5
        Else
            PictureBox1.Top += 5
        End If
        If PictureBox1.Left <= Me.ClientRectangle.Left Then
            MoveRight = True
        End If
        If PictureBox1.Left + PictureBox1.Width >= Me.ClientRectangle.Right Then
            MoveRight = False
        End If
        If PictureBox1.Top <= Me.ClientRectangle.Top Then
            MoveUp = False
        End If
        If PictureBox1.Top + PictureBox1.Height >= Me.ClientRectangle.Bottom Then
            MoveUp = True
        End If

    End Sub
End Class