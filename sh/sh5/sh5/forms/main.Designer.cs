namespace sh5
{
    partial class main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьКвадракоптерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКвадракоптерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМеханикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьМеханикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(910, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(205, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКвадракоптерToolStripMenuItem,
            this.удалитьКвадракоптерToolStripMenuItem,
            this.добавитьМеханикаToolStripMenuItem,
            this.удалитьМеханикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьКвадракоптерToolStripMenuItem
            // 
            this.добавитьКвадракоптерToolStripMenuItem.Name = "добавитьКвадракоптерToolStripMenuItem";
            this.добавитьКвадракоптерToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.добавитьКвадракоптерToolStripMenuItem.Text = "добавить квадракоптер";
            this.добавитьКвадракоптерToolStripMenuItem.Click += new System.EventHandler(this.добавитьКвадракоптерToolStripMenuItem_Click);
            // 
            // удалитьКвадракоптерToolStripMenuItem
            // 
            this.удалитьКвадракоптерToolStripMenuItem.Name = "удалитьКвадракоптерToolStripMenuItem";
            this.удалитьКвадракоптерToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.удалитьКвадракоптерToolStripMenuItem.Text = "удалить квадракоптер";
            this.удалитьКвадракоптерToolStripMenuItem.Click += new System.EventHandler(this.удалитьКвадракоптерToolStripMenuItem_Click);
            // 
            // добавитьМеханикаToolStripMenuItem
            // 
            this.добавитьМеханикаToolStripMenuItem.Name = "добавитьМеханикаToolStripMenuItem";
            this.добавитьМеханикаToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.добавитьМеханикаToolStripMenuItem.Text = "добавить механика";
            this.добавитьМеханикаToolStripMenuItem.Click += new System.EventHandler(this.добавитьМеханикаToolStripMenuItem_Click);
            // 
            // удалитьМеханикаToolStripMenuItem
            // 
            this.удалитьМеханикаToolStripMenuItem.Name = "удалитьМеханикаToolStripMenuItem";
            this.удалитьМеханикаToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.удалитьМеханикаToolStripMenuItem.Text = "удалить механика";
            this.удалитьМеханикаToolStripMenuItem.Click += new System.EventHandler(this.удалитьМеханикаToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКвадракоптерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКвадракоптерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМеханикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьМеханикаToolStripMenuItem;
    }
}

