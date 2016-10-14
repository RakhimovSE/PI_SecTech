namespace prototype
{
    partial class EditClientForm
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
            this.clientBirthdayLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientBirthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.genderGB = new System.Windows.Forms.GroupBox();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.saveClientButton = new System.Windows.Forms.Button();
            this.clientIssueDateDTP = new System.Windows.Forms.DateTimePicker();
            this.clientPassportIssueDepartmentLabel = new System.Windows.Forms.Label();
            this.clientPassportIssueDepartmentTB = new System.Windows.Forms.TextBox();
            this.clientIssueDateLabel = new System.Windows.Forms.Label();
            this.clientPassportIdLabel = new System.Windows.Forms.Label();
            this.clientPassportIdTextbox = new System.Windows.Forms.TextBox();
            this.clientCB = new System.Windows.Forms.ComboBox();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.genderGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientBirthdayLabel
            // 
            this.clientBirthdayLabel.AutoSize = true;
            this.clientBirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientBirthdayLabel.Location = new System.Drawing.Point(11, 87);
            this.clientBirthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientBirthdayLabel.Name = "clientBirthdayLabel";
            this.clientBirthdayLabel.Size = new System.Drawing.Size(90, 13);
            this.clientBirthdayLabel.TabIndex = 25;
            this.clientBirthdayLabel.Text = "Дата рождения*";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientNameLabel.Location = new System.Drawing.Point(11, 49);
            this.clientNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(82, 13);
            this.clientNameLabel.TabIndex = 24;
            this.clientNameLabel.Text = "ФИО клиента*";
            // 
            // clientBirthdayDTP
            // 
            this.clientBirthdayDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientBirthdayDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clientBirthdayDTP.Location = new System.Drawing.Point(11, 103);
            this.clientBirthdayDTP.Name = "clientBirthdayDTP";
            this.clientBirthdayDTP.Size = new System.Drawing.Size(104, 20);
            this.clientBirthdayDTP.TabIndex = 48;
            // 
            // genderGB
            // 
            this.genderGB.Controls.Add(this.femaleRB);
            this.genderGB.Controls.Add(this.maleRB);
            this.genderGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.genderGB.Location = new System.Drawing.Point(11, 129);
            this.genderGB.Name = "genderGB";
            this.genderGB.Size = new System.Drawing.Size(246, 42);
            this.genderGB.TabIndex = 49;
            this.genderGB.TabStop = false;
            this.genderGB.Text = "Пол*";
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.femaleRB.Location = new System.Drawing.Point(111, 20);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(72, 17);
            this.femaleRB.TabIndex = 1;
            this.femaleRB.Text = "Женский";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.Checked = true;
            this.maleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maleRB.Location = new System.Drawing.Point(7, 20);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(71, 17);
            this.maleRB.TabIndex = 0;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "Мужской";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // saveClientButton
            // 
            this.saveClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.saveClientButton.Location = new System.Drawing.Point(11, 251);
            this.saveClientButton.Name = "saveClientButton";
            this.saveClientButton.Size = new System.Drawing.Size(246, 36);
            this.saveClientButton.TabIndex = 52;
            this.saveClientButton.Text = "Сохранить клиента";
            this.saveClientButton.UseVisualStyleBackColor = true;
            this.saveClientButton.Click += new System.EventHandler(this.saveClientButton_Click);
            // 
            // clientIssueDateDTP
            // 
            this.clientIssueDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientIssueDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clientIssueDateDTP.Location = new System.Drawing.Point(122, 189);
            this.clientIssueDateDTP.Name = "clientIssueDateDTP";
            this.clientIssueDateDTP.Size = new System.Drawing.Size(135, 20);
            this.clientIssueDateDTP.TabIndex = 56;
            // 
            // clientPassportIssueDepartmentLabel
            // 
            this.clientPassportIssueDepartmentLabel.AutoSize = true;
            this.clientPassportIssueDepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientPassportIssueDepartmentLabel.Location = new System.Drawing.Point(11, 211);
            this.clientPassportIssueDepartmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientPassportIssueDepartmentLabel.Name = "clientPassportIssueDepartmentLabel";
            this.clientPassportIssueDepartmentLabel.Size = new System.Drawing.Size(67, 13);
            this.clientPassportIssueDepartmentLabel.TabIndex = 59;
            this.clientPassportIssueDepartmentLabel.Text = "Кем выдан*";
            // 
            // clientPassportIssueDepartmentTB
            // 
            this.clientPassportIssueDepartmentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientPassportIssueDepartmentTB.Location = new System.Drawing.Point(11, 226);
            this.clientPassportIssueDepartmentTB.Margin = new System.Windows.Forms.Padding(2);
            this.clientPassportIssueDepartmentTB.Name = "clientPassportIssueDepartmentTB";
            this.clientPassportIssueDepartmentTB.Size = new System.Drawing.Size(246, 20);
            this.clientPassportIssueDepartmentTB.TabIndex = 60;
            // 
            // clientIssueDateLabel
            // 
            this.clientIssueDateLabel.AutoSize = true;
            this.clientIssueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientIssueDateLabel.Location = new System.Drawing.Point(122, 173);
            this.clientIssueDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientIssueDateLabel.Name = "clientIssueDateLabel";
            this.clientIssueDateLabel.Size = new System.Drawing.Size(77, 13);
            this.clientIssueDateLabel.TabIndex = 57;
            this.clientIssueDateLabel.Text = "Дата выдачи*";
            // 
            // clientPassportIdLabel
            // 
            this.clientPassportIdLabel.AutoSize = true;
            this.clientPassportIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientPassportIdLabel.Location = new System.Drawing.Point(11, 174);
            this.clientPassportIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientPassportIdLabel.Name = "clientPassportIdLabel";
            this.clientPassportIdLabel.Size = new System.Drawing.Size(86, 13);
            this.clientPassportIdLabel.TabIndex = 56;
            this.clientPassportIdLabel.Text = "Серия и номер*";
            // 
            // clientPassportIdTextbox
            // 
            this.clientPassportIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientPassportIdTextbox.Location = new System.Drawing.Point(11, 189);
            this.clientPassportIdTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.clientPassportIdTextbox.Name = "clientPassportIdTextbox";
            this.clientPassportIdTextbox.Size = new System.Drawing.Size(109, 20);
            this.clientPassportIdTextbox.TabIndex = 56;
            // 
            // clientCB
            // 
            this.clientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientCB.FormattingEnabled = true;
            this.clientCB.Location = new System.Drawing.Point(11, 25);
            this.clientCB.Name = "clientCB";
            this.clientCB.Size = new System.Drawing.Size(246, 21);
            this.clientCB.TabIndex = 61;
            this.clientCB.SelectedIndexChanged += new System.EventHandler(this.clientCB_SelectedIndexChanged);
            // 
            // clientNameTB
            // 
            this.clientNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientNameTB.Location = new System.Drawing.Point(11, 64);
            this.clientNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(246, 20);
            this.clientNameTB.TabIndex = 55;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientLabel.Location = new System.Drawing.Point(11, 9);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(43, 13);
            this.clientLabel.TabIndex = 62;
            this.clientLabel.Text = "Клиент";
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 299);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientIssueDateDTP);
            this.Controls.Add(this.clientPassportIssueDepartmentLabel);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.clientPassportIssueDepartmentTB);
            this.Controls.Add(this.clientIssueDateLabel);
            this.Controls.Add(this.saveClientButton);
            this.Controls.Add(this.clientPassportIdLabel);
            this.Controls.Add(this.clientPassportIdTextbox);
            this.Controls.Add(this.genderGB);
            this.Controls.Add(this.clientBirthdayDTP);
            this.Controls.Add(this.clientBirthdayLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.clientCB);
            this.Name = "EditClientForm";
            this.Text = "Редактирование клиента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditClientForm_FormClosed);
            this.Load += new System.EventHandler(this.EditClientForm_Load);
            this.genderGB.ResumeLayout(false);
            this.genderGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientBirthdayLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.GroupBox genderGB;
        private System.Windows.Forms.Button saveClientButton;
        private System.Windows.Forms.Label clientPassportIssueDepartmentLabel;
        private System.Windows.Forms.Label clientIssueDateLabel;
        private System.Windows.Forms.Label clientPassportIdLabel;
        public System.Windows.Forms.DateTimePicker clientBirthdayDTP;
        public System.Windows.Forms.RadioButton femaleRB;
        public System.Windows.Forms.RadioButton maleRB;
        public System.Windows.Forms.TextBox clientPassportIssueDepartmentTB;
        public System.Windows.Forms.TextBox clientPassportIdTextbox;
        public System.Windows.Forms.DateTimePicker clientIssueDateDTP;
        public System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.Label clientLabel;
        public System.Windows.Forms.ComboBox clientCB;
    }
}