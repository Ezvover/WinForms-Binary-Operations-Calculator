namespace laba1reborn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AndRadio = new System.Windows.Forms.RadioButton();
            this.OrRadio = new System.Windows.Forms.RadioButton();
            this.XORRadio = new System.Windows.Forms.RadioButton();
            this.NotFirstRadio = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BinaryResult = new System.Windows.Forms.Label();
            this.OctalResult = new System.Windows.Forms.Label();
            this.DecimalResult = new System.Windows.Forms.Label();
            this.HexResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NotSecondRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(531, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 23);
            this.textBox2.TabIndex = 1;
            // 
            // AndRadio
            // 
            this.AndRadio.AutoSize = true;
            this.AndRadio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AndRadio.Location = new System.Drawing.Point(548, 143);
            this.AndRadio.Name = "AndRadio";
            this.AndRadio.Size = new System.Drawing.Size(55, 41);
            this.AndRadio.TabIndex = 2;
            this.AndRadio.TabStop = true;
            this.AndRadio.Text = "И";
            this.AndRadio.UseVisualStyleBackColor = true;
            // 
            // OrRadio
            // 
            this.OrRadio.AutoSize = true;
            this.OrRadio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrRadio.Location = new System.Drawing.Point(548, 183);
            this.OrRadio.Name = "OrRadio";
            this.OrRadio.Size = new System.Drawing.Size(85, 41);
            this.OrRadio.TabIndex = 3;
            this.OrRadio.TabStop = true;
            this.OrRadio.Text = "Или";
            this.OrRadio.UseVisualStyleBackColor = true;
            // 
            // XORRadio
            // 
            this.XORRadio.AutoSize = true;
            this.XORRadio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XORRadio.Location = new System.Drawing.Point(548, 223);
            this.XORRadio.Name = "XORRadio";
            this.XORRadio.Size = new System.Drawing.Size(139, 41);
            this.XORRadio.TabIndex = 4;
            this.XORRadio.TabStop = true;
            this.XORRadio.Text = "Иск. или";
            this.XORRadio.UseVisualStyleBackColor = true;
            // 
            // NotFirstRadio
            // 
            this.NotFirstRadio.AutoSize = true;
            this.NotFirstRadio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotFirstRadio.Location = new System.Drawing.Point(548, 261);
            this.NotFirstRadio.Name = "NotFirstRadio";
            this.NotFirstRadio.Size = new System.Drawing.Size(165, 41);
            this.NotFirstRadio.TabIndex = 5;
            this.NotFirstRadio.TabStop = true;
            this.NotFirstRadio.Text = "Не первое";
            this.NotFirstRadio.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(432, 391);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(169, 89);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Считать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(463, 517);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 38);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Очистка";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BinaryResult
            // 
            this.BinaryResult.AutoSize = true;
            this.BinaryResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BinaryResult.Location = new System.Drawing.Point(106, 193);
            this.BinaryResult.Name = "BinaryResult";
            this.BinaryResult.Size = new System.Drawing.Size(179, 30);
            this.BinaryResult.TabIndex = 8;
            this.BinaryResult.Text = "Бинарный ответ";
            // 
            // OctalResult
            // 
            this.OctalResult.AutoSize = true;
            this.OctalResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OctalResult.Location = new System.Drawing.Point(106, 231);
            this.OctalResult.Name = "OctalResult";
            this.OctalResult.Size = new System.Drawing.Size(228, 30);
            this.OctalResult.TabIndex = 9;
            this.OctalResult.Text = "Восьмеричный ответ";
            // 
            // DecimalResult
            // 
            this.DecimalResult.AutoSize = true;
            this.DecimalResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalResult.Location = new System.Drawing.Point(106, 269);
            this.DecimalResult.Name = "DecimalResult";
            this.DecimalResult.Size = new System.Drawing.Size(198, 30);
            this.DecimalResult.TabIndex = 10;
            this.DecimalResult.Text = "Десятичный ответ";
            // 
            // HexResult
            // 
            this.HexResult.AutoSize = true;
            this.HexResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexResult.Location = new System.Drawing.Point(106, 316);
            this.HexResult.Name = "HexResult";
            this.HexResult.Size = new System.Drawing.Size(288, 30);
            this.HexResult.TabIndex = 11;
            this.HexResult.Text = "Шестнадцатиричный ответ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(320, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Первое число";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(535, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Второе число";
            // 
            // NotSecondRadio
            // 
            this.NotSecondRadio.AutoSize = true;
            this.NotSecondRadio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotSecondRadio.Location = new System.Drawing.Point(548, 308);
            this.NotSecondRadio.Name = "NotSecondRadio";
            this.NotSecondRadio.Size = new System.Drawing.Size(162, 41);
            this.NotSecondRadio.TabIndex = 14;
            this.NotSecondRadio.TabStop = true;
            this.NotSecondRadio.Text = "Не второе";
            this.NotSecondRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 626);
            this.Controls.Add(this.NotSecondRadio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HexResult);
            this.Controls.Add(this.DecimalResult);
            this.Controls.Add(this.OctalResult);
            this.Controls.Add(this.BinaryResult);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.NotFirstRadio);
            this.Controls.Add(this.XORRadio);
            this.Controls.Add(this.OrRadio);
            this.Controls.Add(this.AndRadio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton AndRadio;
        private RadioButton OrRadio;
        private RadioButton XORRadio;
        private RadioButton NotFirstRadio;
        private Button CalculateButton;
        private Button ClearButton;
        private Label BinaryResult;
        private Label OctalResult;
        private Label DecimalResult;
        private Label HexResult;
        private Label label5;
        private Label label6;
        private RadioButton NotSecondRadio;
    }
}