namespace Lab2Visual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonIsl = new System.Windows.Forms.RadioButton();
            this.radioButtonDat = new System.Windows.Forms.RadioButton();
            this.radioButtonDeutch = new System.Windows.Forms.RadioButton();
            this.radioButtonEng = new System.Windows.Forms.RadioButton();
            this.radioButtonRus = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonKg = new System.Windows.Forms.RadioButton();
            this.radioButtonFunt = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный вес в килограммах / фунтах";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 31);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Результат перевода:";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(183, 261);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(160, 59);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Вычислить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.ButtonOther);
            this.panel1.Controls.Add(this.radioButtonIsl);
            this.panel1.Controls.Add(this.radioButtonDat);
            this.panel1.Controls.Add(this.radioButtonDeutch);
            this.panel1.Controls.Add(this.radioButtonEng);
            this.panel1.Controls.Add(this.radioButtonRus);
            this.panel1.Location = new System.Drawing.Point(380, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 241);
            this.panel1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 31);
            this.textBox3.TabIndex = 11;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ButtonOther
            // 
            this.ButtonOther.Location = new System.Drawing.Point(4, 149);
            this.ButtonOther.Name = "ButtonOther";
            this.ButtonOther.Size = new System.Drawing.Size(125, 36);
            this.ButtonOther.TabIndex = 10;
            this.ButtonOther.TabStop = true;
            this.ButtonOther.Text = "Другое";
            this.ButtonOther.UseVisualStyleBackColor = true;
            this.ButtonOther.CheckedChanged += new System.EventHandler(this.ButtonOther_CheckedChanged);
            // 
            // radioButtonIsl
            // 
            this.radioButtonIsl.Location = new System.Drawing.Point(3, 119);
            this.radioButtonIsl.Name = "radioButtonIsl";
            this.radioButtonIsl.Size = new System.Drawing.Size(125, 36);
            this.radioButtonIsl.TabIndex = 9;
            this.radioButtonIsl.TabStop = true;
            this.radioButtonIsl.Text = "Исландия";
            this.radioButtonIsl.UseVisualStyleBackColor = true;
            // 
            // radioButtonDat
            // 
            this.radioButtonDat.Location = new System.Drawing.Point(3, 89);
            this.radioButtonDat.Name = "radioButtonDat";
            this.radioButtonDat.Size = new System.Drawing.Size(122, 32);
            this.radioButtonDat.TabIndex = 8;
            this.radioButtonDat.TabStop = true;
            this.radioButtonDat.Text = "Дания";
            this.radioButtonDat.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeutch
            // 
            this.radioButtonDeutch.Location = new System.Drawing.Point(3, 58);
            this.radioButtonDeutch.Name = "radioButtonDeutch";
            this.radioButtonDeutch.Size = new System.Drawing.Size(122, 36);
            this.radioButtonDeutch.TabIndex = 7;
            this.radioButtonDeutch.TabStop = true;
            this.radioButtonDeutch.Text = "Германия";
            this.radioButtonDeutch.UseVisualStyleBackColor = true;
            // 
            // radioButtonEng
            // 
            this.radioButtonEng.Location = new System.Drawing.Point(3, 31);
            this.radioButtonEng.Name = "radioButtonEng";
            this.radioButtonEng.Size = new System.Drawing.Size(122, 32);
            this.radioButtonEng.TabIndex = 1;
            this.radioButtonEng.TabStop = true;
            this.radioButtonEng.Text = "Англия";
            this.radioButtonEng.UseVisualStyleBackColor = true;
            this.radioButtonEng.CheckedChanged += new System.EventHandler(this.radioButtonEng_CheckedChanged);
            // 
            // radioButtonRus
            // 
            this.radioButtonRus.Location = new System.Drawing.Point(3, 3);
            this.radioButtonRus.Name = "radioButtonRus";
            this.radioButtonRus.Size = new System.Drawing.Size(122, 32);
            this.radioButtonRus.TabIndex = 0;
            this.radioButtonRus.TabStop = true;
            this.radioButtonRus.Text = "Россия";
            this.radioButtonRus.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonKg);
            this.panel2.Controls.Add(this.radioButtonFunt);
            this.panel2.Location = new System.Drawing.Point(12, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 85);
            this.panel2.TabIndex = 7;
            // 
            // radioButtonKg
            // 
            this.radioButtonKg.AutoSize = true;
            this.radioButtonKg.Location = new System.Drawing.Point(0, 44);
            this.radioButtonKg.Name = "radioButtonKg";
            this.radioButtonKg.Size = new System.Drawing.Size(143, 29);
            this.radioButtonKg.TabIndex = 1;
            this.radioButtonKg.Text = "Килограммы";
            this.radioButtonKg.UseVisualStyleBackColor = true;
            this.radioButtonKg.CheckedChanged += new System.EventHandler(this.radioButtonKg_CheckedChanged);
            // 
            // radioButtonFunt
            // 
            this.radioButtonFunt.AutoSize = true;
            this.radioButtonFunt.Checked = true;
            this.radioButtonFunt.Location = new System.Drawing.Point(3, 9);
            this.radioButtonFunt.Name = "radioButtonFunt";
            this.radioButtonFunt.Size = new System.Drawing.Size(89, 29);
            this.radioButtonFunt.TabIndex = 0;
            this.radioButtonFunt.TabStop = true;
            this.radioButtonFunt.Text = "Фунты";
            this.radioButtonFunt.UseVisualStyleBackColor = true;
            this.radioButtonFunt.CheckedChanged += new System.EventHandler(this.radioButtonFunt_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.вычислитьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 29);
            this.toolStripMenuItem1.Text = "Действия";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // вычислитьToolStripMenuItem
            // 
            this.вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            this.вычислитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.справкаToolStripMenuItem.Text = "Информация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 332);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KG-FUNT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonRun;
        private Panel panel1;
        private RadioButton radioButtonDeutch;
        private RadioButton radioButtonEng;
        private RadioButton radioButtonRus;
        private RadioButton radioButtonIsl;
        private RadioButton radioButtonDat;
        private Panel panel2;
        private RadioButton radioButtonKg;
        private RadioButton radioButtonFunt;
        private TextBox textBox3;
        private RadioButton ButtonOther;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem вычислитьToolStripMenuItem;
    }
}