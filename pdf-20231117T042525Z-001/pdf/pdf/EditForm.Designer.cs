namespace pdf
{
    partial class EditForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.clientNumber = new System.Windows.Forms.TextBox();
            this.client = new System.Windows.Forms.TextBox();
            this.problemDescTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1Priority = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sparesTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.requestStatusCombobox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.finishdate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.helptextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.eqTextBox = new System.Windows.Forms.TextBox();
            this.findEntry = new System.Windows.Forms.Button();
            this.workerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveBtn.Location = new System.Drawing.Point(324, 885);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(291, 39);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clientNumber
            // 
            this.clientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clientNumber.Location = new System.Drawing.Point(212, 711);
            this.clientNumber.Margin = new System.Windows.Forms.Padding(4);
            this.clientNumber.Name = "clientNumber";
            this.clientNumber.Size = new System.Drawing.Size(627, 26);
            this.clientNumber.TabIndex = 31;
            this.clientNumber.TextChanged += new System.EventHandler(this.clientNumber_TextChanged);
            // 
            // client
            // 
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.client.Location = new System.Drawing.Point(212, 649);
            this.client.Margin = new System.Windows.Forms.Padding(4);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(627, 26);
            this.client.TabIndex = 30;
            this.client.TextChanged += new System.EventHandler(this.client_TextChanged);
            // 
            // problemDescTextBox
            // 
            this.problemDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.problemDescTextBox.Location = new System.Drawing.Point(216, 396);
            this.problemDescTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.problemDescTextBox.Multiline = true;
            this.problemDescTextBox.Name = "problemDescTextBox";
            this.problemDescTextBox.Size = new System.Drawing.Size(627, 238);
            this.problemDescTextBox.TabIndex = 29;
            this.problemDescTextBox.TextChanged += new System.EventHandler(this.problemDesc_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(17, 652);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "ФИО клиента";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(17, 711);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Номер телефона";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(15, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Описание проблемы";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(15, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Серийный номер";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(17, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Тип оборудования";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(828, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Редактирование заявки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serialNumber
            // 
            this.serialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serialNumber.Location = new System.Drawing.Point(212, 332);
            this.serialNumber.Margin = new System.Windows.Forms.Padding(4);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(631, 26);
            this.serialNumber.TabIndex = 21;
            this.serialNumber.TextChanged += new System.EventHandler(this.serialNumber_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backBtn.Location = new System.Drawing.Point(623, 885);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(291, 39);
            this.backBtn.TabIndex = 20;
            this.backBtn.Text = "Все заявки";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Дата подачи";
            // 
            // startdate
            // 
            this.startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startdate.Location = new System.Drawing.Point(212, 98);
            this.startdate.Margin = new System.Windows.Forms.Padding(4);
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            this.startdate.Size = new System.Drawing.Size(631, 26);
            this.startdate.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(17, 754);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Приоритет заявки";
            // 
            // comboBox1Priority
            // 
            this.comboBox1Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1Priority.FormattingEnabled = true;
            this.comboBox1Priority.Location = new System.Drawing.Point(212, 754);
            this.comboBox1Priority.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1Priority.Name = "comboBox1Priority";
            this.comboBox1Priority.Size = new System.Drawing.Size(627, 28);
            this.comboBox1Priority.TabIndex = 38;
            this.comboBox1Priority.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(17, 805);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Сотрудник";
            // 
            // sparesTextBox
            // 
            this.sparesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sparesTextBox.Location = new System.Drawing.Point(1117, 62);
            this.sparesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sparesTextBox.Multiline = true;
            this.sparesTextBox.Name = "sparesTextBox";
            this.sparesTextBox.Size = new System.Drawing.Size(627, 238);
            this.sparesTextBox.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(851, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Заказанные запчасти";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reasonTextBox.Location = new System.Drawing.Point(1117, 316);
            this.reasonTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(627, 238);
            this.reasonTextBox.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(851, 316);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Причина неисправности";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(16, 198);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Статус заявки";
            // 
            // requestStatusCombobox
            // 
            this.requestStatusCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.requestStatusCombobox.FormattingEnabled = true;
            this.requestStatusCombobox.Location = new System.Drawing.Point(212, 201);
            this.requestStatusCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.requestStatusCombobox.Name = "requestStatusCombobox";
            this.requestStatusCombobox.Size = new System.Drawing.Size(631, 28);
            this.requestStatusCombobox.TabIndex = 45;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idTextBox.Location = new System.Drawing.Point(212, 48);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(630, 26);
            this.idTextBox.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(16, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "ID заявки";
            // 
            // finishdate
            // 
            this.finishdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.finishdate.Location = new System.Drawing.Point(212, 148);
            this.finishdate.Margin = new System.Windows.Forms.Padding(4);
            this.finishdate.Name = "finishdate";
            this.finishdate.Size = new System.Drawing.Size(631, 26);
            this.finishdate.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(13, 148);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "Дата завершения";
            // 
            // helptextBox
            // 
            this.helptextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.helptextBox.Location = new System.Drawing.Point(1117, 576);
            this.helptextBox.Margin = new System.Windows.Forms.Padding(4);
            this.helptextBox.Multiline = true;
            this.helptextBox.Name = "helptextBox";
            this.helptextBox.Size = new System.Drawing.Size(627, 238);
            this.helptextBox.TabIndex = 52;
            this.helptextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(851, 576);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 20);
            this.label15.TabIndex = 51;
            this.label15.Text = "Оказанная помощь";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // eqTextBox
            // 
            this.eqTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eqTextBox.Location = new System.Drawing.Point(212, 270);
            this.eqTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.eqTextBox.Name = "eqTextBox";
            this.eqTextBox.Size = new System.Drawing.Size(631, 26);
            this.eqTextBox.TabIndex = 54;
            // 
            // findEntry
            // 
            this.findEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.findEntry.Location = new System.Drawing.Point(11, 885);
            this.findEntry.Margin = new System.Windows.Forms.Padding(4);
            this.findEntry.Name = "findEntry";
            this.findEntry.Size = new System.Drawing.Size(291, 39);
            this.findEntry.TabIndex = 55;
            this.findEntry.Text = "Найти заявку по ID";
            this.findEntry.UseVisualStyleBackColor = true;
            this.findEntry.Click += new System.EventHandler(this.findEntry_Click);
            // 
            // workerTextBox
            // 
            this.workerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.workerTextBox.Location = new System.Drawing.Point(208, 805);
            this.workerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.workerTextBox.Name = "workerTextBox";
            this.workerTextBox.Size = new System.Drawing.Size(631, 26);
            this.workerTextBox.TabIndex = 56;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 937);
            this.Controls.Add(this.workerTextBox);
            this.Controls.Add(this.findEntry);
            this.Controls.Add(this.eqTextBox);
            this.Controls.Add(this.helptextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.finishdate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.requestStatusCombobox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sparesTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1Priority);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.clientNumber);
            this.Controls.Add(this.client);
            this.Controls.Add(this.problemDescTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox clientNumber;
        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.TextBox problemDescTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox startdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1Priority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sparesTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox requestStatusCombobox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox finishdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox helptextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox eqTextBox;
        private System.Windows.Forms.Button findEntry;
        private System.Windows.Forms.TextBox workerTextBox;
    }
}