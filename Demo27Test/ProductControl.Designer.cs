namespace Demo27Test
{
    partial class ProductControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProzName = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelSostav = new System.Windows.Forms.Label();
            this.labelQuant = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelProzName
            // 
            this.labelProzName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProzName.Location = new System.Drawing.Point(287, 16);
            this.labelProzName.Name = "labelProzName";
            this.labelProzName.Size = new System.Drawing.Size(336, 27);
            this.labelProzName.TabIndex = 1;
            this.labelProzName.Text = "label1";
            this.labelProzName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.Location = new System.Drawing.Point(222, 58);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(42, 14);
            this.labelCat.TabIndex = 2;
            this.labelCat.Text = "label2";
            // 
            // labelSostav
            // 
            this.labelSostav.AutoSize = true;
            this.labelSostav.Location = new System.Drawing.Point(222, 124);
            this.labelSostav.Name = "labelSostav";
            this.labelSostav.Size = new System.Drawing.Size(37, 13);
            this.labelSostav.TabIndex = 4;
            this.labelSostav.Text = "label3";
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuant.Location = new System.Drawing.Point(222, 89);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(42, 14);
            this.labelQuant.TabIndex = 3;
            this.labelQuant.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSostav);
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.labelProzName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(768, 185);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProzName;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelSostav;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.Label label5;
    }
}
