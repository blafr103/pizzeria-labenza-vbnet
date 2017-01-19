Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pizpr = pizpr * 1.13
        Me.ord.Text = ordernum
        totaltax.Text = pizpr
        finla.Text = si & " pizza"

    End Sub

    Private Sub finale_Click(sender As Object, e As EventArgs) Handles finale.Click
        finla.Text = ""
        totaltax.Text = ""
        Me.Hide()
        Form3.Show()
    End Sub


End Class