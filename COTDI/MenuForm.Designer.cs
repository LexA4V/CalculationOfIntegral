namespace CalculationOfIntegral
{
    partial class MenuForm
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
            this.btnSimpsonMethod = new System.Windows.Forms.Button();
            this.btnTrapezoidMethod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpsonMethod
            // 
            this.btnSimpsonMethod.BackColor = System.Drawing.Color.DarkRed;
            this.btnSimpsonMethod.FlatAppearance.BorderSize = 0;
            this.btnSimpsonMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpsonMethod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpsonMethod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSimpsonMethod.Location = new System.Drawing.Point(12, 208);
            this.btnSimpsonMethod.Name = "btnSimpsonMethod";
            this.btnSimpsonMethod.Size = new System.Drawing.Size(225, 70);
            this.btnSimpsonMethod.TabIndex = 0;
            this.btnSimpsonMethod.Text = "Вычислить по кубатурной формуле Симпсона";
            this.btnSimpsonMethod.UseVisualStyleBackColor = false;
            this.btnSimpsonMethod.Click += new System.EventHandler(this.btnSimpsonMethod_Click);
            // 
            // btnTrapezoidMethod
            // 
            this.btnTrapezoidMethod.BackColor = System.Drawing.Color.DarkRed;
            this.btnTrapezoidMethod.FlatAppearance.BorderSize = 0;
            this.btnTrapezoidMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrapezoidMethod.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnTrapezoidMethod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrapezoidMethod.Location = new System.Drawing.Point(252, 208);
            this.btnTrapezoidMethod.Name = "btnTrapezoidMethod";
            this.btnTrapezoidMethod.Size = new System.Drawing.Size(228, 70);
            this.btnTrapezoidMethod.TabIndex = 1;
            this.btnTrapezoidMethod.Text = "Вычислить по кубатурной формуле трапеций";
            this.btnTrapezoidMethod.UseVisualStyleBackColor = false;
            this.btnTrapezoidMethod.Click += new System.EventHandler(this.btnTrapezoidMethod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.MaximumSize = new System.Drawing.Size(470, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите  формулу, с помощью которой нужно вычислить приближённое значение  двойн" +
    "ого интеграла:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculationOfIntegral.Properties.Resources.RedLine2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CalculationOfIntegral.Properties.Resources.RedLine2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(493, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.BackgroundImage = global::CalculationOfIntegral.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 290);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrapezoidMethod);
            this.Controls.Add(this.btnSimpsonMethod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpsonMethod;
        private System.Windows.Forms.Button btnTrapezoidMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}