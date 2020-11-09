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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lbWordCount = New System.Windows.Forms.Label()
        Me.btCountWords = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btApply2Words = New System.Windows.Forms.Button()
        Me.btApplyNumeric = New System.Windows.Forms.Button()
        Me.btPermutateWords = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.ckRespectOrder = New System.Windows.Forms.CheckBox()
        Me.ckWithRepetitions = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.numFromN = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.numChooseK = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.numFromN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numChooseK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(897, 464)
        Me.SplitContainer1.SplitterDistance = 494
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(494, 464)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 21)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(488, 182)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Text-Input"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtInput, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbWordCount, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btCountWords, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(482, 157)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'txtInput
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtInput, 2)
        Me.txtInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInput.Location = New System.Drawing.Point(12, 14)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(458, 93)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "The quick brown fox jumps over the lazy dog"
        '
        'lbWordCount
        '
        Me.lbWordCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbWordCount.AutoSize = True
        Me.lbWordCount.Location = New System.Drawing.Point(138, 120)
        Me.lbWordCount.Name = "lbWordCount"
        Me.lbWordCount.Size = New System.Drawing.Size(91, 17)
        Me.lbWordCount.TabIndex = 5
        Me.lbWordCount.Text = "lbWordCount"
        '
        'btCountWords
        '
        Me.btCountWords.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btCountWords.Location = New System.Drawing.Point(12, 115)
        Me.btCountWords.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btCountWords.Name = "btCountWords"
        Me.btCountWords.Size = New System.Drawing.Size(120, 28)
        Me.btCountWords.TabIndex = 4
        Me.btCountWords.Text = "count Words"
        Me.btCountWords.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox6.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(488, 257)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Configuration"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(482, 232)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel4, 2)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.btApplyNumeric, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btPermutateWords, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btApply2Words, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 192)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(476, 36)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'btApply2Words
        '
        Me.btApply2Words.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btApply2Words.Location = New System.Drawing.Point(19, 4)
        Me.btApply2Words.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btApply2Words.Name = "btApply2Words"
        Me.btApply2Words.Size = New System.Drawing.Size(120, 27)
        Me.btApply2Words.TabIndex = 7
        Me.btApply2Words.Text = "Apply To Words"
        Me.btApply2Words.UseVisualStyleBackColor = True
        '
        'btApplyNumeric
        '
        Me.btApplyNumeric.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btApplyNumeric.Location = New System.Drawing.Point(336, 4)
        Me.btApplyNumeric.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btApplyNumeric.Name = "btApplyNumeric"
        Me.btApplyNumeric.Size = New System.Drawing.Size(120, 27)
        Me.btApplyNumeric.TabIndex = 6
        Me.btApplyNumeric.Text = "Apply Numeric"
        Me.btApplyNumeric.UseVisualStyleBackColor = True
        '
        'btPermutateWords
        '
        Me.btPermutateWords.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btPermutateWords.Location = New System.Drawing.Point(174, 4)
        Me.btPermutateWords.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btPermutateWords.Name = "btPermutateWords"
        Me.btPermutateWords.Size = New System.Drawing.Size(126, 27)
        Me.btPermutateWords.TabIndex = 7
        Me.btPermutateWords.Text = "Permutate Words"
        Me.btPermutateWords.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox7, 2)
        Me.GroupBox7.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(3, 66)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(476, 118)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Combinatoric-Mode"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmbMode, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ckRespectOrder, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ckWithRepetitions, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(470, 93)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'cmbMode
        '
        Me.cmbMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Location = New System.Drawing.Point(3, 34)
        Me.cmbMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbMode.Name = "cmbMode"
        Me.TableLayoutPanel2.SetRowSpan(Me.cmbMode, 2)
        Me.cmbMode.Size = New System.Drawing.Size(229, 24)
        Me.cmbMode.TabIndex = 2
        '
        'ckRespectOrder
        '
        Me.ckRespectOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckRespectOrder.AutoSize = True
        Me.ckRespectOrder.Location = New System.Drawing.Point(238, 59)
        Me.ckRespectOrder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckRespectOrder.Name = "ckRespectOrder"
        Me.ckRespectOrder.Size = New System.Drawing.Size(229, 21)
        Me.ckRespectOrder.TabIndex = 3
        Me.ckRespectOrder.Text = "Respect Order"
        Me.ckRespectOrder.UseVisualStyleBackColor = True
        '
        'ckWithRepetitions
        '
        Me.ckWithRepetitions.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckWithRepetitions.AutoSize = True
        Me.ckWithRepetitions.Location = New System.Drawing.Point(238, 12)
        Me.ckWithRepetitions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckWithRepetitions.Name = "ckWithRepetitions"
        Me.ckWithRepetitions.Size = New System.Drawing.Size(229, 21)
        Me.ckWithRepetitions.TabIndex = 2
        Me.ckWithRepetitions.Text = "With Repetitions"
        Me.ckWithRepetitions.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.numFromN)
        Me.GroupBox5.Location = New System.Drawing.Point(244, 4)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(233, 54)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "From N"
        '
        'numFromN
        '
        Me.numFromN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numFromN.Location = New System.Drawing.Point(3, 21)
        Me.numFromN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numFromN.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numFromN.Name = "numFromN"
        Me.numFromN.Size = New System.Drawing.Size(227, 24)
        Me.numFromN.TabIndex = 0
        Me.numFromN.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.numChooseK)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(233, 50)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choose K"
        '
        'numChooseK
        '
        Me.numChooseK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numChooseK.Location = New System.Drawing.Point(3, 21)
        Me.numChooseK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numChooseK.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numChooseK.Name = "numChooseK"
        Me.numChooseK.Size = New System.Drawing.Size(227, 24)
        Me.numChooseK.TabIndex = 0
        Me.numChooseK.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOutput)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(398, 464)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'txtOutput
        '
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(3, 21)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(392, 439)
        Me.txtOutput.TabIndex = 0
        Me.txtOutput.Text = "txtOutput"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 464)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.numFromN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.numChooseK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
   Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents txtInput As System.Windows.Forms.TextBox
   Friend WithEvents lbWordCount As System.Windows.Forms.Label
   Friend WithEvents btCountWords As System.Windows.Forms.Button
   Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
   Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents cmbMode As System.Windows.Forms.ComboBox
   Friend WithEvents ckRespectOrder As System.Windows.Forms.CheckBox
   Friend WithEvents ckWithRepetitions As System.Windows.Forms.CheckBox
   Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
   Friend WithEvents numFromN As System.Windows.Forms.NumericUpDown
   Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
   Friend WithEvents numChooseK As System.Windows.Forms.NumericUpDown
   Friend WithEvents btApply2Words As System.Windows.Forms.Button
   Friend WithEvents btApplyNumeric As System.Windows.Forms.Button
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents txtOutput As System.Windows.Forms.RichTextBox
   Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents btPermutateWords As System.Windows.Forms.Button
End Class
