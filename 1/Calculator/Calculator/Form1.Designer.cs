namespace Calculator
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
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTo8 = new System.Windows.Forms.Button();
            this.buttonTo2 = new System.Windows.Forms.Button();
            this.buttonXor = new System.Windows.Forms.Button();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNot = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonTo10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(36, 87);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(97, 39);
            this.buttonC.TabIndex = 0;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(148, 87);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 39);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "<-";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTo8
            // 
            this.buttonTo8.Location = new System.Drawing.Point(148, 177);
            this.buttonTo8.Name = "buttonTo8";
            this.buttonTo8.Size = new System.Drawing.Size(97, 39);
            this.buttonTo8.TabIndex = 14;
            this.buttonTo8.Text = "a8";
            this.buttonTo8.UseVisualStyleBackColor = true;
            this.buttonTo8.Click += new System.EventHandler(this.buttonTo8_Click);
            // 
            // buttonTo2
            // 
            this.buttonTo2.Location = new System.Drawing.Point(36, 177);
            this.buttonTo2.Name = "buttonTo2";
            this.buttonTo2.Size = new System.Drawing.Size(97, 39);
            this.buttonTo2.TabIndex = 15;
            this.buttonTo2.Text = "a2";
            this.buttonTo2.UseVisualStyleBackColor = true;
            this.buttonTo2.Click += new System.EventHandler(this.buttonTo2_Click);
            // 
            // buttonXor
            // 
            this.buttonXor.Location = new System.Drawing.Point(261, 132);
            this.buttonXor.Name = "buttonXor";
            this.buttonXor.Size = new System.Drawing.Size(97, 39);
            this.buttonXor.TabIndex = 16;
            this.buttonXor.Text = "XOR";
            this.buttonXor.UseVisualStyleBackColor = true;
            this.buttonXor.Click += new System.EventHandler(this.buttonXor_Click);
            // 
            // buttonOr
            // 
            this.buttonOr.Location = new System.Drawing.Point(148, 132);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(97, 39);
            this.buttonOr.TabIndex = 17;
            this.buttonOr.Text = "OR";
            this.buttonOr.UseVisualStyleBackColor = true;
            this.buttonOr.Click += new System.EventHandler(this.buttonOr_Click);
            // 
            // buttonAnd
            // 
            this.buttonAnd.Location = new System.Drawing.Point(36, 132);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(97, 39);
            this.buttonAnd.TabIndex = 18;
            this.buttonAnd.Text = "AND";
            this.buttonAnd.UseVisualStyleBackColor = true;
            this.buttonAnd.Click += new System.EventHandler(this.buttonAnd_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(261, 87);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(97, 39);
            this.button0.TabIndex = 20;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNot
            // 
            this.buttonNot.Location = new System.Drawing.Point(376, 132);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(97, 39);
            this.buttonNot.TabIndex = 23;
            this.buttonNot.Text = "NOT";
            this.buttonNot.UseVisualStyleBackColor = true;
            this.buttonNot.Click += new System.EventHandler(this.buttonNot_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(376, 177);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(97, 39);
            this.button16.TabIndex = 24;
            this.button16.Text = "a16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.buttonTo16_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(36, 37);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(97, 44);
            this.buttonEqual.TabIndex = 27;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonTo10
            // 
            this.buttonTo10.Location = new System.Drawing.Point(261, 177);
            this.buttonTo10.Name = "buttonTo10";
            this.buttonTo10.Size = new System.Drawing.Size(97, 39);
            this.buttonTo10.TabIndex = 28;
            this.buttonTo10.Text = "a10";
            this.buttonTo10.UseVisualStyleBackColor = true;
            this.buttonTo10.Click += new System.EventHandler(this.buttonTo10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 44);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += textBox1_KeyUp;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(501, 235);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTo10);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.buttonNot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonAnd);
            this.Controls.Add(this.buttonOr);
            this.Controls.Add(this.buttonXor);
            this.Controls.Add(this.buttonTo2);
            this.Controls.Add(this.buttonTo8);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonC);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTo8;
        private System.Windows.Forms.Button buttonTo2;
        private System.Windows.Forms.Button buttonXor;
        private System.Windows.Forms.Button buttonOr;
        private System.Windows.Forms.Button buttonAnd;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNot;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonTo10;
        private System.Windows.Forms.TextBox textBox1;
    }
}

