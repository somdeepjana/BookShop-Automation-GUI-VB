<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBookForm
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
        Me.isbnEditTextBox = New System.Windows.Forms.TextBox()
        Me.isbnLable = New System.Windows.Forms.Label()
        Me.BookNameLable = New System.Windows.Forms.Label()
        Me.BookNameEditTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorLable = New System.Windows.Forms.Label()
        Me.AuthorEditTextBox = New System.Windows.Forms.TextBox()
        Me.PublicationLable = New System.Windows.Forms.Label()
        Me.PublicationEditTextBox = New System.Windows.Forms.TextBox()
        Me.EditionLable = New System.Windows.Forms.Label()
        Me.EditionEditTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectLable = New System.Windows.Forms.Label()
        Me.SubjectEditTextBox = New System.Windows.Forms.TextBox()
        Me.AvalableLable = New System.Windows.Forms.Label()
        Me.AvalableEditTextBox = New System.Windows.Forms.TextBox()
        Me.PriceLable = New System.Windows.Forms.Label()
        Me.PriceEditTextBox = New System.Windows.Forms.TextBox()
        Me.DateEditPicker = New System.Windows.Forms.DateTimePicker()
        Me.DateLable = New System.Windows.Forms.Label()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.EditCloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'isbnEditTextBox
        '
        Me.isbnEditTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.isbnEditTextBox.Location = New System.Drawing.Point(15, 69)
        Me.isbnEditTextBox.Name = "isbnEditTextBox"
        Me.isbnEditTextBox.Size = New System.Drawing.Size(187, 20)
        Me.isbnEditTextBox.TabIndex = 0
        '
        'isbnLable
        '
        Me.isbnLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.isbnLable.AutoSize = True
        Me.isbnLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnLable.Location = New System.Drawing.Point(12, 39)
        Me.isbnLable.Name = "isbnLable"
        Me.isbnLable.Size = New System.Drawing.Size(51, 20)
        Me.isbnLable.TabIndex = 1
        Me.isbnLable.Text = "ISBN"
        '
        'BookNameLable
        '
        Me.BookNameLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BookNameLable.AutoSize = True
        Me.BookNameLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookNameLable.Location = New System.Drawing.Point(281, 39)
        Me.BookNameLable.Name = "BookNameLable"
        Me.BookNameLable.Size = New System.Drawing.Size(94, 20)
        Me.BookNameLable.TabIndex = 3
        Me.BookNameLable.Text = "Book Name"
        '
        'BookNameEditTextBox
        '
        Me.BookNameEditTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BookNameEditTextBox.Location = New System.Drawing.Point(284, 69)
        Me.BookNameEditTextBox.Name = "BookNameEditTextBox"
        Me.BookNameEditTextBox.Size = New System.Drawing.Size(187, 20)
        Me.BookNameEditTextBox.TabIndex = 2
        '
        'AuthorLable
        '
        Me.AuthorLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorLable.AutoSize = True
        Me.AuthorLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLable.Location = New System.Drawing.Point(540, 39)
        Me.AuthorLable.Name = "AuthorLable"
        Me.AuthorLable.Size = New System.Drawing.Size(110, 20)
        Me.AuthorLable.TabIndex = 5
        Me.AuthorLable.Text = "Author Name"
        '
        'AuthorEditTextBox
        '
        Me.AuthorEditTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorEditTextBox.Location = New System.Drawing.Point(543, 69)
        Me.AuthorEditTextBox.Name = "AuthorEditTextBox"
        Me.AuthorEditTextBox.Size = New System.Drawing.Size(187, 20)
        Me.AuthorEditTextBox.TabIndex = 4
        '
        'PublicationLable
        '
        Me.PublicationLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PublicationLable.AutoSize = True
        Me.PublicationLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicationLable.Location = New System.Drawing.Point(12, 149)
        Me.PublicationLable.Name = "PublicationLable"
        Me.PublicationLable.Size = New System.Drawing.Size(94, 20)
        Me.PublicationLable.TabIndex = 7
        Me.PublicationLable.Text = "Publication"
        '
        'PublicationEditTextBox
        '
        Me.PublicationEditTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PublicationEditTextBox.Location = New System.Drawing.Point(15, 179)
        Me.PublicationEditTextBox.Name = "PublicationEditTextBox"
        Me.PublicationEditTextBox.Size = New System.Drawing.Size(187, 20)
        Me.PublicationEditTextBox.TabIndex = 6
        '
        'EditionLable
        '
        Me.EditionLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.EditionLable.AutoSize = True
        Me.EditionLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditionLable.Location = New System.Drawing.Point(281, 149)
        Me.EditionLable.Name = "EditionLable"
        Me.EditionLable.Size = New System.Drawing.Size(64, 20)
        Me.EditionLable.TabIndex = 9
        Me.EditionLable.Text = "Edition"
        '
        'EditionEditTextBox
        '
        Me.EditionEditTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.EditionEditTextBox.Location = New System.Drawing.Point(284, 179)
        Me.EditionEditTextBox.Name = "EditionEditTextBox"
        Me.EditionEditTextBox.Size = New System.Drawing.Size(187, 20)
        Me.EditionEditTextBox.TabIndex = 8
        '
        'SubjectLable
        '
        Me.SubjectLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubjectLable.AutoSize = True
        Me.SubjectLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectLable.Location = New System.Drawing.Point(540, 149)
        Me.SubjectLable.Name = "SubjectLable"
        Me.SubjectLable.Size = New System.Drawing.Size(64, 20)
        Me.SubjectLable.TabIndex = 11
        Me.SubjectLable.Text = "Subject"
        '
        'SubjectEditTextBox
        '
        Me.SubjectEditTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubjectEditTextBox.Location = New System.Drawing.Point(543, 179)
        Me.SubjectEditTextBox.Name = "SubjectEditTextBox"
        Me.SubjectEditTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SubjectEditTextBox.TabIndex = 10
        '
        'AvalableLable
        '
        Me.AvalableLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AvalableLable.AutoSize = True
        Me.AvalableLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvalableLable.Location = New System.Drawing.Point(12, 255)
        Me.AvalableLable.Name = "AvalableLable"
        Me.AvalableLable.Size = New System.Drawing.Size(75, 20)
        Me.AvalableLable.TabIndex = 13
        Me.AvalableLable.Text = "Avalable"
        '
        'AvalableEditTextBox
        '
        Me.AvalableEditTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AvalableEditTextBox.Location = New System.Drawing.Point(15, 285)
        Me.AvalableEditTextBox.Name = "AvalableEditTextBox"
        Me.AvalableEditTextBox.Size = New System.Drawing.Size(187, 20)
        Me.AvalableEditTextBox.TabIndex = 12
        '
        'PriceLable
        '
        Me.PriceLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PriceLable.AutoSize = True
        Me.PriceLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLable.Location = New System.Drawing.Point(281, 255)
        Me.PriceLable.Name = "PriceLable"
        Me.PriceLable.Size = New System.Drawing.Size(47, 20)
        Me.PriceLable.TabIndex = 15
        Me.PriceLable.Text = "Price"
        '
        'PriceEditTextBox
        '
        Me.PriceEditTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PriceEditTextBox.Location = New System.Drawing.Point(284, 285)
        Me.PriceEditTextBox.Name = "PriceEditTextBox"
        Me.PriceEditTextBox.Size = New System.Drawing.Size(187, 20)
        Me.PriceEditTextBox.TabIndex = 14
        '
        'DateEditPicker
        '
        Me.DateEditPicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEditPicker.Location = New System.Drawing.Point(543, 285)
        Me.DateEditPicker.Name = "DateEditPicker"
        Me.DateEditPicker.Size = New System.Drawing.Size(187, 20)
        Me.DateEditPicker.TabIndex = 16
        '
        'DateLable
        '
        Me.DateLable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLable.AutoSize = True
        Me.DateLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLable.Location = New System.Drawing.Point(540, 255)
        Me.DateLable.Name = "DateLable"
        Me.DateLable.Size = New System.Drawing.Size(92, 20)
        Me.DateLable.TabIndex = 18
        Me.DateLable.Text = "Entry Date"
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EditSaveButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSaveButton.Location = New System.Drawing.Point(46, 355)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(156, 48)
        Me.EditSaveButton.TabIndex = 19
        Me.EditSaveButton.Text = "Save"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'EditCloseButton
        '
        Me.EditCloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditCloseButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCloseButton.Location = New System.Drawing.Point(543, 355)
        Me.EditCloseButton.Name = "EditCloseButton"
        Me.EditCloseButton.Size = New System.Drawing.Size(156, 48)
        Me.EditCloseButton.TabIndex = 20
        Me.EditCloseButton.Text = "Close"
        Me.EditCloseButton.UseVisualStyleBackColor = True
        '
        'EditBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(745, 437)
        Me.Controls.Add(Me.EditCloseButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.DateLable)
        Me.Controls.Add(Me.DateEditPicker)
        Me.Controls.Add(Me.PriceLable)
        Me.Controls.Add(Me.PriceEditTextBox)
        Me.Controls.Add(Me.AvalableLable)
        Me.Controls.Add(Me.AvalableEditTextBox)
        Me.Controls.Add(Me.SubjectLable)
        Me.Controls.Add(Me.SubjectEditTextBox)
        Me.Controls.Add(Me.EditionLable)
        Me.Controls.Add(Me.EditionEditTextBox)
        Me.Controls.Add(Me.PublicationLable)
        Me.Controls.Add(Me.PublicationEditTextBox)
        Me.Controls.Add(Me.AuthorLable)
        Me.Controls.Add(Me.AuthorEditTextBox)
        Me.Controls.Add(Me.BookNameLable)
        Me.Controls.Add(Me.BookNameEditTextBox)
        Me.Controls.Add(Me.isbnLable)
        Me.Controls.Add(Me.isbnEditTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "EditBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents isbnEditTextBox As TextBox
    Friend WithEvents isbnLable As Label
    Friend WithEvents BookNameLable As Label
    Friend WithEvents BookNameEditTextBox As TextBox
    Friend WithEvents AuthorLable As Label
    Friend WithEvents AuthorEditTextBox As TextBox
    Friend WithEvents PublicationLable As Label
    Friend WithEvents PublicationEditTextBox As TextBox
    Friend WithEvents EditionLable As Label
    Friend WithEvents EditionEditTextBox As TextBox
    Friend WithEvents SubjectLable As Label
    Friend WithEvents SubjectEditTextBox As TextBox
    Friend WithEvents AvalableLable As Label
    Friend WithEvents AvalableEditTextBox As TextBox
    Friend WithEvents PriceLable As Label
    Friend WithEvents PriceEditTextBox As TextBox
    Friend WithEvents DateEditPicker As DateTimePicker
    Friend WithEvents DateLable As Label
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents EditCloseButton As Button
End Class
