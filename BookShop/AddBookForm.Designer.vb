<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookForm
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
        Me.AddCloseButton = New System.Windows.Forms.Button()
        Me.EditBookButton = New System.Windows.Forms.Button()
        Me.DateLable = New System.Windows.Forms.Label()
        Me.DateAddPicker = New System.Windows.Forms.DateTimePicker()
        Me.PriceLable = New System.Windows.Forms.Label()
        Me.PriceAddTextBox = New System.Windows.Forms.TextBox()
        Me.AvalableLable = New System.Windows.Forms.Label()
        Me.AvalableAddTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectLable = New System.Windows.Forms.Label()
        Me.SubjectAddTextBox = New System.Windows.Forms.TextBox()
        Me.EditionLable = New System.Windows.Forms.Label()
        Me.EditionAddTextBox = New System.Windows.Forms.TextBox()
        Me.PublicationLable = New System.Windows.Forms.Label()
        Me.PublicationAddTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorLable = New System.Windows.Forms.Label()
        Me.AuthorAddTextBox = New System.Windows.Forms.TextBox()
        Me.BookNameLable = New System.Windows.Forms.Label()
        Me.BookNameAddTextBox = New System.Windows.Forms.TextBox()
        Me.isbnLable = New System.Windows.Forms.Label()
        Me.isbnAddTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddCloseButton
        '
        Me.AddCloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddCloseButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCloseButton.Location = New System.Drawing.Point(572, 359)
        Me.AddCloseButton.Name = "AddCloseButton"
        Me.AddCloseButton.Size = New System.Drawing.Size(156, 48)
        Me.AddCloseButton.TabIndex = 40
        Me.AddCloseButton.Text = "Close"
        Me.AddCloseButton.UseVisualStyleBackColor = True
        '
        'EditBookButton
        '
        Me.EditBookButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EditBookButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBookButton.Location = New System.Drawing.Point(75, 359)
        Me.EditBookButton.Name = "EditBookButton"
        Me.EditBookButton.Size = New System.Drawing.Size(156, 48)
        Me.EditBookButton.TabIndex = 39
        Me.EditBookButton.Text = "Add"
        Me.EditBookButton.UseVisualStyleBackColor = True
        '
        'DateLable
        '
        Me.DateLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLable.AutoSize = True
        Me.DateLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLable.Location = New System.Drawing.Point(569, 259)
        Me.DateLable.Name = "DateLable"
        Me.DateLable.Size = New System.Drawing.Size(92, 20)
        Me.DateLable.TabIndex = 38
        Me.DateLable.Text = "Entry Date"
        '
        'DateAddPicker
        '
        Me.DateAddPicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateAddPicker.Location = New System.Drawing.Point(572, 289)
        Me.DateAddPicker.Name = "DateAddPicker"
        Me.DateAddPicker.Size = New System.Drawing.Size(187, 20)
        Me.DateAddPicker.TabIndex = 37
        '
        'PriceLable
        '
        Me.PriceLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PriceLable.AutoSize = True
        Me.PriceLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLable.Location = New System.Drawing.Point(310, 259)
        Me.PriceLable.Name = "PriceLable"
        Me.PriceLable.Size = New System.Drawing.Size(47, 20)
        Me.PriceLable.TabIndex = 36
        Me.PriceLable.Text = "Price"
        '
        'PriceAddTextBox
        '
        Me.PriceAddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PriceAddTextBox.Location = New System.Drawing.Point(313, 289)
        Me.PriceAddTextBox.Name = "PriceAddTextBox"
        Me.PriceAddTextBox.Size = New System.Drawing.Size(187, 20)
        Me.PriceAddTextBox.TabIndex = 35
        '
        'AvalableLable
        '
        Me.AvalableLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AvalableLable.AutoSize = True
        Me.AvalableLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvalableLable.Location = New System.Drawing.Point(41, 259)
        Me.AvalableLable.Name = "AvalableLable"
        Me.AvalableLable.Size = New System.Drawing.Size(75, 20)
        Me.AvalableLable.TabIndex = 34
        Me.AvalableLable.Text = "Avalable"
        '
        'AvalableAddTextBox
        '
        Me.AvalableAddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AvalableAddTextBox.Location = New System.Drawing.Point(44, 289)
        Me.AvalableAddTextBox.Name = "AvalableAddTextBox"
        Me.AvalableAddTextBox.Size = New System.Drawing.Size(187, 20)
        Me.AvalableAddTextBox.TabIndex = 33
        '
        'SubjectLable
        '
        Me.SubjectLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubjectLable.AutoSize = True
        Me.SubjectLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectLable.Location = New System.Drawing.Point(569, 153)
        Me.SubjectLable.Name = "SubjectLable"
        Me.SubjectLable.Size = New System.Drawing.Size(64, 20)
        Me.SubjectLable.TabIndex = 32
        Me.SubjectLable.Text = "Subject"
        '
        'SubjectAddTextBox
        '
        Me.SubjectAddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubjectAddTextBox.Location = New System.Drawing.Point(572, 183)
        Me.SubjectAddTextBox.Name = "SubjectAddTextBox"
        Me.SubjectAddTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SubjectAddTextBox.TabIndex = 31
        '
        'EditionLable
        '
        Me.EditionLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.EditionLable.AutoSize = True
        Me.EditionLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditionLable.Location = New System.Drawing.Point(310, 153)
        Me.EditionLable.Name = "EditionLable"
        Me.EditionLable.Size = New System.Drawing.Size(64, 20)
        Me.EditionLable.TabIndex = 30
        Me.EditionLable.Text = "Edition"
        '
        'EditionAddTextBox
        '
        Me.EditionAddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.EditionAddTextBox.Location = New System.Drawing.Point(313, 183)
        Me.EditionAddTextBox.Name = "EditionAddTextBox"
        Me.EditionAddTextBox.Size = New System.Drawing.Size(187, 20)
        Me.EditionAddTextBox.TabIndex = 29
        '
        'PublicationLable
        '
        Me.PublicationLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PublicationLable.AutoSize = True
        Me.PublicationLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicationLable.Location = New System.Drawing.Point(41, 153)
        Me.PublicationLable.Name = "PublicationLable"
        Me.PublicationLable.Size = New System.Drawing.Size(94, 20)
        Me.PublicationLable.TabIndex = 28
        Me.PublicationLable.Text = "Publication"
        '
        'PublicationAddTextBox
        '
        Me.PublicationAddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PublicationAddTextBox.Location = New System.Drawing.Point(44, 183)
        Me.PublicationAddTextBox.Name = "PublicationAddTextBox"
        Me.PublicationAddTextBox.Size = New System.Drawing.Size(187, 20)
        Me.PublicationAddTextBox.TabIndex = 27
        '
        'AuthorLable
        '
        Me.AuthorLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorLable.AutoSize = True
        Me.AuthorLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLable.Location = New System.Drawing.Point(569, 43)
        Me.AuthorLable.Name = "AuthorLable"
        Me.AuthorLable.Size = New System.Drawing.Size(110, 20)
        Me.AuthorLable.TabIndex = 26
        Me.AuthorLable.Text = "Author Name"
        '
        'AuthorAddTextBox
        '
        Me.AuthorAddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorAddTextBox.Location = New System.Drawing.Point(572, 73)
        Me.AuthorAddTextBox.Name = "AuthorAddTextBox"
        Me.AuthorAddTextBox.Size = New System.Drawing.Size(187, 20)
        Me.AuthorAddTextBox.TabIndex = 25
        '
        'BookNameLable
        '
        Me.BookNameLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BookNameLable.AutoSize = True
        Me.BookNameLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookNameLable.Location = New System.Drawing.Point(310, 43)
        Me.BookNameLable.Name = "BookNameLable"
        Me.BookNameLable.Size = New System.Drawing.Size(94, 20)
        Me.BookNameLable.TabIndex = 24
        Me.BookNameLable.Text = "Book Name"
        '
        'BookNameAddTextBox
        '
        Me.BookNameAddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BookNameAddTextBox.Location = New System.Drawing.Point(313, 73)
        Me.BookNameAddTextBox.Name = "BookNameAddTextBox"
        Me.BookNameAddTextBox.Size = New System.Drawing.Size(187, 20)
        Me.BookNameAddTextBox.TabIndex = 23
        '
        'isbnLable
        '
        Me.isbnLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.isbnLable.AutoSize = True
        Me.isbnLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnLable.Location = New System.Drawing.Point(41, 43)
        Me.isbnLable.Name = "isbnLable"
        Me.isbnLable.Size = New System.Drawing.Size(51, 20)
        Me.isbnLable.TabIndex = 22
        Me.isbnLable.Text = "ISBN"
        '
        'isbnAddTextBox
        '
        Me.isbnAddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.isbnAddTextBox.Location = New System.Drawing.Point(44, 73)
        Me.isbnAddTextBox.Name = "isbnAddTextBox"
        Me.isbnAddTextBox.Size = New System.Drawing.Size(187, 20)
        Me.isbnAddTextBox.TabIndex = 21
        '
        'AddBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddCloseButton)
        Me.Controls.Add(Me.EditBookButton)
        Me.Controls.Add(Me.DateLable)
        Me.Controls.Add(Me.DateAddPicker)
        Me.Controls.Add(Me.PriceLable)
        Me.Controls.Add(Me.PriceAddTextBox)
        Me.Controls.Add(Me.AvalableLable)
        Me.Controls.Add(Me.AvalableAddTextBox)
        Me.Controls.Add(Me.SubjectLable)
        Me.Controls.Add(Me.SubjectAddTextBox)
        Me.Controls.Add(Me.EditionLable)
        Me.Controls.Add(Me.EditionAddTextBox)
        Me.Controls.Add(Me.PublicationLable)
        Me.Controls.Add(Me.PublicationAddTextBox)
        Me.Controls.Add(Me.AuthorLable)
        Me.Controls.Add(Me.AuthorAddTextBox)
        Me.Controls.Add(Me.BookNameLable)
        Me.Controls.Add(Me.BookNameAddTextBox)
        Me.Controls.Add(Me.isbnLable)
        Me.Controls.Add(Me.isbnAddTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "AddBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddCloseButton As Button
    Friend WithEvents EditBookButton As Button
    Friend WithEvents DateLable As Label
    Friend WithEvents DateAddPicker As DateTimePicker
    Friend WithEvents PriceLable As Label
    Friend WithEvents PriceAddTextBox As TextBox
    Friend WithEvents AvalableLable As Label
    Friend WithEvents AvalableAddTextBox As TextBox
    Friend WithEvents SubjectLable As Label
    Friend WithEvents SubjectAddTextBox As TextBox
    Friend WithEvents EditionLable As Label
    Friend WithEvents EditionAddTextBox As TextBox
    Friend WithEvents PublicationLable As Label
    Friend WithEvents PublicationAddTextBox As TextBox
    Friend WithEvents AuthorLable As Label
    Friend WithEvents AuthorAddTextBox As TextBox
    Friend WithEvents BookNameLable As Label
    Friend WithEvents BookNameAddTextBox As TextBox
    Friend WithEvents isbnLable As Label
    Friend WithEvents isbnAddTextBox As TextBox
End Class
