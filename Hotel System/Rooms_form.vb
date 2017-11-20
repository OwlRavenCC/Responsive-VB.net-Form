Public Class Rooms
    Private Sub BOOKINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGToolStripMenuItem.Click

    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Me.Hide()
        Customers_form.Show()
    End Sub

    Private Sub Action_btn_Click(sender As Object, e As EventArgs) Handles Action_btn.Click
        If (Action_btn.Text = "REGISTER") Then
            Call CreateRoom(Room_Txt_add.Text, Cat_txt_add.Text)
        ElseIf (Action_btn.Text = "UPDATE") Then
            Call UpdateRoom(User_id_combo.SelectedValue.ToString, Room_Txt_add.Text, Cat_txt_add.Text)

        ElseIf (Action_btn.Text = "DELETE") Then
            Call DeleteRoom(User_id_combo.SelectedValue.ToString)
        End If
        Call Fill_combo_Room(User_id_combo)
        Call Clear_textbox(TableLayoutPanel6)
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Title_label.Text = "REGISTER NEW ROOM"
        Action_btn.Text = "REGISTER"

        Label1.Visible = False
        User_id_combo.Visible = False

        Call Clear_textbox(TableLayoutPanel6)
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Title_label.Text = "UPDATE FORM"
        Action_btn.Text = "UPDATE"

        Call Fill_combo_Room(User_id_combo)


        Label1.Visible = True
        User_id_combo.Visible = True

    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Title_label.Text = "DELETE FORM"
        Action_btn.Text = "DELETE"

        Call Fill_combo_Room(User_id_combo)

        Label1.Visible = True
        User_id_combo.Visible = True


    End Sub

    Private Sub User_id_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles User_id_combo.SelectedValueChanged
        If (IsNumeric(User_id_combo.SelectedValue.ToString)) Then
            Call Fill_textbox_Room(User_id_combo.SelectedValue.ToString, Room_Txt_add, Cat_txt_add)
        End If
    End Sub

    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()


    End Sub
End Class