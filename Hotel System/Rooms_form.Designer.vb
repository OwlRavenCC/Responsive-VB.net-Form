<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rooms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BOOKINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Last_label = New System.Windows.Forms.Label()
        Me.Name_label = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Action_btn = New System.Windows.Forms.Button()
        Me.Room_Txt_add = New System.Windows.Forms.TextBox()
        Me.Cat_txt_add = New System.Windows.Forms.TextBox()
        Me.User_id_combo = New System.Windows.Forms.ComboBox()
        Me.Title_label = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_form = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_form.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.RoomsToolStripMenuItem.Text = "Rooms"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1308, 67)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 662)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1308, 68)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'BOOKINGToolStripMenuItem
        '
        Me.BOOKINGToolStripMenuItem.Name = "BOOKINGToolStripMenuItem"
        Me.BOOKINGToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.BOOKINGToolStripMenuItem.Text = "Bookings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(243, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 125)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SELECT ROOM: "
        Me.Label1.Visible = False
        '
        'Last_label
        '
        Me.Last_label.AutoSize = True
        Me.Last_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.Last_label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_label.ForeColor = System.Drawing.SystemColors.Control
        Me.Last_label.Location = New System.Drawing.Point(386, 125)
        Me.Last_label.Name = "Last_label"
        Me.Last_label.Size = New System.Drawing.Size(84, 28)
        Me.Last_label.TabIndex = 11
        Me.Last_label.Text = "Category"
        '
        'Name_label
        '
        Me.Name_label.AutoSize = True
        Me.Name_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.Name_label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_label.ForeColor = System.Drawing.SystemColors.Control
        Me.Name_label.Location = New System.Drawing.Point(3, 125)
        Me.Name_label.Name = "Name_label"
        Me.Name_label.Size = New System.Drawing.Size(132, 28)
        Me.Name_label.TabIndex = 0
        Me.Name_label.Text = "Room Number"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.Action_btn, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Last_label, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Name_label, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Room_Txt_add, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Cat_txt_add, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.User_id_combo, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 5)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.05085!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13559!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.81356!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(766, 465)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'Action_btn
        '
        Me.Action_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Action_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Action_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Action_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Action_btn.Location = New System.Drawing.Point(3, 218)
        Me.Action_btn.Name = "Action_btn"
        Me.Action_btn.Size = New System.Drawing.Size(377, 43)
        Me.Action_btn.TabIndex = 26
        Me.Action_btn.Text = "REGISTER"
        Me.Action_btn.UseVisualStyleBackColor = False
        '
        'Room_Txt_add
        '
        Me.Room_Txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Room_Txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room_Txt_add.Location = New System.Drawing.Point(3, 156)
        Me.Room_Txt_add.Name = "Room_Txt_add"
        Me.Room_Txt_add.Size = New System.Drawing.Size(377, 32)
        Me.Room_Txt_add.TabIndex = 0
        Me.Room_Txt_add.Text = " "
        '
        'Cat_txt_add
        '
        Me.Cat_txt_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cat_txt_add.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cat_txt_add.Location = New System.Drawing.Point(386, 156)
        Me.Cat_txt_add.Name = "Cat_txt_add"
        Me.Cat_txt_add.Size = New System.Drawing.Size(377, 32)
        Me.Cat_txt_add.TabIndex = 6
        '
        'User_id_combo
        '
        Me.User_id_combo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.User_id_combo.FormattingEnabled = True
        Me.User_id_combo.Location = New System.Drawing.Point(386, 3)
        Me.User_id_combo.Name = "User_id_combo"
        Me.User_id_combo.Size = New System.Drawing.Size(377, 24)
        Me.User_id_combo.TabIndex = 25
        Me.User_id_combo.Visible = False
        '
        'Title_label
        '
        Me.Title_label.AutoSize = True
        Me.Title_label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title_label.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Title_label.Location = New System.Drawing.Point(3, 0)
        Me.Title_label.Name = "Title_label"
        Me.Title_label.Size = New System.Drawing.Size(965, 57)
        Me.Title_label.TabIndex = 1
        Me.Title_label.Text = "REGISTER NEW ROOM"
        Me.Title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.BOOKINGToolStripMenuItem, Me.RoomsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1314, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'Panel_form
        '
        Me.Panel_form.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_form.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel_form.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_form.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_form.Location = New System.Drawing.Point(99, 3)
        Me.Panel_form.Name = "Panel_form"
        Me.Panel_form.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Panel_form.Size = New System.Drawing.Size(766, 475)
        Me.Panel_form.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.11364!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.943182!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel_form, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 60)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 481.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(965, 481)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Title_label, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(334, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(971, 574)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Add_btn
        '
        Me.Add_btn.BackColor = System.Drawing.Color.LimeGreen
        Me.Add_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Add_btn.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Add_btn.Location = New System.Drawing.Point(3, 3)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(319, 185)
        Me.Add_btn.TabIndex = 3
        Me.Add_btn.Text = "New Room"
        Me.Add_btn.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1314, 733)
        Me.TableLayoutPanel1.TabIndex = 3
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 76)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1308, 580)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Delete_btn, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Update_btn, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Add_btn, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(325, 574)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Delete_btn
        '
        Me.Delete_btn.BackColor = System.Drawing.Color.IndianRed
        Me.Delete_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Delete_btn.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Delete_btn.Location = New System.Drawing.Point(3, 385)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(319, 186)
        Me.Delete_btn.TabIndex = 5
        Me.Delete_btn.Text = "Delete Room"
        Me.Delete_btn.UseVisualStyleBackColor = False
        '
        'Update_btn
        '
        Me.Update_btn.BackColor = System.Drawing.Color.DarkOrange
        Me.Update_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Update_btn.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Update_btn.Location = New System.Drawing.Point(3, 194)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(319, 185)
        Me.Update_btn.TabIndex = 4
        Me.Update_btn.Text = "Update Room"
        Me.Update_btn.UseVisualStyleBackColor = False
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1314, 733)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Rooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms"
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_form.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RoomsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents BOOKINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Last_label As Label
    Friend WithEvents Name_label As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Room_Txt_add As TextBox
    Friend WithEvents Cat_txt_add As TextBox
    Friend WithEvents Title_label As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_form As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Add_btn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Update_btn As Button
    Friend WithEvents User_id_combo As ComboBox
    Friend WithEvents Action_btn As Button
End Class
