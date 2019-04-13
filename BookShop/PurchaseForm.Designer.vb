<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseForm
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
        Me.PurchaseList = New System.Windows.Forms.DataGridView()
        Me.PurchaseFormButton = New System.Windows.Forms.Button()
        Me.ClosePurchaseFormButton = New System.Windows.Forms.Button()
        Me.DeletePurchaseFormButton = New System.Windows.Forms.Button()
        Me.ClearPurchaseFormButton = New System.Windows.Forms.Button()
        Me.TotalPayLable = New System.Windows.Forms.Label()
        Me.TotalPayTextBox = New System.Windows.Forms.TextBox()
        Me.PayedPurchaseFormButton = New System.Windows.Forms.Button()
        CType(Me.PurchaseList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseList
        '
        Me.PurchaseList.AllowUserToAddRows = False
        Me.PurchaseList.AllowUserToDeleteRows = False
        Me.PurchaseList.BackgroundColor = System.Drawing.Color.White
        Me.PurchaseList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PurchaseList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.PurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseList.Location = New System.Drawing.Point(12, 12)
        Me.PurchaseList.Name = "PurchaseList"
        Me.PurchaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PurchaseList.Size = New System.Drawing.Size(776, 330)
        Me.PurchaseList.TabIndex = 0
        '
        'PurchaseFormButton
        '
        Me.PurchaseFormButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseFormButton.Location = New System.Drawing.Point(12, 392)
        Me.PurchaseFormButton.Name = "PurchaseFormButton"
        Me.PurchaseFormButton.Size = New System.Drawing.Size(152, 46)
        Me.PurchaseFormButton.TabIndex = 1
        Me.PurchaseFormButton.Text = "Total"
        Me.PurchaseFormButton.UseVisualStyleBackColor = True
        '
        'ClosePurchaseFormButton
        '
        Me.ClosePurchaseFormButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClosePurchaseFormButton.Location = New System.Drawing.Point(636, 392)
        Me.ClosePurchaseFormButton.Name = "ClosePurchaseFormButton"
        Me.ClosePurchaseFormButton.Size = New System.Drawing.Size(152, 46)
        Me.ClosePurchaseFormButton.TabIndex = 2
        Me.ClosePurchaseFormButton.Text = "Close"
        Me.ClosePurchaseFormButton.UseVisualStyleBackColor = True
        '
        'DeletePurchaseFormButton
        '
        Me.DeletePurchaseFormButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeletePurchaseFormButton.Location = New System.Drawing.Point(428, 392)
        Me.DeletePurchaseFormButton.Name = "DeletePurchaseFormButton"
        Me.DeletePurchaseFormButton.Size = New System.Drawing.Size(152, 46)
        Me.DeletePurchaseFormButton.TabIndex = 3
        Me.DeletePurchaseFormButton.Text = "Delete a Book"
        Me.DeletePurchaseFormButton.UseVisualStyleBackColor = True
        '
        'ClearPurchaseFormButton
        '
        Me.ClearPurchaseFormButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearPurchaseFormButton.Location = New System.Drawing.Point(220, 392)
        Me.ClearPurchaseFormButton.Name = "ClearPurchaseFormButton"
        Me.ClearPurchaseFormButton.Size = New System.Drawing.Size(152, 46)
        Me.ClearPurchaseFormButton.TabIndex = 4
        Me.ClearPurchaseFormButton.Text = "Clear"
        Me.ClearPurchaseFormButton.UseVisualStyleBackColor = True
        '
        'TotalPayLable
        '
        Me.TotalPayLable.AutoSize = True
        Me.TotalPayLable.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPayLable.Location = New System.Drawing.Point(601, 356)
        Me.TotalPayLable.Name = "TotalPayLable"
        Me.TotalPayLable.Size = New System.Drawing.Size(81, 20)
        Me.TotalPayLable.TabIndex = 5
        Me.TotalPayLable.Text = "Total Pay"
        '
        'TotalPayTextBox
        '
        Me.TotalPayTextBox.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPayTextBox.Location = New System.Drawing.Point(688, 353)
        Me.TotalPayTextBox.Name = "TotalPayTextBox"
        Me.TotalPayTextBox.ReadOnly = True
        Me.TotalPayTextBox.Size = New System.Drawing.Size(100, 27)
        Me.TotalPayTextBox.TabIndex = 6
        '
        'PayedPurchaseFormButton
        '
        Me.PayedPurchaseFormButton.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayedPurchaseFormButton.Location = New System.Drawing.Point(12, 348)
        Me.PayedPurchaseFormButton.Name = "PayedPurchaseFormButton"
        Me.PayedPurchaseFormButton.Size = New System.Drawing.Size(568, 38)
        Me.PayedPurchaseFormButton.TabIndex = 7
        Me.PayedPurchaseFormButton.Text = "Complete Payment"
        Me.PayedPurchaseFormButton.UseVisualStyleBackColor = True
        Me.PayedPurchaseFormButton.Visible = False
        '
        'PurchaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PayedPurchaseFormButton)
        Me.Controls.Add(Me.TotalPayTextBox)
        Me.Controls.Add(Me.TotalPayLable)
        Me.Controls.Add(Me.ClearPurchaseFormButton)
        Me.Controls.Add(Me.DeletePurchaseFormButton)
        Me.Controls.Add(Me.ClosePurchaseFormButton)
        Me.Controls.Add(Me.PurchaseFormButton)
        Me.Controls.Add(Me.PurchaseList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PurchaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Purchasing Books"
        CType(Me.PurchaseList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PurchaseList As DataGridView
    Friend WithEvents PurchaseFormButton As Button
    Friend WithEvents ClosePurchaseFormButton As Button
    Friend WithEvents DeletePurchaseFormButton As Button
    Friend WithEvents ClearPurchaseFormButton As Button
    Friend WithEvents TotalPayLable As Label
    Friend WithEvents TotalPayTextBox As TextBox
    Friend WithEvents PayedPurchaseFormButton As Button
End Class
