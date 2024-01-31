namespace pdf
{
    partial class Form2
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
            this.backBtn = new System.Windows.Forms.Button();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eqTypeLabel = new System.Windows.Forms.Label();
            this.serialNumberLabel = new System.Windows.Forms.Label();
            this.problemDescLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.problemDesc = new System.Windows.Forms.TextBox();
            this.client = new System.Windows.Forms.TextBox();
            this.clientNumber = new System.Windows.Forms.TextBox();
            this.saveBtn2 = new System.Windows.Forms.Button();
            this.eqTextBox = new System.Windows.Forms.TextBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backBtn.Location = new System.Drawing.Point(1628, 21);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(215, 39);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // serialNumber
            // 
            this.serialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serialNumber.Location = new System.Drawing.Point(655, 206);
            this.serialNumber.Margin = new System.Windows.Forms.Padding(4);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(768, 26);
            this.serialNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(876, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавление заявки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eqTypeLabel
            // 
            this.eqTypeLabel.AutoSize = true;
            this.eqTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eqTypeLabel.Location = new System.Drawing.Point(392, 146);
            this.eqTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eqTypeLabel.Name = "eqTypeLabel";
            this.eqTypeLabel.Size = new System.Drawing.Size(164, 20);
            this.eqTypeLabel.TabIndex = 7;
            this.eqTypeLabel.Text = "Тип оборудования";
            // 
            // serialNumberLabel
            // 
            this.serialNumberLabel.AutoSize = true;
            this.serialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serialNumberLabel.Location = new System.Drawing.Point(389, 206);
            this.serialNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serialNumberLabel.Name = "serialNumberLabel";
            this.serialNumberLabel.Size = new System.Drawing.Size(150, 20);
            this.serialNumberLabel.TabIndex = 8;
            this.serialNumberLabel.Text = "Серийный номер";
            // 
            // problemDescLabel
            // 
            this.problemDescLabel.AutoSize = true;
            this.problemDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.problemDescLabel.Location = new System.Drawing.Point(389, 270);
            this.problemDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.problemDescLabel.Name = "problemDescLabel";
            this.problemDescLabel.Size = new System.Drawing.Size(180, 20);
            this.problemDescLabel.TabIndex = 9;
            this.problemDescLabel.Text = "Описание проблемы";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneLabel.Location = new System.Drawing.Point(392, 608);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(155, 20);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Номер телефона";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(392, 549);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(123, 20);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "ФИО клиента";
            // 
            // problemDesc
            // 
            this.problemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.problemDesc.Location = new System.Drawing.Point(655, 270);
            this.problemDesc.Margin = new System.Windows.Forms.Padding(4);
            this.problemDesc.Multiline = true;
            this.problemDesc.Name = "problemDesc";
            this.problemDesc.Size = new System.Drawing.Size(768, 177);
            this.problemDesc.TabIndex = 16;
            // 
            // client
            // 
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.client.Location = new System.Drawing.Point(655, 545);
            this.client.Margin = new System.Windows.Forms.Padding(4);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(768, 26);
            this.client.TabIndex = 17;
            // 
            // clientNumber
            // 
            this.clientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clientNumber.Location = new System.Drawing.Point(655, 608);
            this.clientNumber.Margin = new System.Windows.Forms.Padding(4);
            this.clientNumber.Name = "clientNumber";
            this.clientNumber.Size = new System.Drawing.Size(768, 26);
            this.clientNumber.TabIndex = 18;
            // 
            // saveBtn2
            // 
            this.saveBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveBtn2.Location = new System.Drawing.Point(881, 688);
            this.saveBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn2.Name = "saveBtn2";
            this.saveBtn2.Size = new System.Drawing.Size(215, 39);
            this.saveBtn2.TabIndex = 19;
            this.saveBtn2.Text = "Сохранить";
            this.saveBtn2.UseVisualStyleBackColor = true;
            this.saveBtn2.Click += new System.EventHandler(this.saveBtn2_Click);
            // 
            // eqTextBox
            // 
            this.eqTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eqTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.eqTextBox.Location = new System.Drawing.Point(655, 146);
            this.eqTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.eqTextBox.Name = "eqTextBox";
            this.eqTextBox.Size = new System.Drawing.Size(768, 26);
            this.eqTextBox.TabIndex = 20;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priorityLabel.Location = new System.Drawing.Point(392, 492);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(165, 20);
            this.priorityLabel.TabIndex = 21;
            this.priorityLabel.Text = "Приоритет заявки";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(655, 487);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(768, 28);
            this.comboBoxPriority.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 937);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.eqTextBox);
            this.Controls.Add(this.saveBtn2);
            this.Controls.Add(this.clientNumber);
            this.Controls.Add(this.client);
            this.Controls.Add(this.problemDesc);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.problemDescLabel);
            this.Controls.Add(this.serialNumberLabel);
            this.Controls.Add(this.eqTypeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заявки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eqTypeLabel;
        private System.Windows.Forms.Label serialNumberLabel;
        private System.Windows.Forms.Label problemDescLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox problemDesc;
        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.TextBox clientNumber;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button saveBtn2;
        private System.Windows.Forms.TextBox eqTextBox;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox comboBoxPriority;
    }
}