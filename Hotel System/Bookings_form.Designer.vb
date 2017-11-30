<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bookings_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_form = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Room_combo = New System.Windows.Forms.ComboBox()
        Me.Action_btn = New System.Windows.Forms.Button()
        Me.days_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Last_label = New System.Windows.Forms.Label()
        Me.Name_label = New System.Windows.Forms.Label()
        Me.Booking_id_combo = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Users_combo = New System.Windows.Forms.ComboBox()
        Me.Title_label = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel_form.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(2117, 1185)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.36688!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.63313!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 123)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(2107, 938)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Delete_btn, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Update_btn, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Add_btn, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(524, 928)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Delete_btn
        '
        Me.Delete_btn.BackColor = System.Drawing.Color.IndianRed
        Me.Delete_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Delete_btn.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Delete_btn.Location = New System.Drawing.Point(5, 623)
        Me.Delete_btn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(514, 300)
        Me.Delete_btn.TabIndex = 5
        Me.Delete_btn.Text = "Delete Booking"
        Me.Delete_btn.UseVisualStyleBackColor = False
        '
        'Update_btn
        '
        Me.Update_btn.BackColor = System.Drawing.Color.DarkOrange
        Me.Update_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Update_btn.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Update_btn.Location = New System.Drawing.Point(5, 314)
        Me.Update_btn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(514, 299)
        Me.Update_btn.TabIndex = 4
        Me.Update_btn.Text = "Update Booking"
        Me.Update_btn.UseVisualStyleBackColor = False
        '
        'Add_btn
        '
        Me.Add_btn.BackColor = System.Drawing.Color.LimeGreen
        Me.Add_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Add_btn.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Add_btn.Location = New System.Drawing.Point(5, 5)
        Me.Add_btn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(514, 299)
        Me.Add_btn.TabIndex = 3
        Me.Add_btn.Text = "New Booking"
        Me.Add_btn.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Title_label, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(539, 5)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1563, 928)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.11364!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.943182!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel_form, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(5, 97)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 777.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1553, 778)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Panel_form
        '
        Me.Panel_form.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_form.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel_form.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_form.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_form.Location = New System.Drawing.Point(160, 5)
        Me.Panel_form.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Panel_form.Name = "Panel_form"
        Me.Panel_form.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel_form.Size = New System.Drawing.Size(1233, 768)
        Me.Panel_form.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.Room_combo, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Action_btn, 0, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.days_txt, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Last_label, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Name_label, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Booking_id_combo, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.DateTimePicker1, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Users_combo, 0, 2)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 10)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.16883!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.42991!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.72897!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1233, 748)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'Room_combo
        '
        Me.Room_combo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Room_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Room_combo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room_combo.FormattingEnabled = True
        Me.Room_combo.Location = New System.Drawing.Point(624, 143)
        Me.Room_combo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Room_combo.Name = "Room_combo"
        Me.Room_combo.Size = New System.Drawing.Size(601, 57)
        Me.Room_combo.TabIndex = 40
        '
        'Action_btn
        '
        Me.Action_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Action_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Action_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Action_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Action_btn.Location = New System.Drawing.Point(5, 675)
        Me.Action_btn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Action_btn.Name = "Action_btn"
        Me.Action_btn.Size = New System.Drawing.Size(606, 68)
        Me.Action_btn.TabIndex = 45
        Me.Action_btn.Text = "REGISTER"
        Me.Action_btn.UseVisualStyleBackColor = False
        '
        'days_txt
        '
        Me.days_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.days_txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.days_txt.Location = New System.Drawing.Point(621, 336)
        Me.days_txt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.days_txt.Name = "days_txt"
        Me.days_txt.Size = New System.Drawing.Size(607, 56)
        Me.days_txt.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(621, 255)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 76)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Days booked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(5, 255)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 76)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Current Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(308, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 79)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SELECT BOOKING"
        Me.Label1.Visible = False
        '
        'Last_label
        '
        Me.Last_label.AutoSize = True
        Me.Last_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.Last_label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_label.ForeColor = System.Drawing.SystemColors.Control
        Me.Last_label.Location = New System.Drawing.Point(621, 79)
        Me.Last_label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Last_label.Name = "Last_label"
        Me.Last_label.Size = New System.Drawing.Size(117, 57)
        Me.Last_label.TabIndex = 11
        Me.Last_label.Text = "Room"
        '
        'Name_label
        '
        Me.Name_label.AutoSize = True
        Me.Name_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.Name_label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_label.ForeColor = System.Drawing.SystemColors.Control
        Me.Name_label.Location = New System.Drawing.Point(5, 79)
        Me.Name_label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Name_label.Name = "Name_label"
        Me.Name_label.Size = New System.Drawing.Size(180, 57)
        Me.Name_label.TabIndex = 0
        Me.Name_label.Text = "Customer"
        '
        'Booking_id_combo
        '
        Me.Booking_id_combo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Booking_id_combo.FormattingEnabled = True
        Me.Booking_id_combo.Location = New System.Drawing.Point(621, 5)
        Me.Booking_id_combo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Booking_id_combo.Name = "Booking_id_combo"
        Me.Booking_id_combo.Size = New System.Drawing.Size(607, 39)
        Me.Booking_id_combo.TabIndex = 25
        Me.Booking_id_combo.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(8, 338)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(600, 56)
        Me.DateTimePicker1.TabIndex = 41
        '
        'Users_combo
        '
        Me.Users_combo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Users_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Users_combo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Users_combo.FormattingEnabled = True
        Me.Users_combo.Location = New System.Drawing.Point(8, 143)
        Me.Users_combo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Users_combo.Name = "Users_combo"
        Me.Users_combo.Size = New System.Drawing.Size(600, 57)
        Me.Users_combo.TabIndex = 39
        '
        'Title_label
        '
        Me.Title_label.AutoSize = True
        Me.Title_label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title_label.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Title_label.Location = New System.Drawing.Point(5, 0)
        Me.Title_label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Title_label.Name = "Title_label"
        Me.Title_label.Size = New System.Drawing.Size(1553, 92)
        Me.Title_label.TabIndex = 1
        Me.Title_label.Text = "NEW BOOKING"
        Me.Title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(2107, 108)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(5, 1071)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(2107, 109)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.BOOKINGToolStripMenuItem, Me.RoomsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(2117, 55)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(172, 45)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'BOOKINGToolStripMenuItem
        '
        Me.BOOKINGToolStripMenuItem.Name = "BOOKINGToolStripMenuItem"
        Me.BOOKINGToolStripMenuItem.Size = New System.Drawing.Size(153, 45)
        Me.BOOKINGToolStripMenuItem.Text = "Bookings"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(122, 45)
        Me.RoomsToolStripMenuItem.Text = "Rooms"
        '
        'Bookings_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(2117, 1185)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Bookings_form"
        Me.Text = "Bookings_form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel_form.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Update_btn As Button
    Friend WithEvents Add_btn As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel_form As Panel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Action_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Last_label As Label
    Friend WithEvents Name_label As Label
    Friend WithEvents Booking_id_combo As ComboBox
    Friend WithEvents Title_label As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BOOKINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents days_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Room_combo As ComboBox
    Friend WithEvents Users_combo As ComboBox
End Class
