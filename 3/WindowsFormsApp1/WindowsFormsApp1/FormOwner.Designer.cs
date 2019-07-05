namespace WindowsFormsApp1
{
    partial class FormOwner
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMidName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxSer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSendOwn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(21, 157);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(266, 22);
            this.textBoxSurname.TabIndex = 10;
            this.textBoxSurname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NotNumbers_Clic);
            this.textBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 103);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(266, 22);
            this.textBoxName.TabIndex = 9;
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NotNumbers_Clic);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxMidName
            // 
            this.textBoxMidName.Location = new System.Drawing.Point(21, 211);
            this.textBoxMidName.Name = "textBoxMidName";
            this.textBoxMidName.Size = new System.Drawing.Size(266, 22);
            this.textBoxMidName.TabIndex = 14;
            this.textBoxMidName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NotNumbers_Clic);
            this.textBoxMidName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Номер паспорта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Серия паспорта:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(481, 25);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(241, 22);
            this.textBoxNum.TabIndex = 17;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNum_TextChanged);
            this.textBoxNum.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxSer
            // 
            this.textBoxSer.Location = new System.Drawing.Point(185, 25);
            this.textBoxSer.Name = "textBoxSer";
            this.textBoxSer.Size = new System.Drawing.Size(102, 22);
            this.textBoxSer.TabIndex = 16;
            this.textBoxSer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NotNumbers_Clic);
            this.textBoxSer.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(315, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Дата рождения:";
            // 
            // buttonSendOwn
            // 
            this.buttonSendOwn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSendOwn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendOwn.Location = new System.Drawing.Point(21, 248);
            this.buttonSendOwn.Name = "buttonSendOwn";
            this.buttonSendOwn.Size = new System.Drawing.Size(266, 76);
            this.buttonSendOwn.TabIndex = 21;
            this.buttonSendOwn.Text = "Отправить";
            this.buttonSendOwn.UseVisualStyleBackColor = false;
            this.buttonSendOwn.Click += new System.EventHandler(this.buttonSendOwn_Click);
            // 
            // FormOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(746, 336);
            this.Controls.Add(this.buttonSendOwn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.textBoxSer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMidName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormOwner";
            this.Text = "FormOwner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMidName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxSer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSendOwn;
    }
}