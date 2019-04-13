<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Me.SearchFormTextBox = New System.Windows.Forms.TextBox()
        Me.DomainSearchFormComboBox = New System.Windows.Forms.ComboBox()
        Me.DomainSearchFormLable = New System.Windows.Forms.Label()
        Me.SearchFormLable = New System.Windows.Forms.Label()
        Me.SelectSearchFormButton = New System.Windows.Forms.Button()
        Me.CloseSearchFormButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchFormTextBox
        '
        Me.SearchFormTextBox.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchFormTextBox.Location = New System.Drawing.Point(78, 44)
        Me.SearchFormTextBox.Name = "SearchFormTextBox"
        Me.SearchFormTextBox.Size = New System.Drawing.Size(435, 26)
        Me.SearchFormTextBox.TabIndex = 1
        '
        'DomainSearchFormComboBox
        '
        Me.DomainSearchFormComboBox.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainSearchFormComboBox.FormattingEnabled = True
        Me.DomainSearchFormComboBox.Items.AddRange(New Object() {"isbn", "Name", "Author", "Publication", "Edition", "Subject"})
        Me.DomainSearchFormComboBox.Location = New System.Drawing.Point(610, 44)
        Me.DomainSearchFormComboBox.Name = "DomainSearchFormComboBox"
        Me.DomainSearchFormComboBox.Size = New System.Drawing.Size(178, 26)
        Me.DomainSearchFormComboBox.TabIndex = 2
        Me.DomainSearchFormComboBox.Text = "isbn"
        '
        'DomainSearchFormLable
        '
        Me.DomainSearchFormLable.AutoSize = True
        Me.DomainSearchFormLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainSearchFormLable.Location = New System.Drawing.Point(537, 46)
        Me.DomainSearchFormLable.Name = "DomainSearchFormLable"
        Me.DomainSearchFormLable.Size = New System.Drawing.Size(67, 20)
        Me.DomainSearchFormLable.TabIndex = 3
        Me.DomainSearchFormLable.Text = "Domain"
        '
        'SearchFormLable
        '
        Me.SearchFormLable.AutoSize = True
        Me.SearchFormLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchFormLable.Location = New System.Drawing.Point(12, 46)
        Me.SearchFormLable.Name = "SearchFormLable"
        Me.SearchFormLable.Size = New System.Drawing.Size(60, 20)
        Me.SearchFormLable.TabIndex = 4
        Me.SearchFormLable.Text = "Search"
        '
        'SelectSearchFormButton
        '
        Me.SelectSearchFormButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectSearchFormButton.Location = New System.Drawing.Point(12, 403)
        Me.SelectSearchFormButton.Name = "SelectSearchFormButton"
        Me.SelectSearchFormButton.Size = New System.Drawing.Size(172, 35)
        Me.SelectSearchFormButton.TabIndex = 5
        Me.SelectSearchFormButton.Text = "Select"
        Me.SelectSearchFormButton.UseVisualStyleBackColor = True
        '
        'CloseSearchFormButton
        '
        Me.CloseSearchFormButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseSearchFormButton.Location = New System.Drawing.Point(616, 403)
        Me.CloseSearchFormButton.Name = "CloseSearchFormButton"
        Me.CloseSearchFormButton.Size = New System.Drawing.Size(172, 35)
        Me.CloseSearchFormButton.TabIndex = 6
        Me.CloseSearchFormButton.Text = "Close"
        Me.CloseSearchFormButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(772, 299)
        Me.DataGridView1.TabIndex = 7
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CloseSearchFormButton)
        Me.Controls.Add(Me.SelectSearchFormButton)
        Me.Controls.Add(Me.SearchFormLable)
        Me.Controls.Add(Me.DomainSearchFormLable)
        Me.Controls.Add(Me.DomainSearchFormComboBox)
        Me.Controls.Add(Me.SearchFormTextBox)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SearchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchFormTextBox As TextBox
    Friend WithEvents DomainSearchFormComboBox As ComboBox
    Friend WithEvents DomainSearchFormLable As Label
    Friend WithEvents SearchFormLable As Label
    Friend WithEvents SelectSearchFormButton As Button
    Friend WithEvents CloseSearchFormButton As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
