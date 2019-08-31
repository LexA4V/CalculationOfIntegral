namespace CalculationOfIntegral
{
    partial class MainForm
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
            this.groupBoxY = new System.Windows.Forms.GroupBox();
            this.tBYStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBYFinish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBYNumberOfSections = new System.Windows.Forms.TextBox();
            this.groupBoxX = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tBXFinish = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tBXStart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBXNumberOfSections = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tBResult = new System.Windows.Forms.TextBox();
            this.brnToBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоретическиеСведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxY.SuspendLayout();
            this.groupBoxX.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxY
            // 
            this.groupBoxY.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxY.Controls.Add(this.tBYStart);
            this.groupBoxY.Controls.Add(this.label5);
            this.groupBoxY.Controls.Add(this.tBYFinish);
            this.groupBoxY.Controls.Add(this.label2);
            this.groupBoxY.Controls.Add(this.label3);
            this.groupBoxY.Controls.Add(this.tBYNumberOfSections);
            this.groupBoxY.ForeColor = System.Drawing.Color.White;
            this.groupBoxY.Location = new System.Drawing.Point(241, 179);
            this.groupBoxY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBoxY.Name = "groupBoxY";
            this.groupBoxY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBoxY.Size = new System.Drawing.Size(509, 111);
            this.groupBoxY.TabIndex = 39;
            this.groupBoxY.TabStop = false;
            this.groupBoxY.Text = "Отрезок интегрирования по оси Oy";
            // 
            // tBYStart
            // 
            this.tBYStart.BackColor = System.Drawing.Color.White;
            this.tBYStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBYStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBYStart.ForeColor = System.Drawing.Color.Black;
            this.tBYStart.Location = new System.Drawing.Point(378, 26);
            this.tBYStart.Margin = new System.Windows.Forms.Padding(6);
            this.tBYStart.Name = "tBYStart";
            this.tBYStart.Size = new System.Drawing.Size(50, 30);
            this.tBYStart.TabIndex = 0;
            this.tBYStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите нижний и верхний концы отрезка";
            // 
            // tBYFinish
            // 
            this.tBYFinish.BackColor = System.Drawing.Color.White;
            this.tBYFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBYFinish.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tBYFinish.ForeColor = System.Drawing.Color.Black;
            this.tBYFinish.Location = new System.Drawing.Point(440, 26);
            this.tBYFinish.Margin = new System.Windows.Forms.Padding(6);
            this.tBYFinish.Name = "tBYFinish";
            this.tBYFinish.Size = new System.Drawing.Size(50, 30);
            this.tBYFinish.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите количество участков разбиения отрезка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(428, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = ";";
            // 
            // tBYNumberOfSections
            // 
            this.tBYNumberOfSections.BackColor = System.Drawing.Color.White;
            this.tBYNumberOfSections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBYNumberOfSections.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tBYNumberOfSections.ForeColor = System.Drawing.Color.Black;
            this.tBYNumberOfSections.Location = new System.Drawing.Point(440, 67);
            this.tBYNumberOfSections.Margin = new System.Windows.Forms.Padding(6);
            this.tBYNumberOfSections.Name = "tBYNumberOfSections";
            this.tBYNumberOfSections.Size = new System.Drawing.Size(50, 30);
            this.tBYNumberOfSections.TabIndex = 2;
            this.tBYNumberOfSections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxX
            // 
            this.groupBoxX.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxX.Controls.Add(this.label7);
            this.groupBoxX.Controls.Add(this.textBox10);
            this.groupBoxX.Controls.Add(this.tBXFinish);
            this.groupBoxX.Controls.Add(this.textBox9);
            this.groupBoxX.Controls.Add(this.tBXStart);
            this.groupBoxX.Controls.Add(this.label11);
            this.groupBoxX.Controls.Add(this.tBXNumberOfSections);
            this.groupBoxX.Controls.Add(this.label1);
            this.groupBoxX.ForeColor = System.Drawing.Color.White;
            this.groupBoxX.Location = new System.Drawing.Point(241, 58);
            this.groupBoxX.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBoxX.Name = "groupBoxX";
            this.groupBoxX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBoxX.Size = new System.Drawing.Size(509, 111);
            this.groupBoxX.TabIndex = 38;
            this.groupBoxX.TabStop = false;
            this.groupBoxX.Text = "Отрезок интегрирования по оси Ox";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(19, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Введите левый и правый концы отрезка";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(719, 26);
            this.textBox10.Margin = new System.Windows.Forms.Padding(6);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(50, 30);
            this.textBox10.TabIndex = 1;
            this.textBox10.Text = "4,4";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBXFinish
            // 
            this.tBXFinish.BackColor = System.Drawing.Color.White;
            this.tBXFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBXFinish.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tBXFinish.ForeColor = System.Drawing.Color.Black;
            this.tBXFinish.Location = new System.Drawing.Point(440, 26);
            this.tBXFinish.Margin = new System.Windows.Forms.Padding(6);
            this.tBXFinish.Name = "tBXFinish";
            this.tBXFinish.Size = new System.Drawing.Size(50, 30);
            this.tBXFinish.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(657, 26);
            this.textBox9.Margin = new System.Windows.Forms.Padding(6);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(49, 30);
            this.textBox9.TabIndex = 0;
            this.textBox9.Text = "4";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBXStart
            // 
            this.tBXStart.BackColor = System.Drawing.Color.White;
            this.tBXStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBXStart.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tBXStart.ForeColor = System.Drawing.Color.Black;
            this.tBXStart.Location = new System.Drawing.Point(378, 26);
            this.tBXStart.Margin = new System.Windows.Forms.Padding(6);
            this.tBXStart.Name = "tBXStart";
            this.tBXStart.Size = new System.Drawing.Size(49, 30);
            this.tBXStart.TabIndex = 0;
            this.tBXStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(428, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = ";";
            // 
            // tBXNumberOfSections
            // 
            this.tBXNumberOfSections.BackColor = System.Drawing.Color.White;
            this.tBXNumberOfSections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBXNumberOfSections.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tBXNumberOfSections.ForeColor = System.Drawing.Color.Black;
            this.tBXNumberOfSections.Location = new System.Drawing.Point(440, 69);
            this.tBXNumberOfSections.Margin = new System.Windows.Forms.Padding(6);
            this.tBXNumberOfSections.Name = "tBXNumberOfSections";
            this.tBXNumberOfSections.Size = new System.Drawing.Size(50, 30);
            this.tBXNumberOfSections.TabIndex = 2;
            this.tBXNumberOfSections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBXNumberOfSections.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество участков разбиения отрезка";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Maroon;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Location = new System.Drawing.Point(14, 67);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(211, 41);
            this.btnCalculate.TabIndex = 43;
            this.btnCalculate.Text = "ВЫЧИСЛИТЬ";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBResult
            // 
            this.tBResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(84)))));
            this.tBResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBResult.ForeColor = System.Drawing.Color.White;
            this.tBResult.Location = new System.Drawing.Point(14, 158);
            this.tBResult.Margin = new System.Windows.Forms.Padding(0);
            this.tBResult.Name = "tBResult";
            this.tBResult.ReadOnly = true;
            this.tBResult.Size = new System.Drawing.Size(211, 26);
            this.tBResult.TabIndex = 44;
            this.tBResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brnToBack
            // 
            this.brnToBack.BackColor = System.Drawing.Color.Maroon;
            this.brnToBack.FlatAppearance.BorderSize = 0;
            this.brnToBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnToBack.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brnToBack.ForeColor = System.Drawing.SystemColors.Control;
            this.brnToBack.Location = new System.Drawing.Point(14, 259);
            this.brnToBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.brnToBack.Name = "brnToBack";
            this.brnToBack.Size = new System.Drawing.Size(211, 31);
            this.brnToBack.TabIndex = 45;
            this.brnToBack.Text = "НАЗАД";
            this.brnToBack.UseVisualStyleBackColor = false;
            this.brnToBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(762, 26);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.теоретическиеСведенияToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // теоретическиеСведенияToolStripMenuItem
            // 
            this.теоретическиеСведенияToolStripMenuItem.Name = "теоретическиеСведенияToolStripMenuItem";
            this.теоретическиеСведенияToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.теоретическиеСведенияToolStripMenuItem.Text = "Теоретические сведения";
            this.теоретическиеСведенияToolStripMenuItem.Click += new System.EventHandler(this.теоретическиеСведенияToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CalculationOfIntegral.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.MaximumSize = new System.Drawing.Size(280, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 36);
            this.label4.TabIndex = 49;
            this.label4.Text = "Приближённое значение интеграла:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculationOfIntegral.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 303);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.brnToBack);
            this.Controls.Add(this.tBResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBoxX);
            this.Controls.Add(this.groupBoxY);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метод трапеций";
            this.groupBoxY.ResumeLayout(false);
            this.groupBoxY.PerformLayout();
            this.groupBoxX.ResumeLayout(false);
            this.groupBoxX.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxY;
        private System.Windows.Forms.TextBox tBYStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBYFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBYNumberOfSections;
        private System.Windows.Forms.GroupBox groupBoxX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBXFinish;
        private System.Windows.Forms.TextBox tBXStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBXNumberOfSections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tBResult;
        private System.Windows.Forms.Button brnToBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоретическиеСведенияToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}