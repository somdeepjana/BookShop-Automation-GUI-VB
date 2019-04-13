Public Class AddBookForm
    Private Sub EditCloseButton_Click(sender As Object, e As EventArgs) Handles AddCloseButton.Click
        Me.Close()
        Main.Enabled = True
        Main.Opacity = 1
        Main.BringToFront()
    End Sub

    Private Sub EditBookButton_Click(sender As Object, e As EventArgs) Handles EditBookButton.Click

        If isbnAddTextBox.Text <> "" And BookNameAddTextBox.Text <> "" And AuthorAddTextBox.Text <> "" And PublicationAddTextBox.Text <> "" And EditionAddTextBox.Text <> "" And SubjectAddTextBox.Text <> "" And AvalableAddTextBox.Text <> "" And PriceAddTextBox.Text <> "" Then
            Dim AlreadeyAddedState As Integer
            AlreadeyAddedState = 0

            For Each AddRow As DataGridViewRow In Main.BookList.Rows
                If Val(isbnAddTextBox.Text) = Val(Main.BookList.Item(0, AddRow.Index).Value) Then
                    AlreadeyAddedState = 1
                End If
            Next
            If AlreadeyAddedState <> 1 Then
                Dim cb As New OleDb.OleDbCommandBuilder(Main.da)
                Dim dsNewRow As DataRow

                dsNewRow = Main.ds.Tables("BookTable").NewRow()

                dsNewRow.Item(0) = Val(isbnAddTextBox.Text)
                dsNewRow.Item(1) = BookNameAddTextBox.Text
                dsNewRow.Item(2) = AuthorAddTextBox.Text
                dsNewRow.Item(3) = PublicationAddTextBox.Text
                dsNewRow.Item(4) = EditionAddTextBox.Text
                dsNewRow.Item(5) = SubjectAddTextBox.Text
                dsNewRow.Item(6) = DateAddPicker.Value.Date
                dsNewRow.Item(7) = Val(AvalableAddTextBox.Text)
                dsNewRow.Item(8) = Val(PriceAddTextBox.Text)

                Main.ds.Tables("BookTable").Rows.Add(dsNewRow)
                Main.BookList.DataSource = Main.ds
                Main.da.Update(Main.ds, "BookTable")
                Me.Close()
                Main.Enabled = True
                Main.Opacity = 1
                Main.BringToFront()

            Else
                MessageBox.Show("This Book is already Present in the inventory. For Changing the Quantity go to Edit Book")
            End If


        Else
            MessageBox.Show("Please Enter all The Fields")
        End If

    End Sub

    Private Sub AddBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub isbnAddTextBox_TextChanged(sender As Object, e As EventArgs) Handles isbnAddTextBox.TextChanged
        If Not IsNumeric(isbnAddTextBox.Text) Then
            If isbnAddTextBox.Text.Length > 0 Then
                isbnAddTextBox.Text = isbnAddTextBox.Text.Remove(isbnAddTextBox.Text.Length - 1)

            Else
                isbnAddTextBox.Text = String.Empty

            End If
            MessageBox.Show("Enter Numbers Only")
            
        End If
    End Sub

    Private Sub AvalableAddTextBox_TextChanged(sender As Object, e As EventArgs) Handles AvalableAddTextBox.TextChanged
        If Not IsNumeric(AvalableAddTextBox.Text) Then
            If AvalableAddTextBox.Text.Length > 0 Then
                AvalableAddTextBox.Text = AvalableAddTextBox.Text.Remove(AvalableAddTextBox.Text.Length - 1)

            Else
                AvalableAddTextBox.Text = String.Empty

            End If
            MessageBox.Show("Enter Numbers Only")

        End If
    End Sub

    Private Sub PriceAddTextBox_TextChanged(sender As Object, e As EventArgs) Handles PriceAddTextBox.TextChanged
        If Not IsNumeric(PriceAddTextBox.Text) Then
            If PriceAddTextBox.Text.Length > 0 Then
                PriceAddTextBox.Text = PriceAddTextBox.Text.Remove(PriceAddTextBox.Text.Length - 1)

            Else
                PriceAddTextBox.Text = String.Empty

            End If
            MessageBox.Show("Enter Numbers Only")

        End If
    End Sub
End Class