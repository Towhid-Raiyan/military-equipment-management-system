
namespace MilitaryEquipmentManagementSystem
{
    partial class FormTroopsAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTroopsAdmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.troopIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopRegimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.militaryEquipmentManagementDataSet1 = new MilitaryEquipmentManagementSystem.MilitaryEquipmentManagementDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datetroopsDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txttroopPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttroopRegiment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttroopId = new System.Windows.Forms.TextBox();
            this.cbtroopsGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttroopAddress = new System.Windows.Forms.TextBox();
            this.txttroopPhone = new System.Windows.Forms.TextBox();
            this.txttroopEmail = new System.Windows.Forms.TextBox();
            this.txttroopName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.troopTableTableAdapter = new MilitaryEquipmentManagementSystem.MilitaryEquipmentManagementDataSet1TableAdapters.troopTableTableAdapter();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.troopIDDataGridViewTextBoxColumn,
            this.troopNameDataGridViewTextBoxColumn,
            this.troopGenderDataGridViewTextBoxColumn,
            this.troopDOBDataGridViewTextBoxColumn,
            this.troopEmailDataGridViewTextBoxColumn,
            this.troopPhoneDataGridViewTextBoxColumn,
            this.troopAddressDataGridViewTextBoxColumn,
            this.troopRegimentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.troopTableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(469, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 644);
            this.dataGridView1.TabIndex = 0;
            // 
            // troopIDDataGridViewTextBoxColumn
            // 
            this.troopIDDataGridViewTextBoxColumn.DataPropertyName = "troopID";
            this.troopIDDataGridViewTextBoxColumn.HeaderText = "Troop ID";
            this.troopIDDataGridViewTextBoxColumn.Name = "troopIDDataGridViewTextBoxColumn";
            this.troopIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // troopNameDataGridViewTextBoxColumn
            // 
            this.troopNameDataGridViewTextBoxColumn.DataPropertyName = "troopName";
            this.troopNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.troopNameDataGridViewTextBoxColumn.Name = "troopNameDataGridViewTextBoxColumn";
            this.troopNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // troopGenderDataGridViewTextBoxColumn
            // 
            this.troopGenderDataGridViewTextBoxColumn.DataPropertyName = "troopGender";
            this.troopGenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.troopGenderDataGridViewTextBoxColumn.Name = "troopGenderDataGridViewTextBoxColumn";
            this.troopGenderDataGridViewTextBoxColumn.Width = 50;
            // 
            // troopDOBDataGridViewTextBoxColumn
            // 
            this.troopDOBDataGridViewTextBoxColumn.DataPropertyName = "troopDOB";
            this.troopDOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.troopDOBDataGridViewTextBoxColumn.Name = "troopDOBDataGridViewTextBoxColumn";
            this.troopDOBDataGridViewTextBoxColumn.Width = 70;
            // 
            // troopEmailDataGridViewTextBoxColumn
            // 
            this.troopEmailDataGridViewTextBoxColumn.DataPropertyName = "troopEmail";
            this.troopEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.troopEmailDataGridViewTextBoxColumn.Name = "troopEmailDataGridViewTextBoxColumn";
            this.troopEmailDataGridViewTextBoxColumn.Width = 120;
            // 
            // troopPhoneDataGridViewTextBoxColumn
            // 
            this.troopPhoneDataGridViewTextBoxColumn.DataPropertyName = "troopPhone";
            this.troopPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.troopPhoneDataGridViewTextBoxColumn.Name = "troopPhoneDataGridViewTextBoxColumn";
            // 
            // troopAddressDataGridViewTextBoxColumn
            // 
            this.troopAddressDataGridViewTextBoxColumn.DataPropertyName = "troopAddress";
            this.troopAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.troopAddressDataGridViewTextBoxColumn.Name = "troopAddressDataGridViewTextBoxColumn";
            this.troopAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // troopRegimentDataGridViewTextBoxColumn
            // 
            this.troopRegimentDataGridViewTextBoxColumn.DataPropertyName = "troopRegiment";
            this.troopRegimentDataGridViewTextBoxColumn.HeaderText = "Regiment";
            this.troopRegimentDataGridViewTextBoxColumn.Name = "troopRegimentDataGridViewTextBoxColumn";
            // 
            // troopTableBindingSource
            // 
            this.troopTableBindingSource.DataMember = "troopTable";
            this.troopTableBindingSource.DataSource = this.militaryEquipmentManagementDataSet1;
            // 
            // militaryEquipmentManagementDataSet1
            // 
            this.militaryEquipmentManagementDataSet1.DataSetName = "MilitaryEquipmentManagementDataSet1";
            this.militaryEquipmentManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.datetroopsDOB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txttroopPassword);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttroopRegiment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttroopId);
            this.groupBox1.Controls.Add(this.cbtroopsGender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttroopAddress);
            this.groupBox1.Controls.Add(this.txttroopPhone);
            this.groupBox1.Controls.Add(this.txttroopEmail);
            this.groupBox1.Controls.Add(this.txttroopName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 451);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Troops Information";
            // 
            // datetroopsDOB
            // 
            this.datetroopsDOB.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetroopsDOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetroopsDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetroopsDOB.Location = new System.Drawing.Point(154, 325);
            this.datetroopsDOB.Name = "datetroopsDOB";
            this.datetroopsDOB.Size = new System.Drawing.Size(228, 24);
            this.datetroopsDOB.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Assign Password";
            // 
            // txttroopPassword
            // 
            this.txttroopPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroopPassword.Location = new System.Drawing.Point(154, 411);
            this.txttroopPassword.Name = "txttroopPassword";
            this.txttroopPassword.Size = new System.Drawing.Size(228, 24);
            this.txttroopPassword.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Regiment";
            // 
            // txttroopRegiment
            // 
            this.txttroopRegiment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroopRegiment.Location = new System.Drawing.Point(154, 368);
            this.txttroopRegiment.Name = "txttroopRegiment";
            this.txttroopRegiment.Size = new System.Drawing.Size(228, 24);
            this.txttroopRegiment.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Toop ID ";
            // 
            // txttroopId
            // 
            this.txttroopId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroopId.Location = new System.Drawing.Point(154, 33);
            this.txttroopId.Name = "txttroopId";
            this.txttroopId.Size = new System.Drawing.Size(228, 24);
            this.txttroopId.TabIndex = 11;
            // 
            // cbtroopsGender
            // 
            this.cbtroopsGender.FormattingEnabled = true;
            this.cbtroopsGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbtroopsGender.Location = new System.Drawing.Point(154, 279);
            this.cbtroopsGender.Name = "cbtroopsGender";
            this.cbtroopsGender.Size = new System.Drawing.Size(228, 21);
            this.cbtroopsGender.TabIndex = 10;
            this.cbtroopsGender.Text = "Select Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name ";
            // 
            // txttroopAddress
            // 
            this.txttroopAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroopAddress.Location = new System.Drawing.Point(154, 234);
            this.txttroopAddress.Name = "txttroopAddress";
            this.txttroopAddress.Size = new System.Drawing.Size(228, 24);
            this.txttroopAddress.TabIndex = 3;
            // 
            // txttroopPhone
            // 
            this.txttroopPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroopPhone.Location = new System.Drawing.Point(154, 181);
            this.txttroopPhone.Name = "txttroopPhone";
            this.txttroopPhone.Size = new System.Drawing.Size(228, 24);
            this.txttroopPhone.TabIndex = 2;
            // 
            // txttroopEmail
            // 
            this.txttroopEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroopEmail.Location = new System.Drawing.Point(154, 129);
            this.txttroopEmail.Name = "txttroopEmail";
            this.txttroopEmail.Size = new System.Drawing.Size(228, 24);
            this.txttroopEmail.TabIndex = 1;
            // 
            // txttroopName
            // 
            this.txttroopName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroopName.Location = new System.Drawing.Point(154, 81);
            this.txttroopName.Name = "txttroopName";
            this.txttroopName.Size = new System.Drawing.Size(228, 24);
            this.txttroopName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.InsertButton);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(13, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 187);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activities";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.BurlyWood;
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(19, 34);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(121, 36);
            this.InsertButton.TabIndex = 4;
            this.InsertButton.Text = "Insert Troop";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BurlyWood;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(251, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(19, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(251, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // troopTableTableAdapter
            // 
            this.troopTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Orange;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMain.Location = new System.Drawing.Point(13, 6);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(106, 25);
            this.btnMain.TabIndex = 11;
            this.btnMain.Text = "Main Panel";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // FormTroopsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilitaryEquipmentManagementSystem.Properties.Resources.cover;
            this.ClientSize = new System.Drawing.Size(1340, 693);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTroopsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troops";
            this.Load += new System.EventHandler(this.FormTroopsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtroopsGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttroopAddress;
        private System.Windows.Forms.TextBox txttroopPhone;
        private System.Windows.Forms.TextBox txttroopEmail;
        private System.Windows.Forms.TextBox txttroopName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttroopId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttroopRegiment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttroopPassword;
        private System.Windows.Forms.Button InsertButton;
        private MilitaryEquipmentManagementDataSet1 militaryEquipmentManagementDataSet1;
        private System.Windows.Forms.BindingSource troopTableBindingSource;
        private MilitaryEquipmentManagementDataSet1TableAdapters.troopTableTableAdapter troopTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopRegimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.DateTimePicker datetroopsDOB;
    }
}