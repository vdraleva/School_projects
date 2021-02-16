namespace windows_calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(12, 63);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(38, 35);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(56, 63);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(38, 35);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(100, 63);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(38, 35);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(12, 104);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(38, 35);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(56, 104);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(38, 35);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(100, 104);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(38, 35);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(12, 145);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(38, 35);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(56, 145);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(38, 35);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(100, 145);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(38, 35);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(56, 186);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(38, 35);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            // 
            // bad
            // 
            this.bad.Location = new System.Drawing.Point(144, 63);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(38, 35);
            this.bad.TabIndex = 11;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = true;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // bsub
            // 
            this.bsub.Location = new System.Drawing.Point(144, 104);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(38, 35);
            this.bsub.TabIndex = 12;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bmult
            // 
            this.bmult.Location = new System.Drawing.Point(144, 145);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(38, 35);
            this.bmult.TabIndex = 13;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = true;
            this.bmult.Click += new System.EventHandler(this.bmult_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(144, 186);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(38, 35);
            this.bdiv.TabIndex = 14;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bequal
            // 
            this.bequal.Location = new System.Drawing.Point(100, 227);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(82, 35);
            this.bequal.TabIndex = 15;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button bad;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.Button button1;
    }
}

