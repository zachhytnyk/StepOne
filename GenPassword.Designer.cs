namespace StepOne
{
    partial class GenPassword
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.engLetterCheck = new System.Windows.Forms.CheckBox();
            this.CapEngLettersCheck = new System.Windows.Forms.CheckBox();
            this.RuLattersCheck = new System.Windows.Forms.CheckBox();
            this.CapRuLattersCheck = new System.Windows.Forms.CheckBox();
            this.NumbersCheck = new System.Windows.Forms.CheckBox();
            this.SpecialSymbolsCheck = new System.Windows.Forms.CheckBox();
            this.AllCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(180, 12);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 169);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(426, 81);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Соль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // engLetterCheck
            // 
            this.engLetterCheck.AutoSize = true;
            this.engLetterCheck.Location = new System.Drawing.Point(15, 54);
            this.engLetterCheck.Name = "engLetterCheck";
            this.engLetterCheck.Size = new System.Drawing.Size(119, 17);
            this.engLetterCheck.TabIndex = 5;
            this.engLetterCheck.Text = "английские буквы";
            this.engLetterCheck.UseVisualStyleBackColor = true;
            // 
            // CapEngLettersCheck
            // 
            this.CapEngLettersCheck.AutoSize = true;
            this.CapEngLettersCheck.Location = new System.Drawing.Point(15, 77);
            this.CapEngLettersCheck.Name = "CapEngLettersCheck";
            this.CapEngLettersCheck.Size = new System.Drawing.Size(166, 17);
            this.CapEngLettersCheck.TabIndex = 6;
            this.CapEngLettersCheck.Text = "большие английские буквы";
            this.CapEngLettersCheck.UseVisualStyleBackColor = true;
            // 
            // RuLattersCheck
            // 
            this.RuLattersCheck.AutoSize = true;
            this.RuLattersCheck.Location = new System.Drawing.Point(231, 54);
            this.RuLattersCheck.Name = "RuLattersCheck";
            this.RuLattersCheck.Size = new System.Drawing.Size(101, 17);
            this.RuLattersCheck.TabIndex = 7;
            this.RuLattersCheck.Text = "русские буквы";
            this.RuLattersCheck.UseVisualStyleBackColor = true;
            // 
            // CapRuLattersCheck
            // 
            this.CapRuLattersCheck.AutoSize = true;
            this.CapRuLattersCheck.Location = new System.Drawing.Point(231, 77);
            this.CapRuLattersCheck.Name = "CapRuLattersCheck";
            this.CapRuLattersCheck.Size = new System.Drawing.Size(148, 17);
            this.CapRuLattersCheck.TabIndex = 8;
            this.CapRuLattersCheck.Text = "большие русские буквы";
            this.CapRuLattersCheck.UseVisualStyleBackColor = true;
            // 
            // NumbersCheck
            // 
            this.NumbersCheck.AutoSize = true;
            this.NumbersCheck.Location = new System.Drawing.Point(231, 100);
            this.NumbersCheck.Name = "NumbersCheck";
            this.NumbersCheck.Size = new System.Drawing.Size(60, 17);
            this.NumbersCheck.TabIndex = 9;
            this.NumbersCheck.Text = "цифры";
            this.NumbersCheck.UseVisualStyleBackColor = true;
            // 
            // SpecialSymbolsCheck
            // 
            this.SpecialSymbolsCheck.AutoSize = true;
            this.SpecialSymbolsCheck.Location = new System.Drawing.Point(15, 100);
            this.SpecialSymbolsCheck.Name = "SpecialSymbolsCheck";
            this.SpecialSymbolsCheck.Size = new System.Drawing.Size(143, 17);
            this.SpecialSymbolsCheck.TabIndex = 10;
            this.SpecialSymbolsCheck.Text = "специальные символы";
            this.SpecialSymbolsCheck.UseVisualStyleBackColor = true;
            // 
            // AllCheck
            // 
            this.AllCheck.AutoSize = true;
            this.AllCheck.Location = new System.Drawing.Point(15, 123);
            this.AllCheck.Name = "AllCheck";
            this.AllCheck.Size = new System.Drawing.Size(45, 17);
            this.AllCheck.TabIndex = 11;
            this.AllCheck.Text = "Все";
            this.AllCheck.UseVisualStyleBackColor = true;
            // 
            // GenPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 327);
            this.Controls.Add(this.AllCheck);
            this.Controls.Add(this.SpecialSymbolsCheck);
            this.Controls.Add(this.NumbersCheck);
            this.Controls.Add(this.CapRuLattersCheck);
            this.Controls.Add(this.RuLattersCheck);
            this.Controls.Add(this.CapEngLettersCheck);
            this.Controls.Add(this.engLetterCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "GenPassword";
            this.Text = "Генератор паролей";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox engLetterCheck;
        private System.Windows.Forms.CheckBox CapEngLettersCheck;
        private System.Windows.Forms.CheckBox RuLattersCheck;
        private System.Windows.Forms.CheckBox CapRuLattersCheck;
        private System.Windows.Forms.CheckBox NumbersCheck;
        private System.Windows.Forms.CheckBox SpecialSymbolsCheck;
        private System.Windows.Forms.CheckBox AllCheck;
    }
}