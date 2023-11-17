namespace Program1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frontLength = new System.Windows.Forms.TextBox();
            this.sideLength = new System.Windows.Forms.TextBox();
            this.heightLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.windowPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.costOfDrywall = new System.Windows.Forms.TextBox();
            this.costOfLabor = new System.Windows.Forms.TextBox();
            this.totalSQ = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.percentExtra = new System.Windows.Forms.Label();
            this.laborCostBox = new System.Windows.Forms.Label();
            this.matCostBox = new System.Windows.Forms.Label();
            this.totalCostBox = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dry Wall and Window Cost Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length of Front (ft):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Length of Side (ft):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height (ft):";
            // 
            // frontLength
            // 
            this.frontLength.Location = new System.Drawing.Point(169, 56);
            this.frontLength.Name = "frontLength";
            this.frontLength.Size = new System.Drawing.Size(100, 20);
            this.frontLength.TabIndex = 4;
            // 
            // sideLength
            // 
            this.sideLength.Location = new System.Drawing.Point(169, 93);
            this.sideLength.Name = "sideLength";
            this.sideLength.Size = new System.Drawing.Size(100, 20);
            this.sideLength.TabIndex = 5;
            // 
            // heightLength
            // 
            this.heightLength.Location = new System.Drawing.Point(169, 122);
            this.heightLength.Name = "heightLength";
            this.heightLength.Size = new System.Drawing.Size(100, 20);
            this.heightLength.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Window? (1 - YES, 0 - NO):";
            // 
            // windowPrice
            // 
            this.windowPrice.Location = new System.Drawing.Point(169, 195);
            this.windowPrice.Name = "windowPrice";
            this.windowPrice.Size = new System.Drawing.Size(100, 20);
            this.windowPrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cost of Dry Wall Per SQ Foot:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cost of Labor Per SQ Foot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total SQ feet needed:";
            // 
            // costOfDrywall
            // 
            this.costOfDrywall.Location = new System.Drawing.Point(169, 243);
            this.costOfDrywall.Name = "costOfDrywall";
            this.costOfDrywall.Size = new System.Drawing.Size(100, 20);
            this.costOfDrywall.TabIndex = 12;
            // 
            // costOfLabor
            // 
            this.costOfLabor.Location = new System.Drawing.Point(169, 275);
            this.costOfLabor.Name = "costOfLabor";
            this.costOfLabor.Size = new System.Drawing.Size(100, 20);
            this.costOfLabor.TabIndex = 13;
            // 
            // totalSQ
            // 
            this.totalSQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSQ.Location = new System.Drawing.Point(169, 303);
            this.totalSQ.Name = "totalSQ";
            this.totalSQ.Size = new System.Drawing.Size(100, 23);
            this.totalSQ.TabIndex = 14;
            this.totalSQ.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "10% Extra:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Labor Cost:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Material Cost:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(94, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Total Cost:";
            // 
            // percentExtra
            // 
            this.percentExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentExtra.Location = new System.Drawing.Point(169, 340);
            this.percentExtra.Name = "percentExtra";
            this.percentExtra.Size = new System.Drawing.Size(100, 23);
            this.percentExtra.TabIndex = 19;
            this.percentExtra.Text = " ";
            // 
            // laborCostBox
            // 
            this.laborCostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostBox.Location = new System.Drawing.Point(169, 368);
            this.laborCostBox.Name = "laborCostBox";
            this.laborCostBox.Size = new System.Drawing.Size(100, 23);
            this.laborCostBox.TabIndex = 20;
            this.laborCostBox.Text = " ";
            // 
            // matCostBox
            // 
            this.matCostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matCostBox.Location = new System.Drawing.Point(169, 399);
            this.matCostBox.Name = "matCostBox";
            this.matCostBox.Size = new System.Drawing.Size(100, 23);
            this.matCostBox.TabIndex = 21;
            this.matCostBox.Text = " ";
            // 
            // totalCostBox
            // 
            this.totalCostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostBox.Location = new System.Drawing.Point(169, 438);
            this.totalCostBox.Name = "totalCostBox";
            this.totalCostBox.Size = new System.Drawing.Size(100, 23);
            this.totalCostBox.TabIndex = 22;
            this.totalCostBox.Text = " ";
            // 
            // calculateBtn
            // 
            this.calculateBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.calculateBtn.FlatAppearance.BorderSize = 2;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBtn.Location = new System.Drawing.Point(107, 485);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(157, 27);
            this.calculateBtn.TabIndex = 23;
            this.calculateBtn.Text = "Calculate Estimate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 536);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.totalCostBox);
            this.Controls.Add(this.matCostBox);
            this.Controls.Add(this.laborCostBox);
            this.Controls.Add(this.percentExtra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalSQ);
            this.Controls.Add(this.costOfLabor);
            this.Controls.Add(this.costOfDrywall);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.windowPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heightLength);
            this.Controls.Add(this.sideLength);
            this.Controls.Add(this.frontLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frontLength;
        private System.Windows.Forms.TextBox sideLength;
        private System.Windows.Forms.TextBox heightLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox windowPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox costOfDrywall;
        private System.Windows.Forms.TextBox costOfLabor;
        private System.Windows.Forms.Label totalSQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label percentExtra;
        private System.Windows.Forms.Label laborCostBox;
        private System.Windows.Forms.Label matCostBox;
        private System.Windows.Forms.Label totalCostBox;
        private System.Windows.Forms.Button calculateBtn;
    }
}

