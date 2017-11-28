Imports System.Data.OleDb
Module Hotel_module

    Public cn As New OleDb.OleDbConnection
    Public cm As New OleDb.OleDbCommand
    Public dr As OleDbDataReader
    'Creates access database connection
    Public Sub Connection()
        cn = New OleDb.OleDbConnection
        With cn
            .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\database\hotel_db.accdb"
            .Open()
        End With
    End Sub
    'Add a new customer
    Public Sub AddCustomer(fname As String, lname As String, gender As String, dob As String, address As String, city As String, state As String, zip As String, phone As String, eMail As String)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO customers (fname,lname,gender,dob,address,city,state,zip,phone,eMail) VALUES (@fname,@lname,@gender,@dob,@address,@city,@state,@zip,@phone,@email)"


                'Validate and assign value to parameters
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@fname", System.Data.OleDb.OleDbType.VarChar, 255, fname))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@lname", System.Data.OleDb.OleDbType.VarChar, 255, lname))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@gender", System.Data.OleDb.OleDbType.VarChar, 255, gender))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@dob", System.Data.OleDb.OleDbType.VarChar, 255, dob))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@address", System.Data.OleDb.OleDbType.VarChar, 255, address))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@city", System.Data.OleDb.OleDbType.VarChar, 255, city))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@state", System.Data.OleDb.OleDbType.VarChar, 255, state))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@zip", System.Data.OleDb.OleDbType.VarChar, 255, zip))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@phone", System.Data.OleDb.OleDbType.VarChar, 255, phone))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@email", System.Data.OleDb.OleDbType.VarChar, 255, eMail))

                'Run query parameters
                cm.Parameters("@fname").Value = fname
                cm.Parameters("@lname").Value = lname
                cm.Parameters("@gender").Value = gender
                cm.Parameters("@dob").Value = dob
                cm.Parameters("@address").Value = address
                cm.Parameters("@city").Value = city
                cm.Parameters("@state").Value = state
                cm.Parameters("@zip").Value = zip
                cm.Parameters("@phone").Value = phone
                cm.Parameters("@email").Value = eMail



                cm.ExecuteNonQuery()
                MsgBox("Customer Registered Sucessfully.", MsgBoxStyle.Information)
                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Updates existing customer
    Public Sub UpdateCustomer(id_user As String, fname As String, lname As String, gender As String, dob As String, address As String, city As String, state As String, zip As String, phone As String, eMail As String)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "UPDATE customers SET fname = @fname ,lname = @lname, gender = @gender ,dob = @dob, address = @address, city = @city, state = @state, zip = @zip, phone = @phone, eMail = @email WHERE id_user =" & id_user


                'Validate and assign value to parameters
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@fname", System.Data.OleDb.OleDbType.VarChar, 255, fname))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@lname", System.Data.OleDb.OleDbType.VarChar, 255, lname))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@gender", System.Data.OleDb.OleDbType.VarChar, 255, gender))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@dob", System.Data.OleDb.OleDbType.VarChar, 255, dob))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@address", System.Data.OleDb.OleDbType.VarChar, 255, address))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@city", System.Data.OleDb.OleDbType.VarChar, 255, city))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@state", System.Data.OleDb.OleDbType.VarChar, 255, state))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@zip", System.Data.OleDb.OleDbType.VarChar, 255, zip))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@phone", System.Data.OleDb.OleDbType.VarChar, 255, phone))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@email", System.Data.OleDb.OleDbType.VarChar, 255, eMail))

                'Run query parameters
                cm.Parameters("@fname").Value = fname
                cm.Parameters("@lname").Value = lname
                cm.Parameters("@gender").Value = gender
                cm.Parameters("@dob").Value = dob
                cm.Parameters("@address").Value = address
                cm.Parameters("@city").Value = city
                cm.Parameters("@state").Value = state
                cm.Parameters("@zip").Value = zip
                cm.Parameters("@phone").Value = phone
                cm.Parameters("@email").Value = eMail



                cm.ExecuteNonQuery()
                MsgBox("Customer Information was updated Sucessfully.", MsgBoxStyle.Information)
                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Deletes users based on id on combobox
    Public Sub DeleteCustomer(id_user As String)
        Dim x As Integer
        x = MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo, "WARNING")

        If (x = vbYes) Then
            Try
                cm = New OleDb.OleDbCommand
                With cm
                    .Connection = cn
                    .CommandType = CommandType.Text
                    .CommandText = "DELETE FROM customers WHERE id_user = " & id_user
                    dr = .ExecuteReader
                End With

                MsgBox("Customer Deleted Succesfully", MsgBoxStyle.Information)

                Exit Sub
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub


    Public Sub Fill_combo(Combo_fill As ComboBox)
        'Create variable to store combobox data array
        Dim comboSource As New Dictionary(Of String, String)()
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM customers"
                dr = .ExecuteReader
            End With
            While dr.Read()
                comboSource.Add(dr("id_user").ToString, dr("fname").ToString & " " & dr("lname").ToString)

            End While

            'Define combobox value and text displayed
            Combo_fill.DataSource = New BindingSource(comboSource, Nothing)
            Combo_fill.DisplayMember = "Value"
            Combo_fill.ValueMember = "Key"



            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Fills txts with user data
    Public Sub Fill_textbox(id_user As String, fname As TextBox, lname As TextBox, gender As ComboBox, dob As DateTimePicker, address As TextBox, city As TextBox, state As TextBox, zip As TextBox, phone As TextBox, email As TextBox)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM customers WHERE id_user = " & id_user
                dr = .ExecuteReader
            End With
            While dr.Read()
                fname.Text = dr("fname").ToString
                lname.Text = dr("lname").ToString
                gender.SelectedIndex = dr("gender").ToString
                dob.Value = dr("dob").ToString
                address.Text = dr("address").ToString
                city.Text = dr("city").ToString
                state.Text = dr("state").ToString
                zip.Text = dr("zip").ToString
                phone.Text = dr("phone").ToString
                email.Text = dr("eMail").ToString

            End While

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    'ROOMS SUBS
    'Creates new room
    Public Sub CreateRoom(number As String, category As String, occupants As Integer, price As Double)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO rooms (num,cat,occupants,price) VALUES (@number,@category,@occupants,@price)"

                'Validate and assign value to parameters
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@number", System.Data.OleDb.OleDbType.VarChar, 255, number))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@category", System.Data.OleDb.OleDbType.VarChar, 255, category))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@occupants", System.Data.OleDb.OleDbType.VarChar, 255, occupants))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@price", System.Data.OleDb.OleDbType.Currency, 255, price))

                'Run query parameters
                cm.Parameters("@number").Value = number
                cm.Parameters("@category").Value = category
                cm.Parameters("@occupants").Value = occupants
                cm.Parameters("@price").Value = price

                cm.ExecuteNonQuery()
                MsgBox("Room was created sucessfully.", MsgBoxStyle.Information)
                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Public Sub Fill_combo_Room(Combo_fill As ComboBox)
        'Create variable to store combobox data array
        Dim comboSource As New Dictionary(Of String, String)()
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM rooms"
                dr = .ExecuteReader
            End With
            While dr.Read()
                comboSource.Add(dr("id_room").ToString, dr("num").ToString & " " & dr("cat").ToString)

            End While

            'Define combobox value and text displayed
            Combo_fill.DataSource = New BindingSource(comboSource, Nothing)
            Combo_fill.DisplayMember = "Value"
            Combo_fill.ValueMember = "Key"



            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub Fill_textbox_Room(id_room As String, number As TextBox, category As TextBox, occupants As TextBox, price As TextBox)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM rooms WHERE id_room = " & id_room
                dr = .ExecuteReader
            End With
            While dr.Read()
                number.Text = dr("num").ToString
                category.Text = dr("cat").ToString
                occupants.Text = dr("occupants").ToString
                price.Text = dr("price").ToString


            End While

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    'Updates existing room
    Public Sub UpdateRoom(id_room As String, num As String, cat As String, occupants As String, price As String)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "UPDATE rooms SET num = @num ,cat = @cat, occupants = @occupants, price = @price WHERE id_room =" & id_room


                'Validate and assign value to parameters
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@num", System.Data.OleDb.OleDbType.VarChar, 255, num))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@cat", System.Data.OleDb.OleDbType.VarChar, 255, cat))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@occupants", System.Data.OleDb.OleDbType.VarChar, 255, occupants))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@price", System.Data.OleDb.OleDbType.VarChar, 255, price))


                'Run query parameters
                cm.Parameters("@num").Value = num
                cm.Parameters("@cat").Value = cat
                cm.Parameters("@occupants").Value = occupants
                cm.Parameters("@price").Value = price


                cm.ExecuteNonQuery()
                MsgBox("Room Information was updated sucessfully.", MsgBoxStyle.Information)
                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Deletes room based on id on combobox
    Public Sub DeleteRoom(id_room As String)
        Dim x As Integer
        x = MsgBox("Are you sure you want to delete this room?", MsgBoxStyle.YesNo, "WARNING")

        If (x = vbYes) Then
            Try
                cm = New OleDb.OleDbCommand
                With cm
                    .Connection = cn
                    .CommandType = CommandType.Text
                    .CommandText = "DELETE FROM rooms WHERE id_room = " & id_room
                    dr = .ExecuteReader
                End With

                MsgBox("Room was deleted succesfully", MsgBoxStyle.Information)

                Exit Sub
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub
    'BOOKING SUBS
    'Creates new Booking
    Public Sub CreateBooking(id_user As String, id_room As String, date_booked As String, days As String)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO [bookings] ([id_user],[id_room],[date],[days]) VALUES (@id_user,@id_room,@date, @days)"

                'Validate and assign value to parameters
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@id_user", System.Data.OleDb.OleDbType.VarChar, 255, id_user))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@id_room", System.Data.OleDb.OleDbType.VarChar, 255, id_room))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@date", System.Data.OleDb.OleDbType.VarChar, 255, date_booked))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@days", System.Data.OleDb.OleDbType.VarChar, 255, days))

                'Run query parameters
                cm.Parameters("@id_user").Value = Val(id_user)
                cm.Parameters("@id_room").Value = Val(id_room)
                cm.Parameters("@date").Value = date_booked
                cm.Parameters("@days").Value = days

                cm.ExecuteNonQuery()
                MsgBox("Booking was created sucessfully.", MsgBoxStyle.Information)
                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub Fill_combo_Booking(Combo_fill As ComboBox)
        'Create variable to store combobox data array
        Dim comboSource As New Dictionary(Of String, String)()
        Dim container As String
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM bookings"
                dr = .ExecuteReader
            End With
            While dr.Read()

                container = dr("id_booking").ToString
                comboSource.Add(Val(container), dr("id_booking").ToString & "-" & dr("date").ToString)

            End While

            'Define combobox value and text displayed
            Combo_fill.DataSource = New BindingSource(comboSource, Nothing)
            Combo_fill.DisplayMember = "Value"
            Combo_fill.ValueMember = "Key"



            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub Fill_textbox_Booking(id_booking As String, id_user As ComboBox, id_room As ComboBox, date_booked As DateTimePicker, days As TextBox)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM [bookings] WHERE [id_booking] = " & id_booking
                dr = .ExecuteReader
            End With
            While dr.Read()

                id_user.SelectedValue = id_user.FindStringExact(dr("id_user").ToString)
                id_room.SelectedValue = id_room.FindStringExact(dr("id_room").ToString)

                date_booked.Value = dr("date").ToString
                days.Text = dr("days").ToString


            End While

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    'Updates existing Booking
    Public Sub UpdateBooking(id_booking As String, id_user As String, id_room As String, date_booked As String, days As String)
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "UPDATE [bookings] SET [id_user] = @id_user ,[id_room] = @id_room, [date] = @date, [days] = @days WHERE id_booking =" & id_booking


                'Validate and assign value to parameters
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@id_user", System.Data.OleDb.OleDbType.VarChar, 255, id_user))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@id_booking", System.Data.OleDb.OleDbType.VarChar, 255, id_room))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@date", System.Data.OleDb.OleDbType.VarChar, 255, date_booked))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@days", System.Data.OleDb.OleDbType.VarChar, 255, days))


                'Run query parameters
                cm.Parameters("@id_user").Value = id_user
                cm.Parameters("@id_booking").Value = id_booking
                cm.Parameters("@date").Value = date_booked
                cm.Parameters("@days").Value = days


                cm.ExecuteNonQuery()
                MsgBox("Booking Information was updated sucessfully.", MsgBoxStyle.Information)
                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    'Deletes room based on id on combobox
    Public Sub DeleteBooking(id_booking As String)
        Dim x As Integer
        x = MsgBox("Are you sure you want to delete this Booking?", MsgBoxStyle.YesNo, "WARNING")

        If (x = vbYes) Then
            Try
                cm = New OleDb.OleDbCommand
                With cm
                    .Connection = cn
                    .CommandType = CommandType.Text
                    .CommandText = "DELETE FROM bookings WHERE id_booking = " & id_booking
                    dr = .ExecuteReader
                End With

                MsgBox("Booking was deleted succesfully", MsgBoxStyle.Information)

                Exit Sub
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub


    'ALL SUBS
    'Clears all textboxes inside a panel
    Public Sub Clear_textbox(form_panel As TableLayoutPanel)
        For Each tb As TextBox In form_panel.Controls.OfType(Of TextBox)()
            tb.Text = String.Empty
            tb.Text = ""
            tb.Clear()
        Next

    End Sub

    Public Function Check_textbox(form_panel As TableLayoutPanel) As Boolean


        Dim Checker As Boolean

        Checker = True

        For Each tb As TextBox In form_panel.Controls.OfType(Of TextBox)()
            Trim(tb.Text)
            If tb.Text = "" Then
                Checker = False
            End If
        Next

        Return Checker



    End Function
End Module
