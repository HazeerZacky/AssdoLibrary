<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Issues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Issues))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.llbName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.gbBook = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblIssueID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBkFind = New System.Windows.Forms.Button()
        Me.btnMemFind = New System.Windows.Forms.Button()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtMemID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBook.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(37, 146)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(205, 22)
        Me.DateTimePicker1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Book ID : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Member ID : "
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(271, 97)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.ReadOnly = True
        Me.txtBookName.Size = New System.Drawing.Size(205, 22)
        Me.txtBookName.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Book Name :"
        '
        'txtMemberName
        '
        Me.txtMemberName.Location = New System.Drawing.Point(271, 50)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.ReadOnly = True
        Me.txtMemberName.Size = New System.Drawing.Size(205, 22)
        Me.txtMemberName.TabIndex = 3
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnReset.Location = New System.Drawing.Point(771, 114)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 29)
        Me.btnReset.TabIndex = 34
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'llbName
        '
        Me.llbName.AutoSize = True
        Me.llbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbName.Location = New System.Drawing.Point(268, 31)
        Me.llbName.Name = "llbName"
        Me.llbName.Size = New System.Drawing.Size(107, 16)
        Me.llbName.TabIndex = 0
        Me.llbName.Text = "Member Name : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(913, 236)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Issue Table"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(901, 211)
        Me.DataGridView1.TabIndex = 37
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdate.Location = New System.Drawing.Point(771, 78)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 29)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.Location = New System.Drawing.Point(771, 38)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 29)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(34, 126)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(70, 16)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Issu Date :"
        '
        'gbBook
        '
        Me.gbBook.Controls.Add(Me.PictureBox1)
        Me.gbBook.Controls.Add(Me.lblIssueID)
        Me.gbBook.Controls.Add(Me.Label4)
        Me.gbBook.Controls.Add(Me.btnBkFind)
        Me.gbBook.Controls.Add(Me.btnMemFind)
        Me.gbBook.Controls.Add(Me.txtBookID)
        Me.gbBook.Controls.Add(Me.txtMemID)
        Me.gbBook.Controls.Add(Me.DateTimePicker1)
        Me.gbBook.Controls.Add(Me.Label1)
        Me.gbBook.Controls.Add(Me.Label3)
        Me.gbBook.Controls.Add(Me.txtBookName)
        Me.gbBook.Controls.Add(Me.Label2)
        Me.gbBook.Controls.Add(Me.txtMemberName)
        Me.gbBook.Controls.Add(Me.btnReset)
        Me.gbBook.Controls.Add(Me.llbName)
        Me.gbBook.Controls.Add(Me.btnUpdate)
        Me.gbBook.Controls.Add(Me.btnAdd)
        Me.gbBook.Controls.Add(Me.lblPhone)
        Me.gbBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBook.Location = New System.Drawing.Point(12, 10)
        Me.gbBook.Name = "gbBook"
        Me.gbBook.Size = New System.Drawing.Size(913, 182)
        Me.gbBook.TabIndex = 42
        Me.gbBook.TabStop = False
        Me.gbBook.Text = "Issue Form"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(617, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 84)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'lblIssueID
        '
        Me.lblIssueID.AutoSize = True
        Me.lblIssueID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueID.Location = New System.Drawing.Point(639, 18)
        Me.lblIssueID.Name = "lblIssueID"
        Me.lblIssueID.Size = New System.Drawing.Size(53, 16)
        Me.lblIssueID.TabIndex = 49
        Me.lblIssueID.Text = "..............."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(581, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Issue ID: "
        '
        'btnBkFind
        '
        Me.btnBkFind.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnBkFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnBkFind.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBkFind.Location = New System.Drawing.Point(495, 97)
        Me.btnBkFind.Name = "btnBkFind"
        Me.btnBkFind.Size = New System.Drawing.Size(59, 22)
        Me.btnBkFind.TabIndex = 47
        Me.btnBkFind.Text = "Find"
        Me.btnBkFind.UseVisualStyleBackColor = False
        '
        'btnMemFind
        '
        Me.btnMemFind.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnMemFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnMemFind.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnMemFind.Location = New System.Drawing.Point(495, 50)
        Me.btnMemFind.Name = "btnMemFind"
        Me.btnMemFind.Size = New System.Drawing.Size(59, 22)
        Me.btnMemFind.TabIndex = 46
        Me.btnMemFind.Text = "Find"
        Me.btnMemFind.UseVisualStyleBackColor = False
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(37, 98)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(205, 22)
        Me.txtBookID.TabIndex = 45
        Me.txtBookID.Text = "ASDB"
        '
        'txtMemID
        '
        Me.txtMemID.Location = New System.Drawing.Point(37, 50)
        Me.txtMemID.Name = "txtMemID"
        Me.txtMemID.Size = New System.Drawing.Size(205, 22)
        Me.txtMemID.TabIndex = 44
        Me.txtMemID.Text = "ASDM"
        '
        'Issues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(937, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Issues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issues"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBook.ResumeLayout(False)
        Me.gbBook.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents llbName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblPhone As Label
    Friend WithEvents gbBook As GroupBox
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtMemID As TextBox
    Friend WithEvents btnMemFind As Button
    Friend WithEvents btnBkFind As Button
    Friend WithEvents lblIssueID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
