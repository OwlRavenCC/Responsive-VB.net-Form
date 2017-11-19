Public Class Form1
    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Title_label.Text = "REGISTRATION FORM"
        Action_btn.Text = "REGISTER"

    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Title_label.Text = "UPDATE FORM"
        Action_btn.Text = "UPDATE"
    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Title_label.Text = "DELETE FORM"
        Action_btn.Text = "DELETE"
    End Sub

    Private Sub Action_btn_Click(sender As Object, e As EventArgs) Handles Action_btn.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connection()

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
