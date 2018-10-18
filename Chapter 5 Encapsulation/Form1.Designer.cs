namespace Chapter_5_Encapsulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.setCostDecorationCheckBox2 = new System.Windows.Forms.CheckBox();
            this.setHealthyOptionCheckBox2 = new System.Windows.Forms.CheckBox();
            this.TotalCost = new System.Windows.Forms.Label();
            this.TotalCost2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TotalCostBirthday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(51, 30);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 0;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ilość osób";
            // 
            // setCostDecorationCheckBox2
            // 
            this.setCostDecorationCheckBox2.AutoSize = true;
            this.setCostDecorationCheckBox2.Location = new System.Drawing.Point(51, 66);
            this.setCostDecorationCheckBox2.Name = "setCostDecorationCheckBox2";
            this.setCostDecorationCheckBox2.Size = new System.Drawing.Size(126, 17);
            this.setCostDecorationCheckBox2.TabIndex = 2;
            this.setCostDecorationCheckBox2.Text = "Dekoracje fantazyjne";
            this.setCostDecorationCheckBox2.UseVisualStyleBackColor = true;
            this.setCostDecorationCheckBox2.CheckedChanged += new System.EventHandler(this.setCostDecorationCheckBox2_CheckedChanged);
            // 
            // setHealthyOptionCheckBox2
            // 
            this.setHealthyOptionCheckBox2.AutoSize = true;
            this.setHealthyOptionCheckBox2.Location = new System.Drawing.Point(51, 89);
            this.setHealthyOptionCheckBox2.Name = "setHealthyOptionCheckBox2";
            this.setHealthyOptionCheckBox2.Size = new System.Drawing.Size(91, 17);
            this.setHealthyOptionCheckBox2.TabIndex = 3;
            this.setHealthyOptionCheckBox2.Text = "Opcja zdrowa";
            this.setHealthyOptionCheckBox2.UseVisualStyleBackColor = true;
            this.setHealthyOptionCheckBox2.CheckedChanged += new System.EventHandler(this.setHealthyOptionCheckBox_CheckedChanged);
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalCost.Location = new System.Drawing.Point(28, 134);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(78, 24);
            this.TotalCost.TabIndex = 4;
            this.TotalCost.Text = "Kwota :";
            // 
            // TotalCost2
            // 
            this.TotalCost2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCost2.Location = new System.Drawing.Point(112, 135);
            this.TotalCost2.Name = "TotalCost2";
            this.TotalCost2.Size = new System.Drawing.Size(100, 23);
            this.TotalCost2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 249);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.tooLongLabel);
            this.tabPage1.Controls.Add(this.cakeWriting);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TotalCostBirthday);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.numberBirthday);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Urodziny";
            // 
            // TotalCostBirthday
            // 
            this.TotalCostBirthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCostBirthday.Location = new System.Drawing.Point(116, 163);
            this.TotalCostBirthday.Name = "TotalCostBirthday";
            this.TotalCostBirthday.Size = new System.Drawing.Size(100, 23);
            this.TotalCostBirthday.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kwota :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Dekoracje fantazyjne";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(11, 28);
            this.numberBirthday.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 1;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość osób :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TotalCost2);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.TotalCost);
            this.tabPage2.Controls.Add(this.setCostDecorationCheckBox2);
            this.tabPage2.Controls.Add(this.setHealthyOptionCheckBox2);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Impreza okolicznościowa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Napis na torcie";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(6, 101);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(151, 20);
            this.cakeWriting.TabIndex = 7;
            this.cakeWriting.Text = "Sto lat!";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.DarkRed;
            this.tooLongLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tooLongLabel.Location = new System.Drawing.Point(92, 85);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(75, 13);
            this.tooLongLabel.TabIndex = 8;
            this.tooLongLabel.Text = "ZBYT DŁUGI ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planista przyjęć";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox setCostDecorationCheckBox2;
        private System.Windows.Forms.CheckBox setHealthyOptionCheckBox2;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label TotalCost2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label TotalCostBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tooLongLabel;
    }
}

