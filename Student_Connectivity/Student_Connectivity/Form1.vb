Imports System.Data.OleDb
Public Class Form1
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim ds As Data.DataSet
    Dim da As OleDbDataAdapter
    Dim gender As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sebastian\Documents\Student.accdb")
        conn.Open()
    End Sub




    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If maleradio.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"

        End If
        cmd = New OleDbCommand("insert into studtable([Roll No],[Student Name],[Gender],[DOB],[Address],[Contact No]) values (" + txtroll_no.Text + ",'" + txtstudname.Text + "','" + gender + "','" + Format(txtdob.Value, "dd-MM-yyyy") + "', '" + txtaddress.Text + "','" + txtcontact.Text + "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Inserted Successfully")

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If maleradio.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"

        End If

        cmd = New OleDbCommand("Update studtable set [Student Name]='" + txtstudname.Text + "',[Address]='" + txtaddress.Text + "',[Gender]='" + gender + "',[DOB]='" + Format(txtdob.Value, "dd-MM-yyyy") + "',[Contact No] = '" + txtcontact.Text + "' where [Roll No]=" + txtroll_no.Text + "", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Updated Successfully")
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("Delete from studtable where [Roll No ] =" + txtroll_no.Text + " ", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Has Been Deleted")
    End Sub
    Private Sub btndiplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        da = New OleDbDataAdapter("Select * from studtable where [Roll No]=" + txtroll_no.Text + "", conn)
        ds = New DataSet
        da.Fill(ds, "studtable")
        txtstudname.Text = ds.Tables("studtable").Rows(0)("Student Name").ToString
        txtaddress.Text = ds.Tables("studtable").Rows(0)("Address").ToString
        If ds.Tables("studtable").Rows(0)("Gender") = "Male" Then
            maleradio.Checked = True
        Else
            femaleradio.Checked = True
        End If
        txtdob.Value = ds.Tables("studtable").Rows(0)("DOB").ToString
        txtcontact.Text = ds.Tables("studtable").Rows(0)("Contact No").ToString
    End Sub
End Class

