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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатПоискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатСортировокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.результатСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатПоискаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.поТипуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(22, 74);
            this.textBoxNumber.MaxLength = 20;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(309, 22);
            this.textBoxNumber.TabIndex = 0;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            this.textBoxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(22, 128);
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
            this.ToOwner.Location = new System.Drawing.Point(22, 210);
            this.ToOwner.Name = "ToOwner";
            this.ToOwner.Size = new System.Drawing.Size(309, 41);
            this.ToOwner.TabIndex = 2;
            this.ToOwner.Text = "Информация о владельце";
            this.ToOwner.UseVisualStyleBackColor = false;
            this.ToOwner.Click += new System.EventHandler(this.ToOwner_Click);
            this.ToOwner.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.ToOwner.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // ToHistory
            // 
            this.ToHistory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToHistory.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToHistory.Location = new System.Drawing.Point(22, 257);
            this.ToHistory.Name = "ToHistory";
            this.ToHistory.Size = new System.Drawing.Size(309, 41);
            this.ToHistory.TabIndex = 3;
            this.ToHistory.Text = "История операций";
            this.ToHistory.UseVisualStyleBackColor = false;
            this.ToHistory.Click += new System.EventHandler(this.ToHistory_Click);
            this.ToHistory.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.ToHistory.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 45);
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
            this.label2.Location = new System.Drawing.Point(17, 99);
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
            this.comboBox1.Location = new System.Drawing.Point(22, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 153);
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
            this.label6.Location = new System.Drawing.Point(17, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата открытия:";
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonView.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonView.Location = new System.Drawing.Point(359, 556);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(224, 119);
            this.buttonView.TabIndex = 17;
            this.buttonView.Text = "Вывод";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            this.buttonView.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonView.MouseHover += new System.EventHandler(this.buttonShow_MouseHover);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClear.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(593, 556);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(224, 119);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonClear.MouseHover += new System.EventHandler(this.buttonClear_MouseHover);
            // 
            // buttonInXML
            // 
            this.buttonInXML.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInXML.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonInXML.Location = new System.Drawing.Point(359, 682);
            this.buttonInXML.Name = "buttonInXML";
            this.buttonInXML.Size = new System.Drawing.Size(224, 119);
            this.buttonInXML.TabIndex = 19;
            this.buttonInXML.Text = "Сохранение информации в XML";
            this.buttonInXML.UseVisualStyleBackColor = false;
            this.buttonInXML.Click += new System.EventHandler(this.buttonInXML_Click);
            this.buttonInXML.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonInXML.MouseHover += new System.EventHandler(this.buttonSaveXML_MouseHover);
            // 
            // buttonFromXML
            // 
            this.buttonFromXML.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFromXML.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonFromXML.Location = new System.Drawing.Point(589, 682);
            this.buttonFromXML.Name = "buttonFromXML";
            this.buttonFromXML.Size = new System.Drawing.Size(228, 119);
            this.buttonFromXML.TabIndex = 20;
            this.buttonFromXML.Text = "Чтение информации из XML";
            this.buttonFromXML.UseVisualStyleBackColor = false;
            this.buttonFromXML.Click += new System.EventHandler(this.buttonFromXML_Click);
            this.buttonFromXML.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonFromXML.MouseHover += new System.EventHandler(this.buttonShowXML_MouseHover);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(359, 74);
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
            this.label7.Location = new System.Drawing.Point(354, 45);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 314);
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
            this.groupBox2.Location = new System.Drawing.Point(22, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 65);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подключить интернет-банкинг:";
            // 
            // dateOpen
            // 
            this.dateOpen.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOpen.Location = new System.Drawing.Point(22, 491);
            this.dateOpen.Name = "dateOpen";
            this.dateOpen.Size = new System.Drawing.Size(309, 34);
            this.dateOpen.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.AboutProgrammToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TypeToolStripMenuItem,
            this.DateToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // TypeToolStripMenuItem
            // 
            this.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem";
            this.TypeToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.TypeToolStripMenuItem.Text = "По типу вклада";
            this.TypeToolStripMenuItem.Click += new System.EventHandler(this.TypeToolStripMenuItem_Click);
            // 
            // DateToolStripMenuItem
            // 
            this.DateToolStripMenuItem.Name = "DateToolStripMenuItem";
            this.DateToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.DateToolStripMenuItem.Text = "По дате открытия счёта";
            this.DateToolStripMenuItem.Click += new System.EventHandler(this.поДатеОткрытияСчётаToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.результатПоискаToolStripMenuItem,
            this.результатСортировокToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // результатПоискаToolStripMenuItem
            // 
            this.результатПоискаToolStripMenuItem.Name = "результатПоискаToolStripMenuItem";
            this.результатПоискаToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.результатПоискаToolStripMenuItem.Text = "Результат поиска";
            this.результатПоискаToolStripMenuItem.Click += new System.EventHandler(this.SearchResultToolStripMenuItem_Click);
            // 
            // результатСортировокToolStripMenuItem
            // 
            this.результатСортировокToolStripMenuItem.Name = "результатСортировокToolStripMenuItem";
            this.результатСортировокToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.результатСортировокToolStripMenuItem.Text = "Результат сортировок";
            this.результатСортировокToolStripMenuItem.Click += new System.EventHandler(this.SortResultToolStripMenuItem_Click);
            // 
            // AboutProgrammToolStripMenuItem
            // 
            this.AboutProgrammToolStripMenuItem.Name = "AboutProgrammToolStripMenuItem";
            this.AboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.AboutProgrammToolStripMenuItem.Text = "О программе";
            this.AboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.AboutProgrammToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.toolStripButton2,
            this.toolStripSplitButton1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(855, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 820);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.результатСортировкиToolStripMenuItem,
            this.результатПоискаToolStripMenuItem1});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(37, 24);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // результатСортировкиToolStripMenuItem
            // 
            this.результатСортировкиToolStripMenuItem.Name = "результатСортировкиToolStripMenuItem";
            this.результатСортировкиToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.результатСортировкиToolStripMenuItem.Text = "Результат сортировки";
            this.результатСортировкиToolStripMenuItem.Click += new System.EventHandler(this.результатСортировкиToolStripMenuItem_Click);
            // 
            // результатПоискаToolStripMenuItem1
            // 
            this.результатПоискаToolStripMenuItem1.Name = "результатПоискаToolStripMenuItem1";
            this.результатПоискаToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.результатПоискаToolStripMenuItem1.Text = "Результат поиска";
            this.результатПоискаToolStripMenuItem1.Click += new System.EventHandler(this.результатПоискаToolStripMenuItem1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поТипуToolStripMenuItem,
            this.поДатеToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(37, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // поТипуToolStripMenuItem
            // 
            this.поТипуToolStripMenuItem.Name = "поТипуToolStripMenuItem";
            this.поТипуToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.поТипуToolStripMenuItem.Text = "По типу";
            this.поТипуToolStripMenuItem.Click += new System.EventHandler(this.поТипуToolStripMenuItem_Click);
            // 
            // поДатеToolStripMenuItem
            // 
            this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
            this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.поДатеToolStripMenuItem.Text = "По дате";
            this.поДатеToolStripMenuItem.Click += new System.EventHandler(this.поДатеToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 556);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 245);
            this.textBox1.TabIndex = 28;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 823);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(855, 25);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 20);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 20);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(200, 20);
            this.toolStripStatusLabel4.Text = "Количество объектов";
            this.toolStripStatusLabel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Show_Count);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(895, 848);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счёт";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатПоискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатСортировокToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem результатСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатПоискаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem поТипуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}

