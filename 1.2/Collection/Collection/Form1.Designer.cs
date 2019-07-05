namespace Collection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SortUp = new System.Windows.Forms.Button();
            this.SortDown = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(275, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите размер коллекции:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(266, 426);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // SortUp
            // 
            this.SortUp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SortUp.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortUp.Location = new System.Drawing.Point(275, 99);
            this.SortUp.Name = "SortUp";
            this.SortUp.Size = new System.Drawing.Size(250, 63);
            this.SortUp.TabIndex = 6;
            this.SortUp.Text = "Сортировка по возрастанию";
            this.SortUp.UseVisualStyleBackColor = false;
            this.SortUp.Click += new System.EventHandler(this.SortUp_Click);
            // 
            // SortDown
            // 
            this.SortDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SortDown.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortDown.Location = new System.Drawing.Point(275, 168);
            this.SortDown.Name = "SortDown";
            this.SortDown.Size = new System.Drawing.Size(250, 63);
            this.SortDown.TabIndex = 7;
            this.SortDown.Text = "Сортировка по убыванию";
            this.SortDown.UseVisualStyleBackColor = false;
            this.SortDown.Click += new System.EventHandler(this.SortDown_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(275, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 63);
            this.button3.TabIndex = 8;
            this.button3.Text = "Кто любит собак и кошек?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonLINQ1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(275, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 63);
            this.button4.TabIndex = 9;
            this.button4.Text = "Три старших человека";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonLINQ2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(275, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 63);
            this.button5.TabIndex = 10;
            this.button5.Text = "Буква \'и\' на втором месте в имени";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonLINQ3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(448, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Генерация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //// 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(531, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(285, 426);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 444);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SortDown);
            this.Controls.Add(this.SortUp);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SortUp;
        private System.Windows.Forms.Button SortDown;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
    }
}

