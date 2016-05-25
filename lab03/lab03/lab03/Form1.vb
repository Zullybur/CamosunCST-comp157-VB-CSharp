'Address book program to store, view, and search through saved addresses
'Created by: Matthew Casiro
'Created on: May 5th 2016
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Public Class Form1
    Private addressDList As Dictionary(Of String, List(Of String))
    Private lstAddress As List(Of Address)
    Private strFilename As String
    Private sr As StreamReader
    Private sw As StreamWriter
    'Initialize dictionary and list and read initial information from source file
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addressDList = New Dictionary(Of String, List(Of String))
        lstAddress = New List(Of Address)
        strFilename = "address.txt"
        If FileSystem.FileExists(strFilename) Then
            Try
                sr = New StreamReader(strFilename)
                While sr.Peek <> -1
                    Dim strLine As String
                    Dim strArray() As String
                    strLine = sr.ReadLine
                    strArray = strLine.Split(CType(",", Char()))
                    If addressDList.ContainsKey(strArray(0)) Then
                        addressDList(strArray(0)) = New List(Of String) From {strArray(1).Trim & ", " & strArray(2).Trim, strArray(3).Trim}
                    Else
                        addressDList.Add(strArray(0).Trim, New List(Of String) From {strArray(1).Trim & ", " & strArray(2).Trim, strArray(3).Trim})
                        Debug.WriteLine("Added Key: " & strArray(0) & " With: " & addressDList(strArray(0))(0) & ", " & addressDList(strArray(0))(1))
                    End If
                    lstAddress.Add(New Address(strArray(0), addressDList(strArray(0))(0), addressDList(strArray(0))(1)))
                End While
                sr.Close()
            Catch ex As Exception
            End Try
        End If
        dgvResults.DataSource = lstAddress
    End Sub
    'Search through address entries for a nickname, and return the address object that matches
    Private Function FindAddress(ByVal strNickname As String) As Address
        For Each a As Address In lstAddress
            If a.Nickname = strNickname Then
                Return a
            End If
        Next
        Return Nothing
    End Function
    'Search through dictionary for text matches in any field based on search term
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strSearch As String
        strSearch = tbSearch.Text.Trim
        'Verify search box is not empty
        If strSearch = Nothing Or strSearch = "" Then
            MessageBox.Show("No search string was entered",
                            "Search Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        Else
            'Reset lstAddress and rebuild with matching rows
            lstAddress = Nothing
            lstAddress = New List(Of Address)
            For Each kvp As KeyValuePair(Of String, List(Of String)) In addressDList
                If strSearch = "*" Or kvp.Key.IndexOf(strSearch) >= 0 Or kvp.Value.Item(0).IndexOf(strSearch) >= 0 Or kvp.Value.Item(1).IndexOf(strSearch) >= 0 Then
                    lstAddress.Add(New Address(kvp.Key, kvp.Value.Item(0), kvp.Value.Item(1)))
                End If
            Next
            'Reset results view with new data
            dgvResults.DataSource = Nothing
            dgvResults.DataSource = lstAddress
        End If
    End Sub
    'Save all addresses whenever form closes
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveAllAddress()
    End Sub
    'Write addresses in dictionary to file
    Private Sub SaveAllAddress()
        Try
            sw = New StreamWriter(strFilename, False)
            For Each kvp As KeyValuePair(Of String, List(Of String)) In addressDList
                sw.WriteLine(kvp.Key & ", " & kvp.Value.Item(0) & ", " & kvp.Value.Item(1))
            Next
            sw.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to write address entries: " & vbCrLf & ex.Message.ToString)
        End Try
    End Sub
    'Insert new data in to a row 
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If tbNickname.Text = Nothing Or tbNickname.Text = "" Or tbName.Text = Nothing Or tbName.Text = "" Or tbEmail.Text = Nothing Or tbEmail.Text = "" Then
            MessageBox.Show("Unable to insert address entry: One or more fields are blank")
        Else
            If addressDList.ContainsKey(tbNickname.Text.Trim) Then
                addressDList(tbNickname.Text.Trim) = New List(Of String) From {tbName.Text.Trim, tbEmail.Text.Trim}
                lstAddress.Remove(FindAddress(tbNickname.Text.Trim))
            Else
                addressDList.Add(tbNickname.Text.Trim, New List(Of String) From {tbName.Text.Trim, tbEmail.Text.Trim})
            End If
            lstAddress.Add(New Address(tbNickname.Text.Trim, addressDList(tbNickname.Text.Trim)(0), addressDList(tbNickname.Text.Trim)(1)))
            dgvResults.DataSource = Nothing
            dgvResults.DataSource = lstAddress
        End If
    End Sub
    'Set search to * and run to display all data, then clear search text field
    Private Sub ClearSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSearchToolStripMenuItem.Click
        tbSearch.Text = "*"
        btnSearch_Click(sender, e)
        tbSearch.Text = ""
    End Sub
    'Save all addresses to file
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveAllAddress()
    End Sub
    'Exit application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class