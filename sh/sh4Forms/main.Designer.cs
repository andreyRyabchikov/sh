
namespace sh4Forms
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
            this.CreateObjButton = new System.Windows.Forms.Button();
            this.RunMethodButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ObjComboBox = new System.Windows.Forms.ComboBox();
            this.MethodsComboBox = new System.Windows.Forms.ComboBox();
            this.InputFieldsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.objectFieldsListBox = new System.Windows.Forms.ListBox();
            this.methodsFieldsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateObjButton
            // 
            this.CreateObjButton.Location = new System.Drawing.Point(244, 98);
            this.CreateObjButton.Name = "CreateObjButton";
            this.CreateObjButton.Size = new System.Drawing.Size(121, 26);
            this.CreateObjButton.TabIndex = 1;
            this.CreateObjButton.Text = "создать объект";
            this.CreateObjButton.UseVisualStyleBackColor = true;
            this.CreateObjButton.Click += new System.EventHandler(this.CreateObjButton_Click);
            // 
            // RunMethodButton
            // 
            this.RunMethodButton.Location = new System.Drawing.Point(244, 162);
            this.RunMethodButton.Name = "RunMethodButton";
            this.RunMethodButton.Size = new System.Drawing.Size(121, 26);
            this.RunMethodButton.TabIndex = 2;
            this.RunMethodButton.Text = "выполнить метод";
            this.RunMethodButton.UseVisualStyleBackColor = true;
            this.RunMethodButton.Click += new System.EventHandler(this.RunMethodButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип машины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Метод";
            // 
            // ObjComboBox
            // 
            this.ObjComboBox.FormattingEnabled = true;
            this.ObjComboBox.Location = new System.Drawing.Point(244, 31);
            this.ObjComboBox.Name = "ObjComboBox";
            this.ObjComboBox.Size = new System.Drawing.Size(121, 21);
            this.ObjComboBox.TabIndex = 5;
            this.ObjComboBox.SelectedIndexChanged += new System.EventHandler(this.ObjComboBox_SelectedIndexChanged);
            // 
            // MethodsComboBox
            // 
            this.MethodsComboBox.FormattingEnabled = true;
            this.MethodsComboBox.Location = new System.Drawing.Point(244, 71);
            this.MethodsComboBox.Name = "MethodsComboBox";
            this.MethodsComboBox.Size = new System.Drawing.Size(121, 21);
            this.MethodsComboBox.TabIndex = 6;
            this.MethodsComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodsComboBox_SelectedIndexChanged);
            // 
            // InputFieldsButton
            // 
            this.InputFieldsButton.Location = new System.Drawing.Point(244, 130);
            this.InputFieldsButton.Name = "InputFieldsButton";
            this.InputFieldsButton.Size = new System.Drawing.Size(121, 26);
            this.InputFieldsButton.TabIndex = 7;
            this.InputFieldsButton.Text = "ввести данные";
            this.InputFieldsButton.UseVisualStyleBackColor = true;
            this.InputFieldsButton.Click += new System.EventHandler(this.InputFieldsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Поля обьекта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Параметры метода";
            // 
            // objectFieldsListBox
            // 
            this.objectFieldsListBox.FormattingEnabled = true;
            this.objectFieldsListBox.Location = new System.Drawing.Point(12, 25);
            this.objectFieldsListBox.Name = "objectFieldsListBox";
            this.objectFieldsListBox.Size = new System.Drawing.Size(223, 134);
            this.objectFieldsListBox.TabIndex = 11;
            // 
            // methodsFieldsListBox
            // 
            this.methodsFieldsListBox.FormattingEnabled = true;
            this.methodsFieldsListBox.Location = new System.Drawing.Point(12, 187);
            this.methodsFieldsListBox.Name = "methodsFieldsListBox";
            this.methodsFieldsListBox.Size = new System.Drawing.Size(223, 82);
            this.methodsFieldsListBox.TabIndex = 12;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 279);
            this.Controls.Add(this.methodsFieldsListBox);
            this.Controls.Add(this.objectFieldsListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputFieldsButton);
            this.Controls.Add(this.MethodsComboBox);
            this.Controls.Add(this.ObjComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunMethodButton);
            this.Controls.Add(this.CreateObjButton);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateObjButton;
        private System.Windows.Forms.Button RunMethodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ObjComboBox;
        private System.Windows.Forms.ComboBox MethodsComboBox;
        private System.Windows.Forms.Button InputFieldsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox objectFieldsListBox;
        private System.Windows.Forms.ListBox methodsFieldsListBox;
    }
}

