Public Class Form3


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim WrkCtl(1120) As System.Windows.Forms.TextBox

        For PosX As Integer = 0 To 31

            For PosY As Integer = 0 To 34

                Dim WrkIdx As Integer
                WrkIdx = PosY + (PosX * 35)

                WrkCtl(WrkIdx) = New System.Windows.Forms.TextBox
                WrkCtl(WrkIdx).Location = New Point(9 + (38 * PosX), 9 + (19 * PosY))
                WrkCtl(WrkIdx).Size = New System.Drawing.Size(38, 19)

                'フォームに追加する
                Me.Controls.Add(WrkCtl(WrkIdx))

            Next


        Next


    End Sub

    Private Sub Form2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown


        'For Each WrkCtl As Control In Me.Controls
        '
        '    Dim WrkCnt As Integer
        '
        '    WrkCnt = WrkCnt + 1
        '
        '    WrkCtl.Text = WrkCnt
        'Next
        '

        'Me.Dispose()
    End Sub
End Class