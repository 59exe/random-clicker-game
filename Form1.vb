Public Class Form1

    Dim TwoClicks As Boolean = False
    Dim ThreeClicks As Boolean = False
    Dim QuadClicks As Boolean = False
    Dim QuintClicks As Boolean = False
    Dim SixClicks As Boolean = False
    Dim SevenClicks

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Environment.Exit(420)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TwoClicks = True) Then
            Button2.Text = Button2.Text + 2
        ElseIf ThreeClicks = True Then
            Button2.Text = Button2.Text + 3
        ElseIf QuadClicks = True Then
            Button2.Text = Button2.Text + 4
        ElseIf QuintClicks = True Then
            Button2.Text = Button2.Text + 5
        ElseIf SixClicks = True Then
            Button2.Text = Button2.Text + 6
        Else
            Button2.Text = Button2.Text + 1
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Button2.Text >= 100) Then
            If (TwoClicks = False) Then
                Button2.Text = Button2.Text - 100
                TwoClicks = True
                Button3.Text = "Buy Double Click (Bought)"
            Else
                MsgBox("You have already unlocked this power-up!")
            End If
        Else
            If TwoClicks = True Then
                MsgBox("You have already unlocked this power-up!")
            ElseIf Button2.Text < 100 Then
                MsgBox("You cannot afford this!")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Button2.Text >= 500) Then
            If (ThreeClicks = False) Then
                Button2.Text = Button2.Text - 500
                ThreeClicks = True
                Button4.Text = "Buy Triple Click (Bought)"
                TwoClicks = False
            Else
                MsgBox("You have already unlocked this power-up!")
            End If
        Else
            If ThreeClicks = True Then
                MsgBox("You have already unlocked this power-up!")
            ElseIf Button2.Text < 500 Then
                MsgBox("You cannot afford this!")
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Button2.Text >= 1100) Then
            If (QuadClicks = False) Then
                Button2.Text = Button2.Text - 1100
                QuadClicks = True
                Button5.Text = "Buy Quad Click (Bought)"
                ThreeClicks = False
            Else
                MsgBox("You have already unlocked this power-up!")
            End If
        Else
            If QuadClicks = True Then
                MsgBox("You have already unlocked this power-up!")
            ElseIf Button2.Text < 1100 Then
                MsgBox("You cannot afford this!")
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button2.Text >= 3000 Then
            If QuintClicks = False Then
                Button2.Text = Button2.Text - 3000
                QuintClicks = True
                Button6.Text = "Buy Five Clicks (Bought)"
                QuadClicks = False
            Else
                MsgBox("You have already unlocked this power-up!")
            End If
        Else
            If QuintClicks = True Then
                MsgBox("You have already unlocked this power-up!")
            ElseIf Button2.Text < 3000 Then
                MsgBox("You cannot afford this!")
            End If
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        MsgBox("Error: Program will now be terminated.")
        Throw New NotImplementedException()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button2.Text >= 8000 Then
            If SixClicks = False Then
                Button2.Text = Button2.Text - 8000
                SixClicks = True
                Button7.Text = "Buy Six Clicks (Bought)"
                QuintClicks = False
            Else
                MsgBox("You already unlocked this power-up!")
            End If
        Else
            If SixClicks = True Then
                MsgBox("You have already unlocked this power-up!")
            ElseIf Button2.Text < 8000 Then
                MsgBox("You cannot afford this!")
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button2.Text >= 11000 Then
            If SevenClicks = False Then
                Button2.Text = Button2.Text - 11000
                SevenClicks = True
                Button8.Text = "Buy Seven Clicks (Bought)"
                SixClicks = False
            Else
                MsgBox("You already unlocked this power-up!")
            End If
        Else
            If SevenClicks = True Then
                MsgBox("You have already unlocked this power-up!")
            ElseIf Button2.Text < 11000 Then
                MsgBox("ur broke my g")
            End If
        End If
    End Sub
End Class
