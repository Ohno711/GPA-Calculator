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
        Me.lstGPA = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblNon = New System.Windows.Forms.Label()
        Me.lblAll = New System.Windows.Forms.Label()
        Me.rbNon = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstGPA
        '
        Me.lstGPA.FormattingEnabled = True
        Me.lstGPA.Location = New System.Drawing.Point(90, 31)
        Me.lstGPA.Name = "lstGPA"
        Me.lstGPA.Size = New System.Drawing.Size(104, 95)
        Me.lstGPA.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAll)
        Me.GroupBox1.Controls.Add(Me.lblNon)
        Me.GroupBox1.Controls.Add(Me.lblMale)
        Me.GroupBox1.Controls.Add(Me.lblFemale)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Average GPA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Female Students:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "All Students:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total # of Students:"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(12, 31)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 2
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "&Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(12, 54)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 3
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "&Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&GPA:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(218, 36)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 65)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Male Students:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Non-Binary Students:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTotal.Location = New System.Drawing.Point(2, 29)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(89, 23)
        Me.lblTotal.TabIndex = 7
        '
        'lblFemale
        '
        Me.lblFemale.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblFemale.Location = New System.Drawing.Point(2, 61)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(89, 23)
        Me.lblFemale.TabIndex = 8
        '
        'lblMale
        '
        Me.lblMale.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMale.Location = New System.Drawing.Point(97, 61)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(85, 23)
        Me.lblMale.TabIndex = 9
        '
        'lblNon
        '
        Me.lblNon.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblNon.Location = New System.Drawing.Point(188, 61)
        Me.lblNon.Name = "lblNon"
        Me.lblNon.Size = New System.Drawing.Size(89, 23)
        Me.lblNon.TabIndex = 10
        '
        'lblAll
        '
        Me.lblAll.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAll.Location = New System.Drawing.Point(188, 29)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(89, 23)
        Me.lblAll.TabIndex = 11
        '
        'rbNon
        '
        Me.rbNon.AutoSize = True
        Me.rbNon.Location = New System.Drawing.Point(12, 77)
        Me.rbNon.Name = "rbNon"
        Me.rbNon.Size = New System.Drawing.Size(77, 17)
        Me.rbNon.TabIndex = 7
        Me.rbNon.TabStop = True
        Me.rbNon.Text = "&Non-Binary"
        Me.rbNon.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 239)
        Me.Controls.Add(Me.rbNon)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstGPA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGPA As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAll As Label
    Friend WithEvents lblNon As Label
    Friend WithEvents lblMale As Label
    Friend WithEvents lblFemale As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbNon As RadioButton
End Class
