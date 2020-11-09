namespace PermutationCs {
   partial class Form1 {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
         this.GroupBox1 = new System.Windows.Forms.GroupBox();
         this.GroupBox4 = new System.Windows.Forms.GroupBox();
         this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.txtInput = new System.Windows.Forms.TextBox();
         this.lbWordCount = new System.Windows.Forms.Label();
         this.btCountWords = new System.Windows.Forms.Button();
         this.GroupBox6 = new System.Windows.Forms.GroupBox();
         this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
         this.btApply2Words = new System.Windows.Forms.Button();
         this.btApplyNumeric = new System.Windows.Forms.Button();
         this.btPermutateWords = new System.Windows.Forms.Button();
         this.GroupBox7 = new System.Windows.Forms.GroupBox();
         this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.cmbMode = new System.Windows.Forms.ComboBox();
         this.ckRespectOrder = new System.Windows.Forms.CheckBox();
         this.ckWithRepetitions = new System.Windows.Forms.CheckBox();
         this.GroupBox5 = new System.Windows.Forms.GroupBox();
         this.numFromN = new System.Windows.Forms.NumericUpDown();
         this.GroupBox3 = new System.Windows.Forms.GroupBox();
         this.numChooseK = new System.Windows.Forms.NumericUpDown();
         this.GroupBox2 = new System.Windows.Forms.GroupBox();
         this.txtOutput = new System.Windows.Forms.RichTextBox();
         ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
         this.SplitContainer1.Panel1.SuspendLayout();
         this.SplitContainer1.Panel2.SuspendLayout();
         this.SplitContainer1.SuspendLayout();
         this.GroupBox1.SuspendLayout();
         this.GroupBox4.SuspendLayout();
         this.TableLayoutPanel3.SuspendLayout();
         this.GroupBox6.SuspendLayout();
         this.TableLayoutPanel1.SuspendLayout();
         this.TableLayoutPanel4.SuspendLayout();
         this.GroupBox7.SuspendLayout();
         this.TableLayoutPanel2.SuspendLayout();
         this.GroupBox5.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numFromN)).BeginInit();
         this.GroupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numChooseK)).BeginInit();
         this.GroupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // SplitContainer1
         // 
         this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
         this.SplitContainer1.Name = "SplitContainer1";
         // 
         // SplitContainer1.Panel1
         // 
         this.SplitContainer1.Panel1.Controls.Add(this.GroupBox1);
         // 
         // SplitContainer1.Panel2
         // 
         this.SplitContainer1.Panel2.Controls.Add(this.GroupBox2);
         this.SplitContainer1.Size = new System.Drawing.Size(828, 443);
         this.SplitContainer1.SplitterDistance = 456;
         this.SplitContainer1.TabIndex = 1;
         // 
         // GroupBox1
         // 
         this.GroupBox1.Controls.Add(this.GroupBox4);
         this.GroupBox1.Controls.Add(this.GroupBox6);
         this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.GroupBox1.Location = new System.Drawing.Point(0, 0);
         this.GroupBox1.Name = "GroupBox1";
         this.GroupBox1.Size = new System.Drawing.Size(456, 443);
         this.GroupBox1.TabIndex = 0;
         this.GroupBox1.TabStop = false;
         // 
         // GroupBox4
         // 
         this.GroupBox4.Controls.Add(this.TableLayoutPanel3);
         this.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.GroupBox4.Location = new System.Drawing.Point(3, 16);
         this.GroupBox4.Name = "GroupBox4";
         this.GroupBox4.Size = new System.Drawing.Size(450, 215);
         this.GroupBox4.TabIndex = 9;
         this.GroupBox4.TabStop = false;
         this.GroupBox4.Text = "Text-Input";
         // 
         // TableLayoutPanel3
         // 
         this.TableLayoutPanel3.ColumnCount = 2;
         this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.TableLayoutPanel3.Controls.Add(this.txtInput, 0, 0);
         this.TableLayoutPanel3.Controls.Add(this.lbWordCount, 1, 1);
         this.TableLayoutPanel3.Controls.Add(this.btCountWords, 0, 1);
         this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
         this.TableLayoutPanel3.Name = "TableLayoutPanel3";
         this.TableLayoutPanel3.Padding = new System.Windows.Forms.Padding(8);
         this.TableLayoutPanel3.RowCount = 2;
         this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.TableLayoutPanel3.Size = new System.Drawing.Size(444, 196);
         this.TableLayoutPanel3.TabIndex = 6;
         // 
         // txtInput
         // 
         this.TableLayoutPanel3.SetColumnSpan(this.txtInput, 2);
         this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtInput.Location = new System.Drawing.Point(11, 11);
         this.txtInput.Multiline = true;
         this.txtInput.Name = "txtInput";
         this.txtInput.Size = new System.Drawing.Size(422, 145);
         this.txtInput.TabIndex = 1;
         this.txtInput.Text = "The quick brown fox jumps over the lazy dog";
         // 
         // lbWordCount
         // 
         this.lbWordCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.lbWordCount.AutoSize = true;
         this.lbWordCount.Location = new System.Drawing.Point(120, 167);
         this.lbWordCount.Name = "lbWordCount";
         this.lbWordCount.Size = new System.Drawing.Size(69, 13);
         this.lbWordCount.TabIndex = 5;
         this.lbWordCount.Text = "lbWordCount";
         // 
         // btCountWords
         // 
         this.btCountWords.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btCountWords.Location = new System.Drawing.Point(11, 162);
         this.btCountWords.Name = "btCountWords";
         this.btCountWords.Size = new System.Drawing.Size(103, 23);
         this.btCountWords.TabIndex = 4;
         this.btCountWords.Text = "count Words";
         this.btCountWords.UseVisualStyleBackColor = true;
         // 
         // GroupBox6
         // 
         this.GroupBox6.Controls.Add(this.TableLayoutPanel1);
         this.GroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.GroupBox6.Location = new System.Drawing.Point(3, 231);
         this.GroupBox6.Name = "GroupBox6";
         this.GroupBox6.Size = new System.Drawing.Size(450, 209);
         this.GroupBox6.TabIndex = 11;
         this.GroupBox6.TabStop = false;
         this.GroupBox6.Text = "Configuration";
         // 
         // TableLayoutPanel1
         // 
         this.TableLayoutPanel1.ColumnCount = 2;
         this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel4, 0, 3);
         this.TableLayoutPanel1.Controls.Add(this.GroupBox7, 0, 2);
         this.TableLayoutPanel1.Controls.Add(this.GroupBox5, 1, 0);
         this.TableLayoutPanel1.Controls.Add(this.GroupBox3, 0, 0);
         this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
         this.TableLayoutPanel1.Name = "TableLayoutPanel1";
         this.TableLayoutPanel1.RowCount = 4;
         this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.TableLayoutPanel1.Size = new System.Drawing.Size(444, 190);
         this.TableLayoutPanel1.TabIndex = 10;
         // 
         // TableLayoutPanel4
         // 
         this.TableLayoutPanel4.ColumnCount = 3;
         this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel4, 2);
         this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.TableLayoutPanel4.Controls.Add(this.btApply2Words, 0, 0);
         this.TableLayoutPanel4.Controls.Add(this.btApplyNumeric, 2, 0);
         this.TableLayoutPanel4.Controls.Add(this.btPermutateWords, 1, 0);
         this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 155);
         this.TableLayoutPanel4.Name = "TableLayoutPanel4";
         this.TableLayoutPanel4.RowCount = 1;
         this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.TableLayoutPanel4.Size = new System.Drawing.Size(438, 32);
         this.TableLayoutPanel4.TabIndex = 1;
         // 
         // btApply2Words
         // 
         this.btApply2Words.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btApply2Words.Location = new System.Drawing.Point(21, 4);
         this.btApply2Words.Name = "btApply2Words";
         this.btApply2Words.Size = new System.Drawing.Size(103, 23);
         this.btApply2Words.TabIndex = 7;
         this.btApply2Words.Text = "Apply To Words";
         this.btApply2Words.UseVisualStyleBackColor = true;
         // 
         // btApplyNumeric
         // 
         this.btApplyNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btApplyNumeric.Location = new System.Drawing.Point(313, 4);
         this.btApplyNumeric.Name = "btApplyNumeric";
         this.btApplyNumeric.Size = new System.Drawing.Size(103, 23);
         this.btApplyNumeric.TabIndex = 6;
         this.btApplyNumeric.Text = "Apply Numeric";
         this.btApplyNumeric.UseVisualStyleBackColor = true;
         // 
         // btPermutateWords
         // 
         this.btPermutateWords.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btPermutateWords.Location = new System.Drawing.Point(165, 4);
         this.btPermutateWords.Name = "btPermutateWords";
         this.btPermutateWords.Size = new System.Drawing.Size(108, 23);
         this.btPermutateWords.TabIndex = 7;
         this.btPermutateWords.Text = "Permutate Words";
         this.btPermutateWords.UseVisualStyleBackColor = true;
         // 
         // GroupBox7
         // 
         this.TableLayoutPanel1.SetColumnSpan(this.GroupBox7, 2);
         this.GroupBox7.Controls.Add(this.TableLayoutPanel2);
         this.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
         this.GroupBox7.Location = new System.Drawing.Point(3, 53);
         this.GroupBox7.Name = "GroupBox7";
         this.GroupBox7.Size = new System.Drawing.Size(438, 96);
         this.GroupBox7.TabIndex = 9;
         this.GroupBox7.TabStop = false;
         this.GroupBox7.Text = "Combinatoric-Mode";
         // 
         // TableLayoutPanel2
         // 
         this.TableLayoutPanel2.ColumnCount = 2;
         this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TableLayoutPanel2.Controls.Add(this.cmbMode, 0, 0);
         this.TableLayoutPanel2.Controls.Add(this.ckRespectOrder, 1, 1);
         this.TableLayoutPanel2.Controls.Add(this.ckWithRepetitions, 1, 0);
         this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
         this.TableLayoutPanel2.Name = "TableLayoutPanel2";
         this.TableLayoutPanel2.RowCount = 2;
         this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TableLayoutPanel2.Size = new System.Drawing.Size(432, 77);
         this.TableLayoutPanel2.TabIndex = 2;
         // 
         // cmbMode
         // 
         this.cmbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
         this.cmbMode.FormattingEnabled = true;
         this.cmbMode.Location = new System.Drawing.Point(3, 28);
         this.cmbMode.Name = "cmbMode";
         this.TableLayoutPanel2.SetRowSpan(this.cmbMode, 2);
         this.cmbMode.Size = new System.Drawing.Size(210, 21);
         this.cmbMode.TabIndex = 2;
         // 
         // ckRespectOrder
         // 
         this.ckRespectOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
         this.ckRespectOrder.AutoSize = true;
         this.ckRespectOrder.Location = new System.Drawing.Point(219, 49);
         this.ckRespectOrder.Name = "ckRespectOrder";
         this.ckRespectOrder.Size = new System.Drawing.Size(210, 17);
         this.ckRespectOrder.TabIndex = 3;
         this.ckRespectOrder.Text = "Respect Order";
         this.ckRespectOrder.UseVisualStyleBackColor = true;
         // 
         // ckWithRepetitions
         // 
         this.ckWithRepetitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
         this.ckWithRepetitions.AutoSize = true;
         this.ckWithRepetitions.Location = new System.Drawing.Point(219, 10);
         this.ckWithRepetitions.Name = "ckWithRepetitions";
         this.ckWithRepetitions.Size = new System.Drawing.Size(210, 17);
         this.ckWithRepetitions.TabIndex = 2;
         this.ckWithRepetitions.Text = "With Repetitions";
         this.ckWithRepetitions.UseVisualStyleBackColor = true;
         // 
         // GroupBox5
         // 
         this.GroupBox5.Controls.Add(this.numFromN);
         this.GroupBox5.Location = new System.Drawing.Point(225, 3);
         this.GroupBox5.Name = "GroupBox5";
         this.GroupBox5.Size = new System.Drawing.Size(200, 44);
         this.GroupBox5.TabIndex = 10;
         this.GroupBox5.TabStop = false;
         this.GroupBox5.Text = "From N";
         // 
         // numFromN
         // 
         this.numFromN.Dock = System.Windows.Forms.DockStyle.Fill;
         this.numFromN.Location = new System.Drawing.Point(3, 16);
         this.numFromN.Name = "numFromN";
         this.numFromN.Size = new System.Drawing.Size(194, 20);
         this.numFromN.TabIndex = 0;
         this.numFromN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
         // 
         // GroupBox3
         // 
         this.GroupBox3.Controls.Add(this.numChooseK);
         this.GroupBox3.Location = new System.Drawing.Point(3, 3);
         this.GroupBox3.Name = "GroupBox3";
         this.GroupBox3.Size = new System.Drawing.Size(200, 41);
         this.GroupBox3.TabIndex = 8;
         this.GroupBox3.TabStop = false;
         this.GroupBox3.Text = "Choose K";
         // 
         // numChooseK
         // 
         this.numChooseK.Dock = System.Windows.Forms.DockStyle.Fill;
         this.numChooseK.Location = new System.Drawing.Point(3, 16);
         this.numChooseK.Name = "numChooseK";
         this.numChooseK.Size = new System.Drawing.Size(194, 20);
         this.numChooseK.TabIndex = 0;
         this.numChooseK.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
         // 
         // GroupBox2
         // 
         this.GroupBox2.Controls.Add(this.txtOutput);
         this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.GroupBox2.Location = new System.Drawing.Point(0, 0);
         this.GroupBox2.Name = "GroupBox2";
         this.GroupBox2.Size = new System.Drawing.Size(368, 443);
         this.GroupBox2.TabIndex = 1;
         this.GroupBox2.TabStop = false;
         this.GroupBox2.Text = "Output";
         // 
         // txtOutput
         // 
         this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtOutput.Location = new System.Drawing.Point(3, 16);
         this.txtOutput.Name = "txtOutput";
         this.txtOutput.ReadOnly = true;
         this.txtOutput.Size = new System.Drawing.Size(362, 424);
         this.txtOutput.TabIndex = 0;
         this.txtOutput.Text = "txtOutput";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(828, 443);
         this.Controls.Add(this.SplitContainer1);
         this.Name = "Form1";
         this.Text = "Form1-c#";
         this.SplitContainer1.Panel1.ResumeLayout(false);
         this.SplitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
         this.SplitContainer1.ResumeLayout(false);
         this.GroupBox1.ResumeLayout(false);
         this.GroupBox4.ResumeLayout(false);
         this.TableLayoutPanel3.ResumeLayout(false);
         this.TableLayoutPanel3.PerformLayout();
         this.GroupBox6.ResumeLayout(false);
         this.TableLayoutPanel1.ResumeLayout(false);
         this.TableLayoutPanel4.ResumeLayout(false);
         this.GroupBox7.ResumeLayout(false);
         this.TableLayoutPanel2.ResumeLayout(false);
         this.TableLayoutPanel2.PerformLayout();
         this.GroupBox5.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.numFromN)).EndInit();
         this.GroupBox3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.numChooseK)).EndInit();
         this.GroupBox2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      internal System.Windows.Forms.SplitContainer SplitContainer1;
      internal System.Windows.Forms.GroupBox GroupBox1;
      internal System.Windows.Forms.GroupBox GroupBox4;
      internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
      internal System.Windows.Forms.TextBox txtInput;
      internal System.Windows.Forms.Label lbWordCount;
      internal System.Windows.Forms.Button btCountWords;
      internal System.Windows.Forms.GroupBox GroupBox6;
      internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
      internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
      internal System.Windows.Forms.Button btApply2Words;
      internal System.Windows.Forms.Button btApplyNumeric;
      internal System.Windows.Forms.Button btPermutateWords;
      internal System.Windows.Forms.GroupBox GroupBox7;
      internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
      internal System.Windows.Forms.ComboBox cmbMode;
      internal System.Windows.Forms.CheckBox ckRespectOrder;
      internal System.Windows.Forms.CheckBox ckWithRepetitions;
      internal System.Windows.Forms.GroupBox GroupBox5;
      internal System.Windows.Forms.NumericUpDown numFromN;
      internal System.Windows.Forms.GroupBox GroupBox3;
      internal System.Windows.Forms.NumericUpDown numChooseK;
      internal System.Windows.Forms.GroupBox GroupBox2;
      internal System.Windows.Forms.RichTextBox txtOutput;
   }
}

