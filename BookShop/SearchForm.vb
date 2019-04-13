Imports System.Data.OleDb

Public Class SearchForm
    Private Sub CloseSearchFormButton_Click(sender As Object, e As EventArgs) Handles CloseSearchFormButton.Click
        Main.Enabled = True
        Main.Opacity = 1
        Main.BringToFront()
        Me.Close()

    End Sub

    Private Sub SearchFormTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchFormTextBox.TextChanged
        If DomainSearchFormComboBox.Text <> String.Empty Then
            DataGridView1.DataSource = ""
            Dim dat As New OleDbDataAdapter("SELECT * FROM BookData WHERE " & DomainSearchFormComboBox.Text & " = ?", Main.con)

            ' OleDb doesn't use named parameters, so the parameter name doesn't matter here:
            dat.SelectCommand.Parameters.AddWithValue(DomainSearchFormComboBox.Text, SearchFormTextBox.Text)

            Dim dst As New DataSet()

            If dat.Fill(dst, "BookTable") Then
                Dim view As DataView = dst.Tables(0).DefaultView
                DataGridView1.DataSource = view
            End If

        Else
            MessageBox.Show("No Domain is selected")
            SearchFormTextBox.Clear()

        End If
    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DomainSearchFormComboBox.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub DomainSearchFormComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DomainSearchFormComboBox.SelectedIndexChanged
        DataGridView1.DataSource = ""
    End Sub

    Private Sub SelectSearchFormButton_Click(sender As Object, e As EventArgs) Handles SelectSearchFormButton.Click
        Dim CurrentSearchRow As Integer
        CurrentSearchRow = DataGridView1.CurrentRow.Index

        Main.BookList.ClearSelection()

        For Each SearchRow As DataGridViewRow In Main.BookList.Rows
            If DataGridView1.Item(0, CurrentSearchRow).Value = Main.BookList.Rows(SearchRow.Index).Cells(0).Value Then
                Main.BookList.Rows(SearchRow.Index).Selected = True

            End If
        Next

        Main.Enabled = True
        Main.Opacity = 1
        Main.BringToFront()
        Me.Close()

    End Sub
End Class