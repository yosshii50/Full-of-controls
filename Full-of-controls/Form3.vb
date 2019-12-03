Public Class Form3


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown


        For Each WrkCtl As Control In Me.Controls

            Dim WrkCnt As Integer

            WrkCnt = WrkCnt + 1

            WrkCtl.Text = WrkCnt
        Next


        'Me.Dispose()
    End Sub
End Class