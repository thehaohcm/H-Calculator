Public Class Form1
    Dim phep As String
    Dim t As Boolean
    Private Sub xoa()
        If t = True Then
            bang.Text = ""
            t = False
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
       
    End Sub

    Private Sub Form1_Invalidated(sender As Object, e As InvalidateEventArgs) Handles Me.Invalidated
       
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.NumPad0 : But0.PerformClick()
            Case Keys.NumPad1 : But1.PerformClick()
            Case Keys.NumPad2 : But2.PerformClick()
            Case Keys.NumPad3 : But3.PerformClick()
            Case Keys.NumPad4 : But4.PerformClick()
            Case Keys.NumPad5 : But5.PerformClick()
            Case Keys.NumPad6 : But6.PerformClick()
            Case Keys.NumPad7 : But7.PerformClick()
            Case Keys.NumPad8 : But8.PerformClick()
            Case Keys.NumPad9 : But9.PerformClick()
            Case Keys.Divide : ButDiv.PerformClick()
            Case Keys.Subtract : ButSub.PerformClick()
            Case Keys.Multiply : ButMul.PerformClick()
            Case Keys.Add : ButAdd.PerformClick()
            Case Keys.Back : Butback.PerformClick()
            Case Keys.Enter : ButEqual.PerformClick()
            Case Keys.Back : Butback.PerformClick()
            Case Keys.Oemcomma : Butpoint.PerformClick()
            Case Keys.OemPeriod : Butpoint.PerformClick()
            Case Keys.Decimal : Butpoint.PerformClick()

        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bang.Text = "0"
        nho.Text = ""
        t = True
        Me.Height = 389
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles But1.Click
        xoa()
        bang.Text = bang.Text + "1"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles But2.Click
        xoa()
        bang.Text = bang.Text + "2"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles But3.Click
        xoa()
        bang.Text = bang.Text + "3"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles But4.Click
        xoa()
        bang.Text = bang.Text + "4"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles But5.Click
        xoa()
        bang.Text = bang.Text + "5"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles But6.Click
        xoa()
        bang.Text = bang.Text + "6"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles But7.Click
        xoa()
        bang.Text = bang.Text + "7"

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles But8.Click
        xoa()
        bang.Text = bang.Text + "8"

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles But9.Click
        xoa()
        bang.Text = bang.Text + "9"

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles But0.Click
        xoa()
        bang.Text = bang.Text + "0"

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Butpoint.Click
        If (bang.Text = "") Then
            bang.Text = "0,"
        Else
            bang.Text = bang.Text + ","
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Butback.Click
        'MessageBox.Show("Nút back này hiện chưa được lập trình ^_^ Mong bạn thông cảm")
        Dim str As String
        Dim loc As Integer
        'Make sure the text length is > 1
        If bang.Text.Length > 0 Then
            'Get the next to last character
            str = bang.Text.Chars(bang.Text.Length - 1)
            'Check if its a decimal
            'If str = "." Then
            '    'If it is toggle the hasDecimal flag
            '    hasDecimal = False
            'End If
            'Get the length of the string
            loc = bang.Text.Length
            'Remove the last character, incrementing by 1
            bang.Text = bang.Text.Remove(loc - 1, 1)
        
        End If
        If bang.Text.Length = 0 Then
            bang.Text = "0"
        End If
        t = True
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles ButAdd.Click
        nho.Text = bang.Text
        phep = "cong"
        t = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles ButSub.Click
        nho.Text = bang.Text
        phep = "tru"
        t = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles ButMul.Click
        nho.Text = bang.Text
        phep = "nhan"
        t = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButDiv.Click
        nho.Text = bang.Text
        phep = "chia"
        t = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nho.Text = ""
        bang.Text = "0"
        t = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bang.Text = "0"
        t = True
    End Sub

    Private Sub Butsqrt_Click(sender As Object, e As EventArgs) Handles Butsqrt.Click
        Try
            If bang.Text < 0 Then
                MessageBox.Show("Mời bạn nhập vào số nguyên dương", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                bang.Text = Math.Sqrt(bang.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra, mời bạn nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            bang.Text = bang.Text / 100
        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra, mời bạn nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True
    End Sub

    Private Sub ButGT_Click(sender As Object, e As EventArgs) Handles ButGT.Click
        Dim i As Integer
        Dim a As Integer
        a = 1
        Try
            If (Int(Val(bang.Text)) < 13) Then
                If (Int(Val(bang.Text)) = 0) Then
                    a = 1
                Else
                    For i = 1 To Int(Val(bang.Text))
                        a = a * i
                    Next
                End If
                bang.Text = a
            Else
                MessageBox.Show("Chương trình không thể tính được vì số giai thừa quá lớn")
            End If
        Catch ex As Exception
            MessageBox.Show("Đã xảy ra lỗi, hãy chắc chắn rằng số bạn nhập vào là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True
    End Sub

    Private Sub ButND_Click(sender As Object, e As EventArgs) Handles ButND.Click
        Try
            If bang.Text = 0 Then
                MessageBox.Show("Mời bạn nhập số khác 0", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                bang.Text = 1 / bang.Text
            End If
        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra, mời bạn nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles ButEqual.Click
        Try
            Dim pheptoan, bang_t, nho_t As Double
            bang_t = bang.Text
            If (nho.Text <> vbNull) Then
                nho_t = nho.Text
            End If

            Select Case phep
                Case "cong"
                    pheptoan = nho_t + bang_t
                Case "tru"
                    pheptoan = nho_t - bang_t
                Case "nhan"
                    pheptoan = nho_t * bang_t
                Case "chia"
                    pheptoan = nho_t / bang_t
                Case "mu"
                    pheptoan = Math.Pow(nho_t, bang_t)
                Case "mod"
                    pheptoan = nho_t Mod bang_t
            End Select
            bang.Text = pheptoan
            t = True
        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bang.Text = "Error!"
        End Try
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        phep = "mu"
        nho.Text = bang.Text
        t = True
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            bang.Text = Math.Log(bang.Text)
        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra, mời bạn nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        bang.Text = Math.Log10(bang.Text)
        Try

        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra, mời bạn nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            bang.Text = Math.Sin(bang.Text)
        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra, mời bạn nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            bang.Text = Math.Cos(bang.Text)
        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra, mời bạn nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            bang.Text = Math.Tan(bang.Text)
        Catch ex As Exception
            MessageBox.Show("Đã có lỗi xảy ra, mời bạn nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        t = True
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles ButChuyen.Click
        If ButChuyen.Text = "Mở rộng" Then
            Me.Height = 519
            ButChuyen.Text = "Rút gọn"
            ButChuyen.ForeColor = Color.Red
        ElseIf ButChuyen.Text = "Rút gọn" Then
            Me.Height = 389
            ButChuyen.Text = "Mở rộng"
            ButChuyen.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        phep = "mod"
        nho.Text = bang.Text
        t = True
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        AboutBox1.Show()
    End Sub
End Class
