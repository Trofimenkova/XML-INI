namespace ApplicationSystems
{
    partial class Form1
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
            this.convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(62, 32);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(213, 23);
            this.convert.TabIndex = 0;
            this.convert.Text = "Конвертировать XML-файл в INI";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 93);
            this.Controls.Add(this.convert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Трансформация файла XML-INI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convert;
    }
}

