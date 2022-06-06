namespace sh5
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вызватьоператораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМеханикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстрыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медленныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызватьоператораToolStripMenuItem,
            this.добавитьМеханикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // вызватьоператораToolStripMenuItem
            // 
            this.вызватьоператораToolStripMenuItem.Name = "вызватьоператораToolStripMenuItem";
            this.вызватьоператораToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.вызватьоператораToolStripMenuItem.Text = "вызвать оператора";
            this.вызватьоператораToolStripMenuItem.Click += new System.EventHandler(this.ВызватьОператораToolStripMenuItem_Click);
            // 
            // добавитьМеханикаToolStripMenuItem
            // 
            this.добавитьМеханикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.быстрыйToolStripMenuItem,
            this.среднийToolStripMenuItem,
            this.медленныйToolStripMenuItem});
            this.добавитьМеханикаToolStripMenuItem.Name = "добавитьМеханикаToolStripMenuItem";
            this.добавитьМеханикаToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.добавитьМеханикаToolStripMenuItem.Text = "добавить механика";
            // 
            // быстрыйToolStripMenuItem
            // 
            this.быстрыйToolStripMenuItem.Name = "быстрыйToolStripMenuItem";
            this.быстрыйToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.быстрыйToolStripMenuItem.Text = "быстрый";
            this.быстрыйToolStripMenuItem.Click += new System.EventHandler(this.БыстрыйToolStripMenuItem_Click);
            // 
            // среднийToolStripMenuItem
            // 
            this.среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            this.среднийToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.среднийToolStripMenuItem.Text = "средний";
            this.среднийToolStripMenuItem.Click += new System.EventHandler(this.СреднийToolStripMenuItem_Click);
            // 
            // медленныйToolStripMenuItem
            // 
            this.медленныйToolStripMenuItem.Name = "медленныйToolStripMenuItem";
            this.медленныйToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.медленныйToolStripMenuItem.Text = "медленный";
            this.медленныйToolStripMenuItem.Click += new System.EventHandler(this.МедленныйToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(869, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(246, 411);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 411);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вызватьоператораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМеханикаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem быстрыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медленныйToolStripMenuItem;
    }
}

