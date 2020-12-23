namespace Test4education
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
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ToBinarySystem = new System.Windows.Forms.Button();
            this.Tens = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FromNumSys = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Input)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(14, 198);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(378, 20);
            this.OutputTextBox.TabIndex = 1;
            // 
            // ToBinarySystem
            // 
            this.ToBinarySystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToBinarySystem.Location = new System.Drawing.Point(14, 113);
            this.ToBinarySystem.Name = "ToBinarySystem";
            this.ToBinarySystem.Size = new System.Drawing.Size(124, 47);
            this.ToBinarySystem.TabIndex = 2;
            this.ToBinarySystem.Text = "Перевести в двоичную систему";
            this.ToBinarySystem.UseVisualStyleBackColor = true;
            this.ToBinarySystem.Click += new System.EventHandler(this.ToBinarySystem_Click);
            // 
            // Tens
            // 
            this.Tens.Location = new System.Drawing.Point(11, 61);
            this.Tens.Name = "Tens";
            this.Tens.Size = new System.Drawing.Size(381, 14);
            this.Tens.TabIndex = 3;
            this.Tens.Text = "Введите число в десятичной системе счисления";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ваше число преобразованное в двоичную систему";
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Location = new System.Drawing.Point(14, 87);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(382, 20);
            this.Input.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(142, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Перевести в восьмиричную систему";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(272, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Перевести в шестнадцатиричную систему";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Из какой системы сисления будем преобразовывать?";
            // 
            // FromNumSys
            // 
            this.FromNumSys.FormattingEnabled = true;
            this.FromNumSys.Items.AddRange(new object[] {
            "Десятичное (целое)",
            "Десятичное (с дробной частью)",
            "Двоичное",
            "Восьмеричное",
            "Шестнадцатиричное"});
            this.FromNumSys.Location = new System.Drawing.Point(15, 26);
            this.FromNumSys.Name = "FromNumSys";
            this.FromNumSys.Size = new System.Drawing.Size(121, 21);
            this.FromNumSys.TabIndex = 13;
            this.FromNumSys.SelectedIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 239);
            this.Controls.Add(this.FromNumSys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tens);
            this.Controls.Add(this.ToBinarySystem);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Main";
            this.Text = "Перевод из 10-ой в 2-ую систему счисления";
            ((System.ComponentModel.ISupportInitialize)(this.Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ToBinarySystem;
        private System.Windows.Forms.Label Tens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FromNumSys;
    }
}

