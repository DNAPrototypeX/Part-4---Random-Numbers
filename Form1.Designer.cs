namespace Part_4___Random_Numbers
{
    partial class frmMain
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
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.nudRounding = new System.Windows.Forms.NumericUpDown();
            this.lblRounding = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounding)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.Lime;
            this.btnInt.Location = new System.Drawing.Point(16, 80);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(277, 29);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.Aqua;
            this.btnDouble.Location = new System.Drawing.Point(15, 115);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(277, 29);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomNumber.Location = new System.Drawing.Point(12, 171);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(289, 23);
            this.lblRandomNumber.TabIndex = 2;
            this.lblRandomNumber.Text = "Number Will Appear Here!";
            this.lblRandomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtMax.Location = new System.Drawing.Point(83, 54);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(217, 20);
            this.txtMax.TabIndex = 3;
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtMin.Location = new System.Drawing.Point(83, 28);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(217, 20);
            this.txtMin.TabIndex = 4;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.Yellow;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(12, 5);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(275, 20);
            this.lblInstruction.TabIndex = 5;
            this.lblInstruction.Text = "Enter a maximum and minimum value.";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(1, 28);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(76, 20);
            this.lblMin.TabIndex = 6;
            this.lblMin.Text = "Minimum:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(1, 54);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(80, 20);
            this.lblMax.TabIndex = 7;
            this.lblMax.Text = "Maximum:";
            // 
            // nudRounding
            // 
            this.nudRounding.Location = new System.Drawing.Point(198, 148);
            this.nudRounding.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudRounding.Name = "nudRounding";
            this.nudRounding.Size = new System.Drawing.Size(38, 20);
            this.nudRounding.TabIndex = 8;
            this.nudRounding.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblRounding
            // 
            this.lblRounding.AutoSize = true;
            this.lblRounding.BackColor = System.Drawing.SystemColors.Control;
            this.lblRounding.Location = new System.Drawing.Point(68, 150);
            this.lblRounding.Name = "lblRounding";
            this.lblRounding.Size = new System.Drawing.Size(124, 13);
            this.lblRounding.TabIndex = 9;
            this.lblRounding.Text = "# of decimals to round to";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(312, 200);
            this.Controls.Add(this.lblRounding);
            this.Controls.Add(this.nudRounding);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Name = "frmMain";
            this.Text = "Random Number Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nudRounding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown nudRounding;
        private System.Windows.Forms.Label lblRounding;
    }
}

