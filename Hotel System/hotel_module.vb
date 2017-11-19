Imports System.Data.OleDb
Module hotel_module

    Public cn As New OleDb.OleDbConnection
    Public cm As New OleDb.OleDbCommand
    Public dr As OleDbDataReader

    Public Sub connection()
        cn = New OleDb.OleDbConnection
        With cn
            .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\database\hotel_db.accdb"
            .Open()
        End With
    End Sub

    Public Sub AddCustomer()
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblStudent (Snum,Sname,Scourse,Ssection) VALUES (@Snum,@Sname,@Scourse,@Ssection)"

                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@Snum", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtSearch.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@Sname", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtName.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@Scourse", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtCourse.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@Ssection", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtSection.Text))


                ' RUN THE COMMAND
                cm.Parameters("@Snum").Value = Me.txtSearch.Text
                cm.Parameters("@Sname").Value = Me.txtName.Text
                cm.Parameters("@Scourse").Value = Me.txtCourse.Text
                cm.Parameters("@Ssection").Value = Me.txtSection.Text


                cm.ExecuteNonQuery()
                MsgBox("Record saved.", MsgBoxStyle.Information)
                Me.txtCourse.Text = ""
                Me.txtName.Text = ""
                Me.txtSearch.Text = ""
                Me.txtSection.Text = ""
                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Module
