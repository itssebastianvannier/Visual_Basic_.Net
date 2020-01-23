Imports System.Data.OleDb
Public Class form1
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim gender As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet2.studtable' table. You can move, or remove it, as needed.
        Me.StudtableTableAdapter1.Fill(Me.StudentDataSet2.studtable)
        'TODO: This line of code loads data into the 'StudentDataSet1.studtable' table. You can move, or remove it, as needed.
        Me.StudtableTableAdapter.Fill(Me.StudentDataSet1.studtable)
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sebastian\Documents\Student.accdb")
        conn.Open()
    End Sub



    

    Private Sub btninsert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btninsert.Click
        If mlradio.Checked = True Then
            gender = "Male"

        Else
            gender = "Female"


        End If
        cmd = New OleDbCommand("insert into studtable([Roll No],[Student Name],[Gender],[DOB],[Address],[Contact No]) values (" + txtrollno.Text + ",'" + txtstdname.Text + "' , '" + gender + "' , '" + Format(txtdob.Value, "dd-MM-yyyy") + "','" + txtaddress.Text + "'," + txtcontact.Text + " )", conn)
        cmd.ExecuteNonQuery()
        MsgBox("The Record Has Been Inserted Successfully")

    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        da = New OleDbDataAdapter("Select * from studtable where [roll no]  = " + txtrollno.Text + "", conn)
        ds = New DataSet
        da.Fill(ds, "studtable")
        txtstdname.Text = ds.Tables("studtable").Rows(0)("Student Name").ToString
        If ds.Tables("studtable").Rows(0)("Gender") = "Male" Then
            mlradio.Checked = True
        Else
            fmlradio.Checked = True
        End If
        txtdob.Value = ds.Tables("studtable").Rows(0)("DOB").ToString
        txtaddress.Text = ds.Tables("studtable").Rows(0)("Address").ToString
        txtcontact.Text = ds.Tables("studtable").Rows(0)("Contact No").ToString

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If mlradio.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        cmd = New OleDbCommand("Update studtable set [Student Name]='" + txtstdname.Text + "',[Address]='" + txtaddress.Text + "',[Gender]='" + gender + "',[DOB]='" + Format(txtdob.Value, "dd-MM-yyyy") + "',[Contact No] = " + txtcontact.Text + " where [Roll No]=" + txtrollno.Text + "", conn)
        cmd.ExecuteNonQuery()
        MsgBox("The Record has been Updated Successfully")
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand(" Delete from studtable where [Roll No] = " + txtrollno.Text + " ", conn)
        cmd.ExecuteNonQuery()
        MsgBox(" Record Deleted Successfully ")
    End Sub

End Class
