<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customers_form
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Last_label = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Name_label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Name_Txt_add = New System.Windows.Forms.TextBox()
        Me.Last_txt_add = New System.Windows.Forms.TextBox()
        Me.Gender_combo_add = New System.Windows.Forms.ComboBox()
        Me.Address_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.City_txt_add = New System.Windows.Forms.TextBox()
        Me.State_txt_add = New System.Windows.Forms.TextBox()
        Me.Zip_txt_add = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Phone_txt_add = New System.Windows.Forms.TextBox()
        Me.eMail_txt_add = New System.Windows.Forms.TextBox()
        Me.dob_datepicker = New System.Windows.Forms.DateTimePicker()
        Me.Action_btn = New System.Windows.Forms.Button()
        Me.User_id_combo = New System.Windows.Forms.ComboBox()
        Me.Title_label = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel_form.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.BOOKINGToolStripMenuItem, Me.RoomsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(2629, 55)
        Me.MenuStrip1.TabIndex = 0
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 55)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(2629, 1366)
        Me.TableLayoutPanel1.TabIndex = 1
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 141)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(2619, 1082)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(654, 1072)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Delete_btn
        '
        Me.Delete_btn.BackColor = System.Drawing.Color.IndianRed
        Me.Delete_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Delete_btn.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Delete_btn.Location = New System.Drawing.Point(5, 719)
        Me.Delete_btn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(644, 348)
        Me.Delete_btn.TabIndex = 5
        Me.Delete_btn.Text = "Delete Customer"
        Me.Delete_btn.UseVisualStyleBackColor = False
        '
        'Update_btn
        '
        Me.Update_btn.BackColor = System.Drawing.Color.DarkOrange
        Me.Update_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Update_btn.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Update_btn.Location = New System.Drawing.Point(5, 362)
        Me.Update_btn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(644, 347)
        Me.Update_btn.TabIndex = 4
        Me.Update_btn.Text = "Update Info"
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
        Me.Add_btn.Size = New System.Drawing.Size(644, 347)
        Me.Add_btn.TabIndex = 3
        Me.Add_btn.Text = "New Customer"
        Me.Add_btn.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Title_label, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(669, 5)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1945, 1072)
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(5, 112)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 899.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1935, 901)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Panel_form
        '
        Me.Panel_form.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_form.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel_form.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_form.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_form.Location = New System.Drawing.Point(198, 5)
        Me.Panel_form.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Panel_form.Name = "Panel_form"
        Me.Panel_form.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel_form.Size = New System.Drawing.Size(1539, 891)
        Me.Panel_form.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Last_label, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Name_label, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 2, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Name_Txt_add, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Last_txt_add, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Gender_combo_add, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Address_txt, 0, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.Label8, 1, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.Label9, 2, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.City_txt_add, 0, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.State_txt_add, 1, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.Zip_txt_add, 2, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.Label10, 0, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.Label11, 2, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.Phone_txt_add, 0, 10)
        Me.TableLayoutPanel6.Controls.Add(Me.eMail_txt_add, 2, 10)
        Me.TableLayoutPanel6.Controls.Add(Me.dob_datepicker, 2, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Action_btn, 1, 11)
        Me.TableLayoutPanel6.Controls.Add(Me.User_id_combo, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 10)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 12
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.326425!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.440414!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10363!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.512953!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.9171!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.031088!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43523!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.031088!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.88083!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.217617!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10363!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1539, 871)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(255, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 73)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SELECT USER: "
        Me.Label1.Visible = False
        '
        'Last_label
        '
        Me.Last_label.AutoSize = True
        Me.Last_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.Last_label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_label.ForeColor = System.Drawing.SystemColors.Control
        Me.Last_label.Location = New System.Drawing.Point(1031, 73)
        Me.Last_label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Last_label.Name = "Last_label"
        Me.Last_label.Size = New System.Drawing.Size(193, 42)
        Me.Last_label.TabIndex = 11
        Me.Last_label.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(5, 346)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 63)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address"
        '
        'Name_label
        '
        Me.Name_label.AutoSize = True
        Me.Name_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.Name_label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_label.ForeColor = System.Drawing.SystemColors.Control
        Me.Name_label.Location = New System.Drawing.Point(5, 73)
        Me.Name_label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Name_label.Name = "Name_label"
        Me.Name_label.Size = New System.Drawing.Size(197, 42)
        Me.Name_label.TabIndex = 0
        Me.Name_label.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(5, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 59)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(1031, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 59)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Birth"
        '
        'Name_Txt_add
        '
        Me.Name_Txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Name_Txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Txt_add.Location = New System.Drawing.Point(5, 120)
        Me.Name_Txt_add.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name_Txt_add.Name = "Name_Txt_add"
        Me.Name_Txt_add.Size = New System.Drawing.Size(503, 56)
        Me.Name_Txt_add.TabIndex = 0
        Me.Name_Txt_add.Text = " "
        '
        'Last_txt_add
        '
        Me.Last_txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Last_txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_txt_add.Location = New System.Drawing.Point(1031, 120)
        Me.Last_txt_add.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Last_txt_add.Name = "Last_txt_add"
        Me.Last_txt_add.Size = New System.Drawing.Size(503, 56)
        Me.Last_txt_add.TabIndex = 6
        '
        'Gender_combo_add
        '
        Me.Gender_combo_add.DisplayMember = "key"
        Me.Gender_combo_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gender_combo_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gender_combo_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender_combo_add.FormattingEnabled = True
        Me.Gender_combo_add.Items.AddRange(New Object() {"[1,Male]", "[2, Female]", "[3, Prefered not to answer]"})
        Me.Gender_combo_add.Location = New System.Drawing.Point(5, 258)
        Me.Gender_combo_add.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Gender_combo_add.Name = "Gender_combo_add"
        Me.Gender_combo_add.Size = New System.Drawing.Size(503, 57)
        Me.Gender_combo_add.TabIndex = 7
        Me.Gender_combo_add.ValueMember = "key"
        '
        'Address_txt
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.Address_txt, 2)
        Me.Address_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Address_txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_txt.Location = New System.Drawing.Point(5, 414)
        Me.Address_txt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Address_txt.Name = "Address_txt"
        Me.Address_txt.Size = New System.Drawing.Size(1016, 56)
        Me.Address_txt.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(5, 506)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 63)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "City"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(518, 506)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 63)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(1031, 506)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 63)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Zip"
        '
        'City_txt_add
        '
        Me.City_txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.City_txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_txt_add.Location = New System.Drawing.Point(5, 574)
        Me.City_txt_add.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.City_txt_add.Name = "City_txt_add"
        Me.City_txt_add.Size = New System.Drawing.Size(503, 56)
        Me.City_txt_add.TabIndex = 15
        '
        'State_txt_add
        '
        Me.State_txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.State_txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.State_txt_add.Location = New System.Drawing.Point(518, 574)
        Me.State_txt_add.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.State_txt_add.Name = "State_txt_add"
        Me.State_txt_add.Size = New System.Drawing.Size(503, 56)
        Me.State_txt_add.TabIndex = 16
        '
        'Zip_txt_add
        '
        Me.Zip_txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Zip_txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zip_txt_add.Location = New System.Drawing.Point(1031, 574)
        Me.Zip_txt_add.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Zip_txt_add.Name = "Zip_txt_add"
        Me.Zip_txt_add.Size = New System.Drawing.Size(503, 56)
        Me.Zip_txt_add.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(5, 654)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(269, 48)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Phone Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(1031, 654)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 48)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "eMail"
        '
        'Phone_txt_add
        '
        Me.Phone_txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Phone_txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_txt_add.Location = New System.Drawing.Point(5, 707)
        Me.Phone_txt_add.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Phone_txt_add.Name = "Phone_txt_add"
        Me.Phone_txt_add.Size = New System.Drawing.Size(503, 56)
        Me.Phone_txt_add.TabIndex = 20
        '
        'eMail_txt_add
        '
        Me.eMail_txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eMail_txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eMail_txt_add.Location = New System.Drawing.Point(1031, 707)
        Me.eMail_txt_add.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.eMail_txt_add.Name = "eMail_txt_add"
        Me.eMail_txt_add.Size = New System.Drawing.Size(503, 56)
        Me.eMail_txt_add.TabIndex = 21
        '
        'dob_datepicker
        '
        Me.dob_datepicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dob_datepicker.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dob_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dob_datepicker.Location = New System.Drawing.Point(1031, 258)
        Me.dob_datepicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dob_datepicker.Name = "dob_datepicker"
        Me.dob_datepicker.Size = New System.Drawing.Size(503, 56)
        Me.dob_datepicker.TabIndex = 8
        '
        'Action_btn
        '
        Me.Action_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Action_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Action_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Action_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Action_btn.Location = New System.Drawing.Point(518, 786)
        Me.Action_btn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Action_btn.Name = "Action_btn"
        Me.Action_btn.Size = New System.Drawing.Size(503, 80)
        Me.Action_btn.TabIndex = 23
        Me.Action_btn.Text = "REGISTER"
        Me.Action_btn.UseVisualStyleBackColor = False
        '
        'User_id_combo
        '
        Me.User_id_combo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.User_id_combo.FormattingEnabled = True
        Me.User_id_combo.Location = New System.Drawing.Point(518, 5)
        Me.User_id_combo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.User_id_combo.Name = "User_id_combo"
        Me.User_id_combo.Size = New System.Drawing.Size(503, 39)
        Me.User_id_combo.TabIndex = 25
        Me.User_id_combo.Visible = False
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
        Me.Title_label.Size = New System.Drawing.Size(1935, 107)
        Me.Title_label.TabIndex = 1
        Me.Title_label.Text = "REGISTRATION FORM"
        Me.Title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(2619, 126)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(5, 1233)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(2619, 128)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'Customers_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(2629, 1421)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Customers_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel_form.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Add_btn As Button
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Update_btn As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel_form As Panel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Last_label As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Name_label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Name_Txt_add As TextBox
    Friend WithEvents Last_txt_add As TextBox
    Friend WithEvents Gender_combo_add As ComboBox
    Friend WithEvents Address_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents City_txt_add As TextBox
    Friend WithEvents State_txt_add As TextBox
    Friend WithEvents Zip_txt_add As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Phone_txt_add As TextBox
    Friend WithEvents eMail_txt_add As TextBox
    Friend WithEvents dob_datepicker As DateTimePicker
    Friend WithEvents Action_btn As Button
    Friend WithEvents User_id_combo As ComboBox
    Friend WithEvents Title_label As Label
    Friend WithEvents BOOKINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As ToolStripMenuItem
End Class
