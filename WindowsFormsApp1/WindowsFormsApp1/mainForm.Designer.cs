namespace WindowsFormsApp1
{
    partial class mainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.class11 = new WindowsFormsApp1.Class1();
            this.class12 = new WindowsFormsApp1.Class1();
            this.class13 = new WindowsFormsApp1.Class1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(791, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // class11
            // 
            this.class11.BackColor = System.Drawing.Color.Tomato;
            this.class11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.class11.ForeColor = System.Drawing.Color.White;
            this.class11.Location = new System.Drawing.Point(270, 335);
            this.class11.Name = "class11";
            this.class11.Rounding = 100;
            this.class11.RoundingEnable = true;
            this.class11.Size = new System.Drawing.Size(238, 63);
            this.class11.TabIndex = 6;
            this.class11.Text = "Открыть МК_Рук";
            this.class11.Click += new System.EventHandler(this.class11_Click_1);
            // 
            // class12
            // 
            this.class12.BackColor = System.Drawing.Color.Tomato;
            this.class12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.class12.ForeColor = System.Drawing.Color.White;
            this.class12.Location = new System.Drawing.Point(270, 405);
            this.class12.Name = "class12";
            this.class12.Rounding = 100;
            this.class12.RoundingEnable = true;
            this.class12.Size = new System.Drawing.Size(238, 63);
            this.class12.TabIndex = 7;
            this.class12.Text = "Открыть МК_Зам";
            this.class12.Click += new System.EventHandler(this.class12_Click);
            // 
            // class13
            // 
            this.class13.BackColor = System.Drawing.Color.Tomato;
            this.class13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.class13.ForeColor = System.Drawing.Color.White;
            this.class13.Location = new System.Drawing.Point(270, 475);
            this.class13.Name = "class13";
            this.class13.Rounding = 100;
            this.class13.RoundingEnable = true;
            this.class13.Size = new System.Drawing.Size(238, 63);
            this.class13.TabIndex = 8;
            this.class13.Text = "Выход";
            this.class13.Click += new System.EventHandler(this.class13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(794, 601);
            this.Controls.Add(this.class13);
            this.Controls.Add(this.class12);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private Class1 class11;
        private Class1 class12;
        private Class1 class13;
    }
}

