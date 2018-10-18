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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(60, 41);
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ilość osób";
            // 
            // setCostDecorationCheckBox2
            // 
            this.setCostDecorationCheckBox2.AutoSize = true;
            this.setCostDecorationCheckBox2.Location = new System.Drawing.Point(91, 85);
            this.setCostDecorationCheckBox2.Name = "setCostDecorationCheckBox2";
            this.setCostDecorationCheckBox2.Size = new System.Drawing.Size(126, 17);
            this.setCostDecorationCheckBox2.TabIndex = 2;
            this.setCostDecorationCheckBox2.Text = "Dekoracje fantazyjne";
            this.setCostDecorationCheckBox2.UseVisualStyleBackColor = true;
            // 
            // setHealthyOptionCheckBox2
            // 
            this.setHealthyOptionCheckBox2.AutoSize = true;
            this.setHealthyOptionCheckBox2.Location = new System.Drawing.Point(91, 108);
            this.setHealthyOptionCheckBox2.Name = "setHealthyOptionCheckBox2";
            this.setHealthyOptionCheckBox2.Size = new System.Drawing.Size(91, 17);
            this.setHealthyOptionCheckBox2.TabIndex = 3;
            this.setHealthyOptionCheckBox2.Text = "Opcja zdrowa";
            this.setHealthyOptionCheckBox2.UseVisualStyleBackColor = true;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalCost.Location = new System.Drawing.Point(32, 184);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(78, 24);
            this.TotalCost.TabIndex = 4;
            this.TotalCost.Text = "Kwota :";
            // 
            // TotalCost2
            // 
            this.TotalCost2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCost2.Location = new System.Drawing.Point(116, 184);
            this.TotalCost2.Name = "TotalCost2";
            this.TotalCost2.Size = new System.Drawing.Size(100, 23);
            this.TotalCost2.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TotalCost2);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.setHealthyOptionCheckBox2);
            this.Controls.Add(this.setCostDecorationCheckBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planista przyjęć";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox setCostDecorationCheckBox;
        private System.Windows.Forms.CheckBox setHealthyOptionCheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox setCostDecorationCheckBox2;
        private System.Windows.Forms.CheckBox setHealthyOptionCheckBox2;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label TotalCost2;
    }
}

