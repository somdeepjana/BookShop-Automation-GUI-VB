Imports System.Data.OleDb



Public Class Main
    Public SelectRow As Integer

    Public con As New OleDb.OleDbConnection
    Public Provider As String
    Public DataSource As String
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public sql As String

    Public con2 As New OleDb.OleDbConnection
    Public DataSource2 As String
    Public da2 As OleDbDataAdapter
    Public ds2 As New DataSet


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PurchaseRowCount As Integer
        Dim Path As String
        Path = Application.StartupPath

        PurchaseForm.Show()
        PurchaseForm.Visible = False

        Provider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        DataSource = "Data Source= " & Path & "\database\BookData2.accdb;"
        con.ConnectionString = Provider & DataSource
        sql = "Select * from BookData"

        DataSource2 = "Data Source= " & Path & "\database\PurchaseDatabase.accdb;"
        con2.ConnectionString = Provider & DataSource2

        con.Open()
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "BookTable")
        con.Close()

        con2.Open()
        da2 = New OleDbDataAdapter(sql, con2)
        da2.Fill(ds2, "PurchaseTable")
        con2.Close()

        BookList.DataSource = ds
        BookList.DataMember = "BookTable"

        PurchaseForm.PurchaseList.DataSource = ds2
        PurchaseForm.PurchaseList.DataMember = "PurchaseTable"

        PurchaseForm.PurchaseList.AllowUserToDeleteRows = True
        For PurchaseRowCount = 0 To ds2.Tables("PurchaseTable").Rows.Count - 1
            ds2.Tables("PurchaseTable").Rows(PurchaseRowCount).Delete()
        Next
        Dim cd2 As New OleDbCommandBuilder(da2)
        da2.Update(ds2, "PurchaseTable")
        PurchaseForm.PurchaseList.AllowUserToDeleteRows = False

    End Sub

    Private Sub EditBook_Click(sender As Object, e As EventArgs) Handles EditBook.Click
        SelectRow = BookList.CurrentRow.Index

        EditBookForm.isbnEditTextBox.Text = BookList.Item(0, SelectRow).Value
        EditBookForm.BookNameEditTextBox.Text = BookList.Item(1, SelectRow).Value
        EditBookForm.AuthorEditTextBox.Text = BookList.Item(2, SelectRow).Value
        EditBookForm.PublicationEditTextBox.Text = BookList.Item(3, SelectRow).Value
        EditBookForm.EditionEditTextBox.Text = BookList.Item(4, SelectRow).Value
        EditBookForm.SubjectEditTextBox.Text = BookList.Item(5, SelectRow).Value
        EditBookForm.DateEditPicker.Value = BookList.Item(6, SelectRow).Value
        EditBookForm.AvalableEditTextBox.Text = BookList.Item(7, SelectRow).Value
        EditBookForm.PriceEditTextBox.Text = BookList.Item(8, SelectRow).Value
        EditBookForm.Show()
        Me.Enabled = False
        Me.Opacity = 0.4
    End Sub

    Private Sub RemoveBook_Click(sender As Object, e As EventArgs) Handles RemoveBook.Click
        SelectRow = BookList.CurrentRow.Index

        BookList.AllowUserToDeleteRows = True
        BookList.Rows.Remove(BookList.Rows(SelectRow))
        Dim cd As New OleDbCommandBuilder(da)
        da.Update(ds, "BookTable")
        BookList.AllowUserToDeleteRows = False

    End Sub

    Private Sub AddBook_Click(sender As Object, e As EventArgs) Handles AddBook.Click
        AddBookForm.Show()
        Me.Enabled = False
        Me.Opacity = 0.4
    End Sub

    Private Sub AddPurchaseButton_Click(sender As Object, e As EventArgs) Handles AddPurchaseButton.Click
        Dim CheckPurchaseList As Integer
        Dim AlreadyPurchased As Integer
        Dim PurchaseQuantity As String

        AlreadyPurchased = 0
        SelectRow = BookList.CurrentRow.Index

        For CheckPurchaseList = 0 To ds2.Tables("PurchaseTable").Rows.Count - 1
            If Val(PurchaseForm.PurchaseList.Item(0, CheckPurchaseList).Value) = Val(BookList.Item(0, SelectRow).Value) Then
                AlreadyPurchased = 1
            End If
        Next

        PurchaseQuantity = InputBox("Enter The Quantity of Books", "Quantity", 1)
        If Val(PurchaseQuantity) > 0 And Val(PurchaseQuantity) <= Val(BookList.Item(7, SelectRow).Value) Then
            If AlreadyPurchased = 0 Then

                If AddBook.Enabled = True Then
                    AddBook.Enabled = False
                    EditBook.Enabled = False
                    RemoveBook.Enabled = False
                End If

                Dim cb2 As New OleDb.OleDbCommandBuilder(da2)
                Dim dsNewRow As DataRow

                dsNewRow = ds2.Tables("PurchaseTable").NewRow()

                dsNewRow.Item(0) = Val(BookList.Item(0, SelectRow).Value)
                dsNewRow.Item(1) = BookList.Item(1, SelectRow).Value
                dsNewRow.Item(2) = BookList.Item(2, SelectRow).Value
                dsNewRow.Item(3) = BookList.Item(3, SelectRow).Value
                dsNewRow.Item(4) = BookList.Item(4, SelectRow).Value
                dsNewRow.Item(5) = BookList.Item(5, SelectRow).Value
                dsNewRow.Item(6) = BookList.Item(6, SelectRow).Value
                dsNewRow.Item(7) = Val(PurchaseQuantity)
                dsNewRow.Item(8) = Val(BookList.Item(8, SelectRow).Value)

                ds2.Tables("PurchaseTable").Rows.Add(dsNewRow)
                PurchaseForm.PurchaseList.DataSource = ds2
                da2.Update(ds2, "PurchaseTable")
                PurchaseForm.TotalPayTextBox.Text = ""

                BusketButton.Text = "Basket= " & ds2.Tables("PurchaseTable").Rows.Count
                PurchaseForm.PayedPurchaseFormButton.Visible = False

            Else
                MessageBox.Show("Already Purchased")
            End If

        Else
            MessageBox.Show("Invalid Quantity")
        End If
    End Sub

    Private Sub BusketButton_Click(sender As Object, e As EventArgs) Handles BusketButton.Click
        PurchaseForm.Visible = True
        PurchaseForm.BringToFront()

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        AddBookForm.Show()
        Me.Enabled = False
        Me.Opacity = 0.4
        SearchForm.Show()

    End Sub
End Class
