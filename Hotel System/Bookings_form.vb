Public Class Bookings_form
    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Customers_form.Show()
        Me.Close()

    End Sub

    Private Sub RoomsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomsToolStripMenuItem.Click
        Rooms.Show()
        Me.Close()
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Title_label.Text = "REGISTER NEW ROOM"
        Action_btn.Text = "REGISTER"

        Label1.Visible = False
        Booking_id_combo.Visible = False

        Call Clear_textbox(TableLayoutPanel6)
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Title_label.Text = "UPDATE FORM"
        Action_btn.Text = "UPDATE"

        Call Fill_combo_Booking(Booking_id_combo)


        Label1.Visible = True
        Booking_id_combo.Visible = True
    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Title_label.Text = "DELETE FORM"
        Action_btn.Text = "DELETE"

        Call Fill_combo_Booking(Booking_id_combo)

        Label1.Visible = True
        Booking_id_combo.Visible = True
    End Sub

    Private Sub Bookings_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call Fill_combo(Users_combo)
        Call Fill_combo_Room(Room_combo)


    End Sub



    Private Sub Total_txt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub days_txt_TextChanged(sender As Object, e As EventArgs) Handles days_txt.TextChanged

    End Sub

    Private Sub days_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles days_txt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Action_btn_Click(sender As Object, e As EventArgs) Handles Action_btn.Click
        If (Action_btn.Text = "REGISTER") Then
            Call CreateBooking(Users_combo.SelectedValue, Room_combo.SelectedValue, DateTimePicker1.Value, days_txt.Text)
        ElseIf (Action_btn.Text = "UPDATE") Then
            Call UpdateBooking(Booking_id_combo.SelectedValue, Users_combo.Text, Room_combo.Text, DateTimePicker1.Value, days_txt.Text)

        ElseIf (Action_btn.Text = "DELETE") Then
            Call DeleteRoom(Booking_id_combo.SelectedValue.ToString)
        End If
        Call Fill_combo_Booking(Booking_id_combo)
        Call Clear_textbox(TableLayoutPanel6)
    End Sub



    Private Sub Booking_id_combo_SelectedValueChanged(sender As Object, e As EventArgs) Handles Booking_id_combo.SelectedValueChanged
        If (IsNumeric(Booking_id_combo.SelectedValue.ToString)) Then
            Call Fill_textbox_Booking(Booking_id_combo.SelectedValue.ToString, Users_combo, Room_combo, DateTimePicker1, days_txt)
        End If
    End Sub
End Class