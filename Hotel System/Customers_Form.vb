Public Class Customers_form
    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Title_label.Text = "REGISTRATION FORM"
        Action_btn.Text = "REGISTER"

        Label1.Visible = False
        User_id_combo.Visible = False

        Call Clear_textbox(TableLayoutPanel6)

    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Title_label.Text = "UPDATE FORM"
        Action_btn.Text = "UPDATE"

        Call Fill_combo(User_id_combo)


        Label1.Visible = True
        User_id_combo.Visible = True

    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Title_label.Text = "DELETE FORM"
        Action_btn.Text = "DELETE"

        Call Fill_combo(User_id_combo)

        Label1.Visible = True
        User_id_combo.Visible = True


    End Sub

    Private Sub Action_btn_Click(sender As Object, e As EventArgs) Handles Action_btn.Click
        Dim email As New RegexFunctionsFields



        If (Action_btn.Text = "REGISTER") Then
            If Check_textbox(TableLayoutPanel6) And email.IsValidEmail(eMail_txt_add.Text) Then
                Call AddCustomer(Name_Txt_add.Text, Last_txt_add.Text, Gender_combo_add.SelectedValue, dob_datepicker.Value, Address_txt.Text, City_txt_add.Text, State_txt_add.Text, Zip_txt_add.Text, Phone_txt_add.Text, eMail_txt_add.Text)
                Call Clear_textbox(TableLayoutPanel6)
            Else
                MsgBox("Please complete all fields required and correctly")
            End If
        ElseIf (Action_btn.Text = "UPDATE") Then
            Call UpdateCustomer(User_id_combo.SelectedValue.ToString, Name_Txt_add.Text, Last_txt_add.Text, Gender_combo_add.SelectedValue, dob_datepicker.Value, Address_txt.Text, City_txt_add.Text, State_txt_add.Text, Zip_txt_add.Text, Phone_txt_add.Text, eMail_txt_add.Text)
            Call Clear_textbox(TableLayoutPanel6)
            Call Fill_combo(User_id_combo)
        ElseIf (Action_btn.Text = "DELETE") Then
            Call DeleteCustomer(User_id_combo.SelectedValue.ToString)
            Call Clear_textbox(TableLayoutPanel6)
            Call Fill_combo(User_id_combo)
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comboSource As New Dictionary(Of String, String)()
        Call connection()

        comboSource.Add("0", "Male")
        comboSource.Add("1", "Female")
        comboSource.Add("2", "Prefered not to answer")

        Gender_combo_add.DataSource = New BindingSource(comboSource, Nothing)
        Gender_combo_add.DisplayMember = "Value"
        Gender_combo_add.ValueMember = "Key"



    End Sub

    Private Sub User_id_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles User_id_combo.SelectedValueChanged
        If (IsNumeric(User_id_combo.SelectedValue.ToString)) Then
            Call Fill_textbox(User_id_combo.SelectedValue.ToString, Name_Txt_add, Last_txt_add, Gender_combo_add, dob_datepicker, Address_txt, City_txt_add, State_txt_add, Zip_txt_add, Phone_txt_add, eMail_txt_add)
        End If
    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
    End Sub

    Private Sub BOOKINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGToolStripMenuItem.Click

    End Sub

    Private Sub RoomsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomsToolStripMenuItem.Click
        Me.Hide()
        Rooms.Show()
    End Sub

    Private Sub Phone_txt_add_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone_txt_add.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Phone_txt_add_TextChanged(sender As Object, e As EventArgs) Handles Phone_txt_add.TextChanged

    End Sub
End Class
