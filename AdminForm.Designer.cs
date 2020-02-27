namespace TelephoneDirectory
{
    partial class AdminForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnDelUser = new System.Windows.Forms.Button();
            this.btnDelTelephone = new System.Windows.Forms.Button();
            this.btnAddTelephone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblFIOInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxRegistrationAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxResidentialAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxPlaceOfWork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.IdTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAge = new System.Windows.Forms.MaskedTextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResidentialAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FIO,
            this.Age,
            this.PlaceOfWork,
            this.ResidentialAddress,
            this.RegistrationAddress});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(564, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTelephone,
            this.IdUser,
            this.Telephone});
            this.dataGridView2.Location = new System.Drawing.Point(582, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(177, 236);
            this.dataGridView2.TabIndex = 1;
            // 
            // BtnDelUser
            // 
            this.BtnDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelUser.Location = new System.Drawing.Point(12, 300);
            this.BtnDelUser.Name = "BtnDelUser";
            this.BtnDelUser.Size = new System.Drawing.Size(143, 37);
            this.BtnDelUser.TabIndex = 2;
            this.BtnDelUser.Text = "Удалить";
            this.BtnDelUser.UseVisualStyleBackColor = true;
            this.BtnDelUser.Click += new System.EventHandler(this.BtnDelUser_Click);
            // 
            // btnDelTelephone
            // 
            this.btnDelTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelTelephone.Location = new System.Drawing.Point(582, 300);
            this.btnDelTelephone.Name = "btnDelTelephone";
            this.btnDelTelephone.Size = new System.Drawing.Size(177, 37);
            this.btnDelTelephone.TabIndex = 5;
            this.btnDelTelephone.Text = "Удалить";
            this.btnDelTelephone.UseVisualStyleBackColor = true;
            this.btnDelTelephone.Click += new System.EventHandler(this.btnDelTelephone_Click);
            // 
            // btnAddTelephone
            // 
            this.btnAddTelephone.Location = new System.Drawing.Point(15, 71);
            this.btnAddTelephone.Name = "btnAddTelephone";
            this.btnAddTelephone.Size = new System.Drawing.Size(174, 23);
            this.btnAddTelephone.TabIndex = 6;
            this.btnAddTelephone.Text = "Добавить";
            this.btnAddTelephone.UseVisualStyleBackColor = true;
            this.btnAddTelephone.Click += new System.EventHandler(this.btnAddTelephone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Моб. тел.";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(582, 459);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 66);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFIO
            // 
            this.lblFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFIO.AutoSize = true;
            this.lblFIO.Location = new System.Drawing.Point(582, 39);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(34, 13);
            this.lblFIO.TabIndex = 10;
            this.lblFIO.Text = "ФИО";
            // 
            // lblFIOInfo
            // 
            this.lblFIOInfo.AutoSize = true;
            this.lblFIOInfo.Location = new System.Drawing.Point(17, 24);
            this.lblFIOInfo.Name = "lblFIOInfo";
            this.lblFIOInfo.Size = new System.Drawing.Size(34, 13);
            this.lblFIOInfo.TabIndex = 13;
            this.lblFIOInfo.Text = "ФИО";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.maskedTextBoxTelephone);
            this.groupBox1.Controls.Add(this.btnAddTelephone);
            this.groupBox1.Controls.Add(this.lblFIOInfo);
            this.groupBox1.Location = new System.Drawing.Point(570, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить моб. тел.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.maskedTextBoxAge);
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Controls.Add(this.btnEditUser);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxRegistrationAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxResidentialAddress);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBoxPlaceOfWork);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxFIO);
            this.groupBox2.Location = new System.Drawing.Point(12, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 182);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пользователь";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(425, 130);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(86, 37);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(17, 130);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(91, 37);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "Изменить";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Адрес регистрации";
            // 
            // txtBoxRegistrationAddress
            // 
            this.txtBoxRegistrationAddress.Location = new System.Drawing.Point(287, 104);
            this.txtBoxRegistrationAddress.Name = "txtBoxRegistrationAddress";
            this.txtBoxRegistrationAddress.Size = new System.Drawing.Size(191, 20);
            this.txtBoxRegistrationAddress.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Адрес проживания";
            // 
            // txtBoxResidentialAddress
            // 
            this.txtBoxResidentialAddress.Location = new System.Drawing.Point(57, 104);
            this.txtBoxResidentialAddress.Name = "txtBoxResidentialAddress";
            this.txtBoxResidentialAddress.Size = new System.Drawing.Size(181, 20);
            this.txtBoxResidentialAddress.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Место работы";
            // 
            // txtBoxPlaceOfWork
            // 
            this.txtBoxPlaceOfWork.Location = new System.Drawing.Point(333, 47);
            this.txtBoxPlaceOfWork.Name = "txtBoxPlaceOfWork";
            this.txtBoxPlaceOfWork.Size = new System.Drawing.Size(202, 20);
            this.txtBoxPlaceOfWork.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Год рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО";
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(6, 47);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(182, 20);
            this.txtBoxFIO.TabIndex = 0;
            // 
            // IdTelephone
            // 
            this.IdTelephone.HeaderText = "IdTel";
            this.IdTelephone.Name = "IdTelephone";
            this.IdTelephone.Visible = false;
            // 
            // IdUser
            // 
            this.IdUser.HeaderText = "IdUser";
            this.IdUser.Name = "IdUser";
            this.IdUser.Visible = false;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Моб. тел.";
            this.Telephone.Name = "Telephone";
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.BeepOnError = true;
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(20, 45);
            this.maskedTextBoxTelephone.Mask = "8 (000) 000-00-00";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(106, 20);
            this.maskedTextBoxTelephone.TabIndex = 14;
            // 
            // maskedTextBoxAge
            // 
            this.maskedTextBoxAge.BeepOnError = true;
            this.maskedTextBoxAge.Location = new System.Drawing.Point(206, 47);
            this.maskedTextBoxAge.Mask = "0000";
            this.maskedTextBoxAge.Name = "maskedTextBoxAge";
            this.maskedTextBoxAge.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAge.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdUser";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            // 
            // PlaceOfWork
            // 
            this.PlaceOfWork.HeaderText = "Место работы";
            this.PlaceOfWork.Name = "PlaceOfWork";
            // 
            // ResidentialAddress
            // 
            this.ResidentialAddress.HeaderText = "Адрес проживания";
            this.ResidentialAddress.Name = "ResidentialAddress";
            // 
            // RegistrationAddress
            // 
            this.RegistrationAddress.HeaderText = "Адрес регистрации";
            this.RegistrationAddress.Name = "RegistrationAddress";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelTelephone);
            this.Controls.Add(this.BtnDelUser);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnDelUser;
        private System.Windows.Forms.Button btnDelTelephone;
        private System.Windows.Forms.Button btnAddTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblFIOInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxRegistrationAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxResidentialAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxPlaceOfWork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceOfWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResidentialAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationAddress;
    }
}