Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim StartTime As Date = Now

        For WrkIdx As Integer = 0 To 1

            Dim WrkFrm As Form2

            WrkFrm = New Form2
            WrkFrm.Show()
            WrkFrm.Dispose()

        Next

        Button1.Text = (Now - StartTime).ToString

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim StartTime As Date = Now

        For WrkIdx As Integer = 0 To 0

            Dim WrkFrm As Form3

            WrkFrm = New Form3
            WrkFrm.Show()
            'WrkFrm.Dispose()

        Next

        Button2.Text = (Now - StartTime).ToString

    End Sub
End Class
