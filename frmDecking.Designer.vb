<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDecking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlImage = New Panel()
        lblHeading = New Label()
        lblFootage = New Label()
        txtNumberOfFootage = New TextBox()
        grpDeckingType = New GroupBox()
        radComposite = New RadioButton()
        radRedwood = New RadioButton()
        radLumber = New RadioButton()
        lblEstimateCost = New Label()
        btnCalcCost = New Button()
        btnClear = New Button()
        lblCost = New Label()
        grpDeckingType.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlImage
        ' 
        pnlImage.Dock = DockStyle.Right
        pnlImage.Location = New Point(462, 0)
        pnlImage.Name = "pnlImage"
        pnlImage.Size = New Size(338, 450)
        pnlImage.TabIndex = 0
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(27, 29)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(262, 25)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Decking Cost Calculator"
        ' 
        ' lblFootage
        ' 
        lblFootage.AutoSize = True
        lblFootage.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFootage.Location = New Point(90, 87)
        lblFootage.Name = "lblFootage"
        lblFootage.Size = New Size(116, 18)
        lblFootage.TabIndex = 2
        lblFootage.Text = "Square Footage:"
        ' 
        ' txtNumberOfFootage
        ' 
        txtNumberOfFootage.Location = New Point(212, 87)
        txtNumberOfFootage.Name = "txtNumberOfFootage"
        txtNumberOfFootage.Size = New Size(37, 23)
        txtNumberOfFootage.TabIndex = 3
        txtNumberOfFootage.TextAlign = HorizontalAlignment.Center
        ' 
        ' grpDeckingType
        ' 
        grpDeckingType.BackColor = Color.AliceBlue
        grpDeckingType.Controls.Add(radComposite)
        grpDeckingType.Controls.Add(radRedwood)
        grpDeckingType.Controls.Add(radLumber)
        grpDeckingType.Font = New Font("Goudy Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpDeckingType.ForeColor = Color.Coral
        grpDeckingType.Location = New Point(90, 140)
        grpDeckingType.Name = "grpDeckingType"
        grpDeckingType.Size = New Size(240, 100)
        grpDeckingType.TabIndex = 4
        grpDeckingType.TabStop = False
        grpDeckingType.Text = "Decking Type"
        ' 
        ' radComposite
        ' 
        radComposite.AutoSize = True
        radComposite.Location = New Point(11, 75)
        radComposite.Name = "radComposite"
        radComposite.Size = New Size(111, 27)
        radComposite.TabIndex = 2
        radComposite.TabStop = True
        radComposite.Text = "Composite"
        radComposite.UseVisualStyleBackColor = True
        ' 
        ' radRedwood
        ' 
        radRedwood.AutoSize = True
        radRedwood.Location = New Point(11, 50)
        radRedwood.Name = "radRedwood"
        radRedwood.Size = New Size(100, 27)
        radRedwood.TabIndex = 1
        radRedwood.TabStop = True
        radRedwood.Text = "Redwood"
        radRedwood.UseVisualStyleBackColor = True
        ' 
        ' radLumber
        ' 
        radLumber.AutoSize = True
        radLumber.Checked = True
        radLumber.Location = New Point(11, 22)
        radLumber.Name = "radLumber"
        radLumber.Size = New Size(219, 27)
        radLumber.TabIndex = 0
        radLumber.TabStop = True
        radLumber.Text = "Pressure Treated Lumber"
        radLumber.UseVisualStyleBackColor = True
        ' 
        ' lblEstimateCost
        ' 
        lblEstimateCost.AutoSize = True
        lblEstimateCost.Font = New Font("Tahoma", 11.25F)
        lblEstimateCost.Location = New Point(90, 311)
        lblEstimateCost.Name = "lblEstimateCost"
        lblEstimateCost.Size = New Size(103, 18)
        lblEstimateCost.TabIndex = 5
        lblEstimateCost.Text = "Cost Estimate:"
        ' 
        ' btnCalcCost
        ' 
        btnCalcCost.FlatStyle = FlatStyle.Popup
        btnCalcCost.Font = New Font("Tahoma", 11.25F)
        btnCalcCost.Location = New Point(90, 369)
        btnCalcCost.Name = "btnCalcCost"
        btnCalcCost.Size = New Size(125, 34)
        btnCalcCost.TabIndex = 6
        btnCalcCost.Text = "Calculate Cost"
        btnCalcCost.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Tahoma", 11.25F)
        btnClear.Location = New Point(258, 369)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(125, 34)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Tahoma", 11.25F)
        lblCost.Location = New Point(193, 311)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(37, 18)
        lblCost.TabIndex = 3
        lblCost.Text = "Cost"
        ' 
        ' frmDecking
        ' 
        AcceptButton = btnCalcCost
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = btnClear
        ClientSize = New Size(800, 450)
        Controls.Add(txtNumberOfFootage)
        Controls.Add(lblCost)
        Controls.Add(btnClear)
        Controls.Add(btnCalcCost)
        Controls.Add(lblEstimateCost)
        Controls.Add(grpDeckingType)
        Controls.Add(lblFootage)
        Controls.Add(lblHeading)
        Controls.Add(pnlImage)
        ForeColor = Color.Coral
        Name = "frmDecking"
        Text = "Decking Cost Calculator"
        grpDeckingType.ResumeLayout(False)
        grpDeckingType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlImage As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFootage As Label
    Friend WithEvents txtNumberOfFootage As TextBox
    Friend WithEvents grpDeckingType As GroupBox
    Friend WithEvents radComposite As RadioButton
    Friend WithEvents radRedwood As RadioButton
    Friend WithEvents radLumber As RadioButton
    Friend WithEvents lblEstimateCost As Label
    Friend WithEvents btnCalcCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCost As Label

End Class
