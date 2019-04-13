<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.BookList = New System.Windows.Forms.DataGridView()
        Me.EditBook = New System.Windows.Forms.Button()
        Me.RemoveBook = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.AddPurchaseButton = New System.Windows.Forms.Button()
        Me.AddBook = New System.Windows.Forms.Button()
        Me.BusketButton = New System.Windows.Forms.Button()
        Me.MainHeadingLable = New System.Windows.Forms.Label()
        CType(Me.BookList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookList
        '
        Me.BookList.AllowUserToAddRows = False
        Me.BookList.AllowUserToDeleteRows = False
        Me.BookList.BackgroundColor = System.Drawing.Color.White
        Me.BookList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookList.Location = New System.Drawing.Point(223, 67)
        Me.BookList.Name = "BookList"
        Me.BookList.ReadOnly = True
        Me.BookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BookList.Size = New System.Drawing.Size(942, 509)
        Me.BookList.TabIndex = 0
        '
        'EditBook
        '
        Me.EditBook.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBook.Location = New System.Drawing.Point(12, 180)
        Me.EditBook.Name = "EditBook"
        Me.EditBook.Size = New System.Drawing.Size(191, 54)
        Me.EditBook.TabIndex = 1
        Me.EditBook.Text = "Edit Book"
        Me.EditBook.UseVisualStyleBackColor = True
        '
        'RemoveBook
        '
        Me.RemoveBook.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBook.Location = New System.Drawing.Point(12, 293)
        Me.RemoveBook.Name = "RemoveBook"
        Me.RemoveBook.Size = New System.Drawing.Size(191, 54)
        Me.RemoveBook.TabIndex = 2
        Me.RemoveBook.Text = "Remove a Book"
        Me.RemoveBook.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(12, 519)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(191, 54)
        Me.SearchButton.TabIndex = 4
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'AddPurchaseButton
        '
        Me.AddPurchaseButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPurchaseButton.Location = New System.Drawing.Point(12, 406)
        Me.AddPurchaseButton.Name = "AddPurchaseButton"
        Me.AddPurchaseButton.Size = New System.Drawing.Size(191, 54)
        Me.AddPurchaseButton.TabIndex = 3
        Me.AddPurchaseButton.Text = "Add to Purchase"
        Me.AddPurchaseButton.UseVisualStyleBackColor = True
        '
        'AddBook
        '
        Me.AddBook.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBook.Location = New System.Drawing.Point(12, 67)
        Me.AddBook.Name = "AddBook"
        Me.AddBook.Size = New System.Drawing.Size(191, 54)
        Me.AddBook.TabIndex = 5
        Me.AddBook.Text = "Add Book"
        Me.AddBook.UseVisualStyleBackColor = True
        '
        'BusketButton
        '
        Me.BusketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusketButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusketButton.Location = New System.Drawing.Point(1064, 12)
        Me.BusketButton.Name = "BusketButton"
        Me.BusketButton.Size = New System.Drawing.Size(101, 49)
        Me.BusketButton.TabIndex = 6
        Me.BusketButton.Text = "Basket=  0"
        Me.BusketButton.UseVisualStyleBackColor = True
        '
        'MainHeadingLable
        '
        Me.MainHeadingLable.AutoSize = True
        Me.MainHeadingLable.Font = New System.Drawing.Font("Century Schoolbook", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainHeadingLable.Location = New System.Drawing.Point(391, 9)
        Me.MainHeadingLable.Name = "MainHeadingLable"
        Me.MainHeadingLable.Size = New System.Drawing.Size(395, 37)
        Me.MainHeadingLable.TabIndex = 7
        Me.MainHeadingLable.Text = "BookShop Automation"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1177, 601)
        Me.Controls.Add(Me.MainHeadingLable)
        Me.Controls.Add(Me.BusketButton)
        Me.Controls.Add(Me.AddBook)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.AddPurchaseButton)
        Me.Controls.Add(Me.RemoveBook)
        Me.Controls.Add(Me.EditBook)
        Me.Controls.Add(Me.BookList)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        CType(Me.BookList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookList As DataGridView
    Friend WithEvents EditBook As Button
    Friend WithEvents RemoveBook As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents AddPurchaseButton As Button
    Friend WithEvents AddBook As Button
    Friend WithEvents BusketButton As Button
    Friend WithEvents MainHeadingLable As Label
End Class
