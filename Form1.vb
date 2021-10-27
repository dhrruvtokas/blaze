Public Class Form1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Navigate(TextBox1.Text)
        QuverLabel1.Hide()
        QuverLabel2.Hide()
        Panel2.Hide()
        GooglePlus.Hide()
        YouTube.Hide()
        Twitter.Hide()
        Facebook.Hide()
        QuverWeb.Hide()
        GooglePlusMini.Hide()
        YouTubeMini.Hide()
        TwitterMini.Hide()
        FacebookMini.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        QuverLabel1.Hide()
        GooglePlus.Hide()
        YouTube.Hide()
        Twitter.Hide()
        Facebook.Hide()
        QuverWeb.Hide()
        QuverLabel2.Show()
        Panel2.Show()
        GooglePlusMini.Show()
        YouTubeMini.Show()
        TwitterMini.Show()
        FacebookMini.Show()
        WebBrowser1.GoHome()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
        QuverLabel2.Hide()
        Panel2.Hide()
        GooglePlusMini.Hide()
        YouTubeMini.Hide()
        TwitterMini.Hide()
        FacebookMini.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
        QuverLabel2.Hide()
        Panel2.Hide()
        GooglePlusMini.Hide()
        YouTubeMini.Hide()
        TwitterMini.Hide()
        FacebookMini.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QuverLabel2.Hide()
        Panel2.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Print()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Panel1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub QuverLabel2_Click(sender As Object, e As EventArgs) Handles QuverLabel2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles GooglePlus.Click
        WebBrowser1.Navigate("https://plus.google.com/100106782027663570840/posts")
        GooglePlus.Hide()
        YouTube.Hide()
        Twitter.Hide()
        Facebook.Hide()
        QuverWeb.Hide()
    End Sub

    Private Sub YouTube_Click(sender As Object, e As EventArgs) Handles YouTube.Click
        WebBrowser1.Navigate("https://www.youtube.com/channel/UC_C0nuvJ-TFWCq4X0zG4Cuw/featured")
        GooglePlus.Hide()
        YouTube.Hide()
        Twitter.Hide()
        Facebook.Hide()
        QuverWeb.Hide()
    End Sub

    Private Sub Twitter_Click(sender As Object, e As EventArgs) Handles Twitter.Click
        WebBrowser1.Navigate("https://twitter.com/QuverForums")
        GooglePlus.Hide()
        YouTube.Hide()
        Twitter.Hide()
        Facebook.Hide()
        QuverWeb.Hide()
    End Sub

    Private Sub Facebook_Click(sender As Object, e As EventArgs) Handles Facebook.Click
        WebBrowser1.Navigate("https://www.facebook.com/Quver-1044704895573929/?ref=hl")
        GooglePlus.Hide()
        YouTube.Hide()
        Twitter.Hide()
        Facebook.Hide()
        QuverWeb.Hide()
    End Sub

    Private Sub QuverWeb_Click(sender As Object, e As EventArgs) Handles QuverWeb.Click
        WebBrowser1.Navigate("https://www.quver.webs.com")
        GooglePlus.Hide()
        YouTube.Hide()
        Twitter.Hide()
        Facebook.Hide()
        QuverWeb.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles GooglePlusMini.Click
        WebBrowser1.Navigate("https://plus.google.com/100106782027663570840/posts")
        GooglePlusMini.Hide()
        YouTubeMini.Hide()
        TwitterMini.Hide()
        FacebookMini.Hide()
    End Sub

    Private Sub YouTubeMini_Click(sender As Object, e As EventArgs) Handles YouTubeMini.Click
        WebBrowser1.Navigate("https://www.youtube.com/channel/UC_C0nuvJ-TFWCq4X0zG4Cuw/featured")
        GooglePlusMini.Hide()
        YouTubeMini.Hide()
        TwitterMini.Hide()
        FacebookMini.Hide()
    End Sub

    Private Sub TwitterMini_Click(sender As Object, e As EventArgs) Handles TwitterMini.Click
        WebBrowser1.Navigate("https://twitter.com/QuverForums")
        GooglePlusMini.Hide()
        YouTubeMini.Hide()
        TwitterMini.Hide()
        FacebookMini.Hide()
    End Sub

    Private Sub FacebookMini_Click(sender As Object, e As EventArgs) Handles FacebookMini.Click
        WebBrowser1.Navigate("https://www.facebook.com/Quver-1044704895573929/?ref=hl")
        GooglePlusMini.Hide()
        YouTubeMini.Hide()
        TwitterMini.Hide()
        FacebookMini.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) 
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) 
        TextBox1.SelectAll()
        TextBox1.Copy()
        TextBox2.Paste()
        TextBox2.SelectAll()
        TextBox2.b
    End Sub
End Class
