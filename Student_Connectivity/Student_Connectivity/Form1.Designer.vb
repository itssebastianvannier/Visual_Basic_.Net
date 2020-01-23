<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.roll_no = New System.Windows.Forms.Label()
        Me.txtroll_no = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.Label()
        Me.genderlbl = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.Label()
        Me.stud_name = New System.Windows.Forms.Label()
        Me.Contact = New System.Windows.Forms.Label()
        Me.txtstudname = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.maleradio = New System.Windows.Forms.RadioButton()
        Me.femaleradio = New System.Windows.Forms.RadioButton()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtdob = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'roll_no
        '
        Me.roll_no.AutoSize = True
        Me.roll_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roll_no.Location = New System.Drawing.Point(84, 39)
        Me.roll_no.Name = "roll_no"
        Me.roll_no.Size = New System.Drawing.Size(60, 20)
        Me.roll_no.TabIndex = 0
        Me.roll_no.Text = "Roll No"
        '
        'txtroll_no
        '
        Me.txtroll_no.Location = New System.Drawing.Point(188, 41)
        Me.txtroll_no.Name = "txtroll_no"
        Me.txtroll_no.Size = New System.Drawing.Size(187, 20)
        Me.txtroll_no.TabIndex = 1
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(84, 206)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(68, 20)
        Me.address.TabIndex = 2
        Me.address.Text = "Address"
        '
        'genderlbl
        '
        Me.genderlbl.AutoSize = True
        Me.genderlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlbl.Location = New System.Drawing.Point(84, 169)
        Me.genderlbl.Name = "genderlbl"
        Me.genderlbl.Size = New System.Drawing.Size(63, 20)
        Me.genderlbl.TabIndex = 3
        Me.genderlbl.Text = "Gender"
        '
        'dob
        '
        Me.dob.AutoSize = True
        Me.dob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dob.Location = New System.Drawing.Point(84, 127)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(44, 20)
        Me.dob.TabIndex = 4
        Me.dob.Text = "DOB"
        '
        'stud_name
        '
        Me.stud_name.AutoSize = True
        Me.stud_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_name.Location = New System.Drawing.Point(84, 81)
        Me.stud_name.Name = "stud_name"
        Me.stud_name.Size = New System.Drawing.Size(51, 20)
        Me.stud_name.TabIndex = 5
        Me.stud_name.Text = "Name"
        '
        'Contact
        '
        Me.Contact.AutoSize = True
        Me.Contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact.Location = New System.Drawing.Point(84, 294)
        Me.Contact.Name = "Contact"
        Me.Contact.Size = New System.Drawing.Size(65, 20)
        Me.Contact.TabIndex = 6
        Me.Contact.Text = "Contact"
        '
        'txtstudname
        '
        Me.txtstudname.Location = New System.Drawing.Point(188, 81)
        Me.txtstudname.Name = "txtstudname"
        Me.txtstudname.Size = New System.Drawing.Size(187, 20)
        Me.txtstudname.TabIndex = 7
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(188, 296)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(187, 20)
        Me.txtcontact.TabIndex = 8
        '
        'maleradio
        '
        Me.maleradio.AutoSize = True
        Me.maleradio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleradio.Location = New System.Drawing.Point(188, 165)
        Me.maleradio.Name = "maleradio"
        Me.maleradio.Size = New System.Drawing.Size(61, 24)
        Me.maleradio.TabIndex = 9
        Me.maleradio.TabStop = True
        Me.maleradio.Text = "Male"
        Me.maleradio.UseVisualStyleBackColor = True
        '
        'femaleradio
        '
        Me.femaleradio.AutoSize = True
        Me.femaleradio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleradio.Location = New System.Drawing.Point(295, 165)
        Me.femaleradio.Name = "femaleradio"
        Me.femaleradio.Size = New System.Drawing.Size(80, 24)
        Me.femaleradio.TabIndex = 10
        Me.femaleradio.TabStop = True
        Me.femaleradio.Text = "Female"
        Me.femaleradio.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(188, 206)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(187, 69)
        Me.txtaddress.TabIndex = 11
        Me.txtaddress.Text = ""
        '
        'btndisplay
        '
        Me.btndisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisplay.Location = New System.Drawing.Point(88, 348)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(75, 28)
        Me.btndisplay.TabIndex = 12
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(381, 290)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 28)
        Me.btninsert.TabIndex = 13
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(188, 348)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 28)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(300, 348)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 28)
        Me.btndelete.TabIndex = 15
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(188, 126)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(187, 20)
        Me.txtdob.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 407)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.femaleradio)
        Me.Controls.Add(Me.maleradio)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtstudname)
        Me.Controls.Add(Me.Contact)
        Me.Controls.Add(Me.stud_name)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.genderlbl)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.txtroll_no)
        Me.Controls.Add(Me.roll_no)
        Me.Name = "Form1"
        Me.Text = "Student_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents roll_no As System.Windows.Forms.Label
    Friend WithEvents txtroll_no As System.Windows.Forms.TextBox
    Friend WithEvents address As System.Windows.Forms.Label
    Friend WithEvents genderlbl As System.Windows.Forms.Label
    Friend WithEvents dob As System.Windows.Forms.Label
    Friend WithEvents stud_name As System.Windows.Forms.Label
    Friend WithEvents Contact As System.Windows.Forms.Label
    Friend WithEvents txtstudname As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents maleradio As System.Windows.Forms.RadioButton
    Friend WithEvents femaleradio As System.Windows.Forms.RadioButton
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents btndisplay As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtroll_no.TextChanged

    End Sub
    Friend WithEvents txtdob As System.Windows.Forms.DateTimePicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndisplay.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles stud_name.Click

    End Sub
End Class
