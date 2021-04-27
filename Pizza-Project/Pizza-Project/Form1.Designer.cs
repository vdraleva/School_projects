
namespace Pizza_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.golqma = new System.Windows.Forms.RadioButton();
            this.sredna = new System.Windows.Forms.RadioButton();
            this.malka = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chili = new System.Windows.Forms.CheckBox();
            this.soevSos = new System.Windows.Forms.CheckBox();
            this.chesnovSos = new System.Windows.Forms.CheckBox();
            this.gorchitsa = new System.Windows.Forms.CheckBox();
            this.mayoneza = new System.Windows.Forms.CheckBox();
            this.ketchup = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(301, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Маргарита",
            "Капричоза",
            "Калцоне",
            "Хавай",
            "Прошуто",
            "Вегетариана",
            "Тоскана"});
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.golqma);
            this.groupBox1.Controls.Add(this.sredna);
            this.groupBox1.Controls.Add(this.malka);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вариант";
            // 
            // golqma
            // 
            this.golqma.AutoSize = true;
            this.golqma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.golqma.Location = new System.Drawing.Point(6, 105);
            this.golqma.Name = "golqma";
            this.golqma.Size = new System.Drawing.Size(72, 20);
            this.golqma.TabIndex = 7;
            this.golqma.TabStop = true;
            this.golqma.Text = "голяма";
            this.golqma.UseVisualStyleBackColor = true;
            this.golqma.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // sredna
            // 
            this.sredna.AutoSize = true;
            this.sredna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sredna.Location = new System.Drawing.Point(6, 62);
            this.sredna.Name = "sredna";
            this.sredna.Size = new System.Drawing.Size(73, 20);
            this.sredna.TabIndex = 6;
            this.sredna.TabStop = true;
            this.sredna.Text = "средна";
            this.sredna.UseVisualStyleBackColor = true;
            // 
            // malka
            // 
            this.malka.AutoSize = true;
            this.malka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.malka.Location = new System.Drawing.Point(6, 21);
            this.malka.Name = "malka";
            this.malka.Size = new System.Drawing.Size(66, 20);
            this.malka.TabIndex = 5;
            this.malka.TabStop = true;
            this.malka.Text = "малка";
            this.malka.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chili);
            this.groupBox2.Controls.Add(this.soevSos);
            this.groupBox2.Controls.Add(this.chesnovSos);
            this.groupBox2.Controls.Add(this.gorchitsa);
            this.groupBox2.Controls.Add(this.mayoneza);
            this.groupBox2.Controls.Add(this.ketchup);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(152, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Екстри";
            // 
            // chili
            // 
            this.chili.AutoSize = true;
            this.chili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chili.Location = new System.Drawing.Point(6, 228);
            this.chili.Name = "chili";
            this.chili.Size = new System.Drawing.Size(59, 20);
            this.chili.TabIndex = 5;
            this.chili.Text = "чили";
            this.chili.UseVisualStyleBackColor = true;
            // 
            // soevSos
            // 
            this.soevSos.AutoSize = true;
            this.soevSos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soevSos.Location = new System.Drawing.Point(6, 186);
            this.soevSos.Name = "soevSos";
            this.soevSos.Size = new System.Drawing.Size(83, 20);
            this.soevSos.TabIndex = 4;
            this.soevSos.Text = "соев сос";
            this.soevSos.UseVisualStyleBackColor = true;
            // 
            // chesnovSos
            // 
            this.chesnovSos.AutoSize = true;
            this.chesnovSos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chesnovSos.Location = new System.Drawing.Point(6, 145);
            this.chesnovSos.Name = "chesnovSos";
            this.chesnovSos.Size = new System.Drawing.Size(99, 20);
            this.chesnovSos.TabIndex = 3;
            this.chesnovSos.Text = "чеснов сос";
            this.chesnovSos.UseVisualStyleBackColor = true;
            // 
            // gorchitsa
            // 
            this.gorchitsa.AutoSize = true;
            this.gorchitsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gorchitsa.Location = new System.Drawing.Point(6, 105);
            this.gorchitsa.Name = "gorchitsa";
            this.gorchitsa.Size = new System.Drawing.Size(81, 20);
            this.gorchitsa.TabIndex = 2;
            this.gorchitsa.Text = "горчица";
            this.gorchitsa.UseVisualStyleBackColor = true;
            // 
            // mayoneza
            // 
            this.mayoneza.AutoSize = true;
            this.mayoneza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mayoneza.Location = new System.Drawing.Point(6, 70);
            this.mayoneza.Name = "mayoneza";
            this.mayoneza.Size = new System.Drawing.Size(92, 20);
            this.mayoneza.TabIndex = 1;
            this.mayoneza.Text = "майонеза";
            this.mayoneza.UseVisualStyleBackColor = true;
            // 
            // ketchup
            // 
            this.ketchup.AutoSize = true;
            this.ketchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ketchup.Location = new System.Drawing.Point(6, 35);
            this.ketchup.Name = "ketchup";
            this.ketchup.Size = new System.Drawing.Size(73, 20);
            this.ketchup.TabIndex = 0;
            this.ketchup.Text = "кетчуп";
            this.ketchup.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Плащане";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton5.Location = new System.Drawing.Point(13, 72);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(74, 20);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "онлайн";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(13, 34);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 20);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "в брой";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(350, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поръчай";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.iconP;
            this.ClientSize = new System.Drawing.Size(635, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Пица у дома";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton golqma;
        private System.Windows.Forms.RadioButton sredna;
        private System.Windows.Forms.RadioButton malka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chili;
        private System.Windows.Forms.CheckBox soevSos;
        private System.Windows.Forms.CheckBox chesnovSos;
        private System.Windows.Forms.CheckBox gorchitsa;
        private System.Windows.Forms.CheckBox mayoneza;
        private System.Windows.Forms.CheckBox ketchup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

