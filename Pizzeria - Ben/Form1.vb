Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Const small As Double = 10
        Const medium As Double = 13
        Const large As Double = 15
        Const onetop As Double = 2
        Const twotop As Double = 2.5
        Const threetop As Double = 3
        Const fourtop As Double = 3.5

        Dim numtop As Integer = 0
        Dim toppri As Double = 0

        ordernum += 1

        If pepe.Checked = True Then
            numtop += 1
            eroni.Visible = True
        End If
        If bac.Checked = True Then
            numtop += 1
            bacc.Visible = True
        End If
        If ana.Checked = True Then
            numtop += 1
            annn.Visible = True
        End If
        If ppp.Checked = True Then
            numtop += 1
            prpr.Visible = True
        End If

        Select Case numtop
            Case 1
                toppri = onetop
            Case 2
                toppri = twotop
            Case 3
                toppri = threetop
            Case 4
                toppri = fourtop

        End Select



        If smal.Checked Then
            pizpr = small + toppri
            si = "Small"
        ElseIf med.Checked Then
            pizpr = medium + toppri
            si = "Medium"
        ElseIf larg.Checked Then
            pizpr = large + toppri
            si = "Large"
        End If


        price.Text = pizpr


    End Sub



    Private Sub newo_Click(ByVal sender As Object,
ByVal e As System.EventArgs) Handles newo.Click
        Me.smal.Checked = False
        Me.med.Checked = True
        Me.larg.Checked = False
        Me.pepe.Checked = False
        Me.ana.Checked = False
        Me.bac.Checked = False
        Me.ppp.Checked = False
        price.Text = "                   "

    End Sub

    Private Sub cart_Click(sender As Object, e As EventArgs) Handles cart.Click
        Form2.Show()

    End Sub

    Private Sub pepe_CheckedChanged(sender As Object, e As EventArgs) Handles pepe.CheckedChanged
        If Me.pepe.Checked = True Then
            eroni.Visible = True
        Else
            eroni.Visible = False
        End If

    End Sub

    Private Sub bac_CheckedChanged(sender As Object, e As EventArgs) Handles bac.CheckedChanged
        If Me.bac.Checked = True Then
            bacc.Visible = True
        Else
            bacc.Visible = False
        End If
    End Sub

    Private Sub ana_CheckedChanged(sender As Object, e As EventArgs) Handles ana.CheckedChanged
        If Me.ana.Checked = True Then
            annn.Visible = True
        Else
            annn.Visible = False
        End If
    End Sub

    Private Sub ppp_CheckedChanged(sender As Object, e As EventArgs) Handles ppp.CheckedChanged
        If Me.ppp.Checked = True Then
            prpr.Visible = True
        Else
            prpr.Visible = False
        End If
    End Sub
End Class
