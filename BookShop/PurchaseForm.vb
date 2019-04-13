Imports System.Data.OleDb

Public Class PurchaseForm
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchaseList.CellContentClick


    End Sub

    Private Sub ClosePurchaseFormButton_Click(sender As Object, e As EventArgs) Handles ClosePurchaseFormButton.Click
        Me.Visible = False

    End Sub

    Private Sub PurchaseFormButton_Click(sender As Object, e As EventArgs) Handles PurchaseFormButton.Click
        Dim TotalPay As Integer
        TotalPay = 0
        Dim PurchaseCount As Integer

        If PurchaseList.Rows.Count > 0 Then
            For PurchaseCount = 0 To PurchaseList.Rows.Count - 1
                TotalPay = TotalPay + (Val(PurchaseList.Item(8, PurchaseCount).Value) * Val(PurchaseList.Item(7, PurchaseCount).Value))
            Next

            TotalPayTextBox.Text = TotalPay
            TotalPay = 0
            PayedPurchaseFormButton.Visible = True

        Else
            MessageBox.Show("Nothing To Calculate")
        End If


    End Sub

    Private Sub ClearPurchaseFormButton_Click(sender As Object, e As EventArgs) Handles ClearPurchaseFormButton.Click
        Dim PurchaseRowCount As Integer

        For PurchaseRowCount = 0 To Main.ds2.Tables("PurchaseTable").Rows.Count - 1
            Main.ds2.Tables("PurchaseTable").Rows(PurchaseRowCount).Delete()
        Next
        Dim cd2 As New OleDbCommandBuilder(Main.da2)
        Main.da2.Update(Main.ds2, "PurchaseTable")
        TotalPayTextBox.Text = ""
        Main.BusketButton.Text = "Basket= " & Main.ds2.Tables("PurchaseTable").Rows.Count
        If Main.AddBook.Enabled = False Then
            Main.AddBook.Enabled = True
            Main.EditBook.Enabled = True
            Main.RemoveBook.Enabled = True
        End If
        If PayedPurchaseFormButton.Visible = True Then
            PayedPurchaseFormButton.Visible = False
        End If

    End Sub

    Private Sub DeletePurchaseFormButton_Click(sender As Object, e As EventArgs) Handles DeletePurchaseFormButton.Click
        Dim PurchaseRow As Integer

        If PurchaseList.Rows.Count > 0 Then
            PurchaseRow = PurchaseList.CurrentRow.Index
            PurchaseList.AllowUserToDeleteRows = True
            PurchaseList.Rows.Remove(PurchaseList.Rows(PurchaseRow))
            Dim cd As New OleDbCommandBuilder(Main.da2)
            Main.da2.Update(Main.ds2, "PurchaseTable")
            PurchaseList.AllowUserToDeleteRows = False
            Main.BusketButton.Text = "Basket= " & Main.ds2.Tables("PurchaseTable").Rows.Count
            If PayedPurchaseFormButton.Visible = True Then
                PayedPurchaseFormButton.Visible = False
            End If

        Else
            MessageBox.Show("Nothing To delete")
        End If

    End Sub

    Private Sub PayedPurchaseFormButton_Click(sender As Object, e As EventArgs) Handles PayedPurchaseFormButton.Click
        Dim PayedBookCount As Integer
        Dim PayedBookLast As Integer
        Dim BookListCount As Integer
        Dim BookListLast As Integer
        Dim PaymentDone As String

        If PurchaseList.Rows.Count > 0 Then
            PayedBookLast = Main.ds2.Tables("PurchaseTable").Rows.Count - 1
            BookListLast = Main.ds.Tables("BookTable").Rows.Count - 1
            Main.BookList.AllowUserToDeleteRows = True
            PurchaseList.AllowUserToDeleteRows = True

            For PayedBookCount = 0 To PayedBookLast
                For BookListCount = 0 To BookListLast
                    If Val(PurchaseList.Item(0, PayedBookCount).Value) = Val(Main.BookList.Item(0, BookListCount).Value) Then
                        Main.ds.Tables("BookTable").Rows(BookListCount).Item(7) = Val(Main.BookList.Item(7, BookListCount).Value) - Val(PurchaseList.Item(7, PayedBookCount).Value)
                    End If
                Next
            Next

            For Each row As DataGridViewRow In Main.BookList.Rows
                If row.Cells(7).Value = 0 Then
                    Main.BookList.Rows.Remove(row)
                End If
            Next
            For Each row2 As DataGridViewRow In PurchaseList.Rows
                PurchaseList.Rows.Remove(row2)
            Next
            Dim cd2 As New OleDbCommandBuilder(Main.da2)
            Main.da2.Update(Main.ds2, "PurchaseTable")
            PurchaseList.AllowUserToDeleteRows = False
            Dim cd As New OleDbCommandBuilder(Main.da)
            Main.da.Update(Main.ds, "BookTable")
            Main.BookList.AllowUserToDeleteRows = False
            PayedPurchaseFormButton.Visible = False
            Main.AddBook.Enabled = True
            Main.RemoveBook.Enabled = True
            Main.EditBook.Enabled = True
            Main.BusketButton.Text = "Basket= " & Main.ds2.Tables("PurchaseTable").Rows.Count
            Me.Visible = False
            PaymentDone = "Payment of Rs. " & TotalPayTextBox.Text & " is Successful"
            TotalPayTextBox.Text = ""
            MessageBox.Show(PaymentDone)

        Else
            MessageBox.Show("Nothing to Pay")
        End If
    End Sub

    Private Sub PurchaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = 0
    End Sub
End Class