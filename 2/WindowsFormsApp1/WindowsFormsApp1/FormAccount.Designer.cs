namespace WindowsFormsApp1
{
    partial class FormAccount
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.ToOwner = new System.Windows.Forms.Button();
            this.ToHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonSms1 = new System.Windows.Forms.RadioButton();
            this.radioButtonInternet1 = new System.Windows.Forms.RadioButton();
            this.radioButtonInternet2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSms2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonInXML = new System.Windows.Forms.Button();
            this.buttonFromXML = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateOpen = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(17, 39);
            this.textBoxNumber.MaxLength = 20;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(309, 22);
            this.textBoxNumber.TabIndex = 0;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            this.textBoxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(17, 93);
            this.textBoxBalance.MaxLength = 15;
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(309, 22);
            this.textBoxBalance.TabIndex = 1;
            this.textBoxBalance.TextChanged += new System.EventHandler(this.Balance_enter);
            this.textBoxBalance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Balance_Click);
            this.textBoxBalance.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // ToOwner
            // 
            this.ToOwner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToOwner.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToOwner.Location = new System.Drawing.Point(17, 175);
            this.ToOwner.Name = "ToOwner";
            this.ToOwner.Size = new System.Drawing.Size(309, 41);
            this.ToOwner.TabIndex = 2;
            this.ToOwner.Text = "Информация о владельце";
            this.ToOwner.UseVisualStyleBackColor = false;
            this.ToOwner.Click += new System.EventHandler(this.ToOwner_Click);
            // 
            // ToHistory
            // 
            this.ToHistory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToHistory.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToHistory.Location = new System.Drawing.Point(17, 222);
            this.ToHistory.Name = "ToHistory";
            this.ToHistory.Size = new System.Drawing.Size(309, 41);
            this.ToHistory.TabIndex = 3;
            this.ToHistory.Text = "История операций";
            this.ToHistory.UseVisualStyleBackColor = false;
            this.ToHistory.Click += new System.EventHandler(this.ToHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер счёта:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Баланс:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип вклада:";
            // 
            // radioButtonSms1
            // 
            this.radioButtonSms1.AutoSize = true;
            this.radioButtonSms1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSms1.Location = new System.Drawing.Point(6, 30);
            this.radioButtonSms1.Name = "radioButtonSms1";
            this.radioButtonSms1.Size = new System.Drawing.Size(56, 30);
            this.radioButtonSms1.TabIndex = 9;
            this.radioButtonSms1.TabStop = true;
            this.radioButtonSms1.Text = "Да";
            this.radioButtonSms1.UseVisualStyleBackColor = true;
            this.radioButtonSms1.CheckedChanged += new System.EventHandler(this.Sms_Changed);
            // 
            // radioButtonInternet1
            // 
            this.radioButtonInternet1.AutoSize = true;
            this.radioButtonInternet1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInternet1.Location = new System.Drawing.Point(6, 29);
            this.radioButtonInternet1.Name = "radioButtonInternet1";
            this.radioButtonInternet1.Size = new System.Drawing.Size(56, 30);
            this.radioButtonInternet1.TabIndex = 10;
            this.radioButtonInternet1.TabStop = true;
            this.radioButtonInternet1.Text = "Да";
            this.radioButtonInternet1.UseVisualStyleBackColor = true;
            this.radioButtonInternet1.CheckedChanged += new System.EventHandler(this.Banking_Changed);
            // 
            // radioButtonInternet2
            // 
            this.radioButtonInternet2.AutoSize = true;
            this.radioButtonInternet2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInternet2.Location = new System.Drawing.Point(159, 29);
            this.radioButtonInternet2.Name = "radioButtonInternet2";
            this.radioButtonInternet2.Size = new System.Drawing.Size(68, 30);
            this.radioButtonInternet2.TabIndex = 11;
            this.radioButtonInternet2.TabStop = true;
            this.radioButtonInternet2.Text = "Нет";
            this.radioButtonInternet2.UseVisualStyleBackColor = true;
            this.radioButtonInternet2.CheckedChanged += new System.EventHandler(this.Banking_Changed);
            // 
            // radioButtonSms2
            // 
            this.radioButtonSms2.AutoSize = true;
            this.radioButtonSms2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSms2.Location = new System.Drawing.Point(159, 30);
            this.radioButtonSms2.Name = "radioButtonSms2";
            this.radioButtonSms2.Size = new System.Drawing.Size(68, 30);
            this.radioButtonSms2.TabIndex = 12;
            this.radioButtonSms2.TabStop = true;
            this.radioButtonSms2.Text = "Нет";
            this.radioButtonSms2.UseVisualStyleBackColor = true;
            this.radioButtonSms2.CheckedChanged += new System.EventHandler(this.Sms_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата открытия:";
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonView.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonView.Location = new System.Drawing.Point(354, 521);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(224, 73);
            this.buttonView.TabIndex = 17;
            this.buttonView.Text = "Вывод";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClear.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(588, 521);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(224, 73);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonInXML
            // 
            this.buttonInXML.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInXML.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonInXML.Location = new System.Drawing.Point(354, 600);
            this.buttonInXML.Name = "buttonInXML";
            this.buttonInXML.Size = new System.Drawing.Size(224, 73);
            this.buttonInXML.TabIndex = 19;
            this.buttonInXML.Text = "Сохранение информации в XML";
            this.buttonInXML.UseVisualStyleBackColor = false;
            this.buttonInXML.Click += new System.EventHandler(this.buttonInXML_Click);
            // 
            // buttonFromXML
            // 
            this.buttonFromXML.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFromXML.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonFromXML.Location = new System.Drawing.Point(588, 600);
            this.buttonFromXML.Name = "buttonFromXML";
            this.buttonFromXML.Size = new System.Drawing.Size(224, 73);
            this.buttonFromXML.TabIndex = 20;
            this.buttonFromXML.Text = "Чтение информации из XML";
            this.buttonFromXML.UseVisualStyleBackColor = false;
            this.buttonFromXML.Click += new System.EventHandler(this.buttonFromXML_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(354, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(458, 451);
            this.textBox2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(349, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Информация:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSms1);
            this.groupBox1.Controls.Add(this.radioButtonSms2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(17, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 70);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключить SMS оповещения:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonInternet1);
            this.groupBox2.Controls.Add(this.radioButtonInternet2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(17, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 65);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подключить интернет-банкинг:";
            // 
            // dateOpen
            // 
            this.dateOpen.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOpen.Location = new System.Drawing.Point(17, 456);
            this.dateOpen.Name = "dateOpen";
            this.dateOpen.Size = new System.Drawing.Size(309, 34);
            this.dateOpen.TabIndex = 6;
            this.dateOpen.ValueChanged += new System.EventHandler(this.dateOpen_ValueChanged);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(829, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonFromXML);
            this.Controls.Add(this.buttonInXML);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToHistory);
            this.Controls.Add(this.ToOwner);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxNumber);
            this.Name = "FormAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счёт";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Button ToOwner;
        private System.Windows.Forms.Button ToHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonSms1;
        private System.Windows.Forms.RadioButton radioButtonInternet1;
        private System.Windows.Forms.RadioButton radioButtonInternet2;
        private System.Windows.Forms.RadioButton radioButtonSms2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonInXML;
        private System.Windows.Forms.Button buttonFromXML;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateOpen;
    }
}

