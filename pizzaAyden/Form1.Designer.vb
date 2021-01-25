<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblPizzaOrder = New System.Windows.Forms.Label()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.lblTopping = New System.Windows.Forms.Label()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.txtTopping = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPizzaOrder
        '
        Me.lblPizzaOrder.AutoSize = True
        Me.lblPizzaOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaOrder.Location = New System.Drawing.Point(0, 0)
        Me.lblPizzaOrder.Name = "lblPizzaOrder"
        Me.lblPizzaOrder.Size = New System.Drawing.Size(157, 31)
        Me.lblPizzaOrder.TabIndex = 0
        Me.lblPizzaOrder.Text = "Pizza Order"
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeople.Location = New System.Drawing.Point(12, 100)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(269, 20)
        Me.lblPeople.TabIndex = 1
        Me.lblPeople.Text = "How Many People Are You Feeding?"
        '
        'lblTopping
        '
        Me.lblTopping.AutoSize = True
        Me.lblTopping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopping.Location = New System.Drawing.Point(12, 163)
        Me.lblTopping.Name = "lblTopping"
        Me.lblTopping.Size = New System.Drawing.Size(261, 20)
        Me.lblTopping.TabIndex = 2
        Me.lblTopping.Text = "How Many Toppings Do You Want?"
        '
        'txtPeople
        '
        Me.txtPeople.Location = New System.Drawing.Point(336, 102)
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.Size = New System.Drawing.Size(100, 20)
        Me.txtPeople.TabIndex = 4
        '
        'txtTopping
        '
        Me.txtTopping.Location = New System.Drawing.Point(336, 165)
        Me.txtTopping.Name = "txtTopping"
        Me.txtTopping.Size = New System.Drawing.Size(100, 20)
        Me.txtTopping.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(613, 88)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(149, 32)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Price"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(609, 165)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(83, 24)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price: $0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 271)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTopping)
        Me.Controls.Add(Me.txtPeople)
        Me.Controls.Add(Me.lblTopping)
        Me.Controls.Add(Me.lblPeople)
        Me.Controls.Add(Me.lblPizzaOrder)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPizzaOrder As System.Windows.Forms.Label
    Friend WithEvents lblPeople As System.Windows.Forms.Label
    Friend WithEvents lblTopping As System.Windows.Forms.Label
    Friend WithEvents txtPeople As System.Windows.Forms.TextBox
    Friend WithEvents txtTopping As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label

End Class
