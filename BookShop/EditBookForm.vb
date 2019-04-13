Imports System.Data.OleDb

Public Class EditBookForm
    Private Sub isbnEditTextBox_TextChanged(sender As Object, e As EventArgs) Handles isbnEditTextBox.TextChanged
        If Not IsNumeric(isbnEditTextBox.Text) Then
            If isbnEditTextBox.Text.Length > 0 Then
                isbnEditTextBox.Text = isbnEditTextBox.Text.Remove(isbnEditTextBox.Text.Length - 1)

            Else
                isbnEditTextBox.Text = String.Empty

            End If
            MessageBox.Show("Enter Numbers Only")

        End If
    End Sub

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        If isbnEditTextBox.Text <> "" And BookNameEditTextBox.Text <> "" And AuthorEditTextBox.Text <> "" And PublicationEditTextBox.Text <> "" And EditionEditTextBox.Text <> "" And SubjectEditTextBox.Text <> "" And AvalableEditTextBox.Text <> "" And PriceEditTextBox.Text <> "" Then
            Dim cd As New OleDbCommandBuilder(Main.da)
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(0) = Val(isbnEditTextBox.Text)
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(1) = BookNameEditTextBox.Text
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(2) = AuthorEditTextBox.Text
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(3) = PublicationEditTextBox.Text
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(4) = EditionEditTextBox.Text
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(5) = SubjectEditTextBox.Text
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(6) = DateEditPicker.Value.Date
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(7) = Val(AvalableEditTextBox.Text)
            Main.ds.Tables("BookTable").Rows(Main.SelectRow).Item(8) = Val(PriceEditTextBox.Text)
            Main.da.Update(Main.ds, "BookTable")
            Main.BookList.DataSource = Main.ds
            Main.BookList.DataMember = "BookTable"

            Me.Close()
            Main.Enabled = True
            Main.Opacity = 1
            Main.BringToFront()

        Else
            MessageBox.Show("Plese Enter All The Field")
        End If


    End Sub

    Private Sub EditCloseButton_Click(sender As Object, e As EventArgs) Handles EditCloseButton.Click
        Me.Close()
        Main.Enabled = True
        Main.Opacity = 1
        Main.BringToFront()
    End Sub

    Private Sub EditBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isbnEditTextBox.Enabled = False
        Me.BringToFront()
    End Sub

    Private Sub AvalableEditTextBox_TextChanged(sender As Object, e As EventArgs) Handles AvalableEditTextBox.TextChanged
        If Not IsNumeric(AvalableEditTextBox.Text) Then
            If AvalableEditTextBox.Text.Length > 0 Then
                AvalableEditTextBox.Text = AvalableEditTextBox.Text.Remove(AvalableEditTextBox.Text.Length - 1)

            Else
                AvalableEditTextBox.Text = String.Empty

            End If
            MessageBox.Show("Enter Numbers Only")

        End If
    End Sub

    Private Sub PriceEditTextBox_TextChanged(sender As Object, e As EventArgs) Handles PriceEditTextBox.TextChanged
        If Not IsNumeric(PriceEditTextBox.Text) Then
            If PriceEditTextBox.Text.Length > 0 Then
                PriceEditTextBox.Text = PriceEditTextBox.Text.Remove(PriceEditTextBox.Text.Length - 1)

            Else
                PriceEditTextBox.Text = String.Empty

            End If
            MessageBox.Show("Enter Numbers Only")

        End If
    End Sub
End Class