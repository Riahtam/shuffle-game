Public Class Form1
    Public count As Integer

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        '14,11,16
        checkbutton(Button15, Button14)
        checkbutton(Button15, Button11)
        checkbutton(Button15, Button16)

        checksolve()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x = MsgBox("Do you want to exit? ", vbYesNo + vbQuestion)
        If (x = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '2,5
        checkbutton(Button1, Button2)
        checkbutton(Button1, Button5)

        checksolve()
    End Sub

    

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        '5.10,13
        checkbutton(Button9, Button5)
        checkbutton(Button9, Button10)
        checkbutton(Button9, Button13)

        checksolve()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '1,3,6
        checkbutton(Button2, Button1)
        checkbutton(Button2, Button3)
        checkbutton(Button2, Button6)

        checksolve()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '2,4,7
        checkbutton(Button3, Button2)
        checkbutton(Button3, Button4)
        checkbutton(Button3, Button7)

        checksolve()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '3,8
        checkbutton(Button4, Button3)
        checkbutton(Button4, Button8)

        checksolve()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        '4,7,12
        checkbutton(Button8, Button4)
        checkbutton(Button8, Button7)
        checkbutton(Button8, Button12)

        checksolve()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        '3,6,11,8
        checkbutton(Button7, Button3)
        checkbutton(Button7, Button6)
        checkbutton(Button7, Button11)
        checkbutton(Button7, Button8)

        checksolve()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        '2,5,7,10
        checkbutton(Button6, Button2)
        checkbutton(Button6, Button5)
        checkbutton(Button6, Button7)
        checkbutton(Button6, Button10)

        checksolve()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        '1,6,9
        checkbutton(Button5, Button1)
        checkbutton(Button5, Button6)
        checkbutton(Button5, Button9)

        checksolve()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        '6,9,11,14
        checkbutton(Button10, Button6)
        checkbutton(Button10, Button9)
        checkbutton(Button10, Button14)
        checkbutton(Button10, Button11)

        checksolve()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        '7,10,12,15
        checkbutton(Button11, Button7)
        checkbutton(Button11, Button10)
        checkbutton(Button11, Button12)
        checkbutton(Button11, Button15)

        checksolve()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        '8,11,16
        checkbutton(Button12, Button8)
        checkbutton(Button12, Button11)
        checkbutton(Button12, Button16)

        checksolve()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        '9,14
        checkbutton(Button13, Button9)
        checkbutton(Button13, Button14)

        checksolve()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        '13,10,15
        checkbutton(Button14, Button13)
        checkbutton(Button14, Button10)
        checkbutton(Button14, Button15)

        checksolve()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        '15,12
        checkbutton(Button16, Button12)
        checkbutton(Button16, Button15)


        checksolve()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        shuffle()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        shuffle()

    End Sub
End Class
