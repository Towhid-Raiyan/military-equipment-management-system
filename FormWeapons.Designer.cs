
namespace MilitaryEquipmentManagementSystem
{
    partial class FormWeapons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeapons));
            this.InsertWeapon = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtwregiment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wActiveQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wInServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRegimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weaponTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.militaryEquipmentManagementDataSet3 = new MilitaryEquipmentManagementSystem.MilitaryEquipmentManagementDataSet3();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtwid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtwmanufact = new System.Windows.Forms.TextBox();
            this.txtwmodel = new System.Windows.Forms.TextBox();
            this.txtwname = new System.Windows.Forms.TextBox();
            this.weaponTableTableAdapter = new MilitaryEquipmentManagementSystem.MilitaryEquipmentManagementDataSet3TableAdapters.weaponTableTableAdapter();
            this.btnMain = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertWeapon
            // 
            this.InsertWeapon.BackColor = System.Drawing.Color.PeachPuff;
            this.InsertWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertWeapon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertWeapon.Location = new System.Drawing.Point(19, 34);
            this.InsertWeapon.Name = "InsertWeapon";
            this.InsertWeapon.Size = new System.Drawing.Size(121, 36);
            this.InsertWeapon.TabIndex = 4;
            this.InsertWeapon.Text = "Insert Weapon";
            this.InsertWeapon.UseVisualStyleBackColor = false;
            this.InsertWeapon.Click += new System.EventHandler(this.InsertWeapon_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(251, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(121, 36);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(19, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.InsertWeapon);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(14, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 187);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activities";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PeachPuff;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Regiment";
            // 
            // txtwregiment
            // 
            this.txtwregiment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwregiment.Location = new System.Drawing.Point(157, 365);
            this.txtwregiment.Name = "txtwregiment";
            this.txtwregiment.Size = new System.Drawing.Size(228, 24);
            this.txtwregiment.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 323);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "In Service";
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
            this.wIDDataGridViewTextBoxColumn,
            this.wNameDataGridViewTextBoxColumn,
            this.wModelDataGridViewTextBoxColumn,
            this.wManufacturerDataGridViewTextBoxColumn,
            this.wActiveQuantityDataGridViewTextBoxColumn,
            this.wInServiceDataGridViewTextBoxColumn,
            this.wRegimentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.weaponTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(470, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 644);
            this.dataGridView1.TabIndex = 3;
            // 
            // wIDDataGridViewTextBoxColumn
            // 
            this.wIDDataGridViewTextBoxColumn.DataPropertyName = "wID";
            this.wIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.wIDDataGridViewTextBoxColumn.Name = "wIDDataGridViewTextBoxColumn";
            this.wIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // wNameDataGridViewTextBoxColumn
            // 
            this.wNameDataGridViewTextBoxColumn.DataPropertyName = "wName";
            this.wNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.wNameDataGridViewTextBoxColumn.Name = "wNameDataGridViewTextBoxColumn";
            this.wNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // wModelDataGridViewTextBoxColumn
            // 
            this.wModelDataGridViewTextBoxColumn.DataPropertyName = "wModel";
            this.wModelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.wModelDataGridViewTextBoxColumn.Name = "wModelDataGridViewTextBoxColumn";
            this.wModelDataGridViewTextBoxColumn.Width = 120;
            // 
            // wManufacturerDataGridViewTextBoxColumn
            // 
            this.wManufacturerDataGridViewTextBoxColumn.DataPropertyName = "wManufacturer";
            this.wManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.wManufacturerDataGridViewTextBoxColumn.Name = "wManufacturerDataGridViewTextBoxColumn";
            this.wManufacturerDataGridViewTextBoxColumn.Width = 150;
            // 
            // wActiveQuantityDataGridViewTextBoxColumn
            // 
            this.wActiveQuantityDataGridViewTextBoxColumn.DataPropertyName = "wActiveQuantity";
            this.wActiveQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.wActiveQuantityDataGridViewTextBoxColumn.Name = "wActiveQuantityDataGridViewTextBoxColumn";
            this.wActiveQuantityDataGridViewTextBoxColumn.Width = 70;
            // 
            // wInServiceDataGridViewTextBoxColumn
            // 
            this.wInServiceDataGridViewTextBoxColumn.DataPropertyName = "wInService";
            this.wInServiceDataGridViewTextBoxColumn.HeaderText = "In Service";
            this.wInServiceDataGridViewTextBoxColumn.Name = "wInServiceDataGridViewTextBoxColumn";
            this.wInServiceDataGridViewTextBoxColumn.Width = 80;
            // 
            // wRegimentDataGridViewTextBoxColumn
            // 
            this.wRegimentDataGridViewTextBoxColumn.DataPropertyName = "wRegiment";
            this.wRegimentDataGridViewTextBoxColumn.HeaderText = "Regiment";
            this.wRegimentDataGridViewTextBoxColumn.Name = "wRegimentDataGridViewTextBoxColumn";
            this.wRegimentDataGridViewTextBoxColumn.Width = 160;
            // 
            // weaponTableBindingSource
            // 
            this.weaponTableBindingSource.DataMember = "weaponTable";
            this.weaponTableBindingSource.DataSource = this.militaryEquipmentManagementDataSet3;
            // 
            // militaryEquipmentManagementDataSet3
            // 
            this.militaryEquipmentManagementDataSet3.DataSetName = "MilitaryEquipmentManagementDataSet3";
            this.militaryEquipmentManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonYes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtwregiment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtwid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.txtwmanufact);
            this.groupBox1.Controls.Add(this.txtwmodel);
            this.groupBox1.Controls.Add(this.txtwname);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 451);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weapon Information";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(234, 325);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 18;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(157, 325);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYes.TabIndex = 17;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Weapon ID";
            // 
            // txtwid
            // 
            this.txtwid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwid.Location = new System.Drawing.Point(157, 72);
            this.txtwid.Name = "txtwid";
            this.txtwid.Size = new System.Drawing.Size(228, 24);
            this.txtwid.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Active Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name ";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(157, 270);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(228, 24);
            this.txtquantity.TabIndex = 3;
            // 
            // txtwmanufact
            // 
            this.txtwmanufact.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwmanufact.Location = new System.Drawing.Point(157, 220);
            this.txtwmanufact.Name = "txtwmanufact";
            this.txtwmanufact.Size = new System.Drawing.Size(228, 24);
            this.txtwmanufact.TabIndex = 2;
            // 
            // txtwmodel
            // 
            this.txtwmodel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwmodel.Location = new System.Drawing.Point(157, 168);
            this.txtwmodel.Name = "txtwmodel";
            this.txtwmodel.Size = new System.Drawing.Size(228, 24);
            this.txtwmodel.TabIndex = 1;
            // 
            // txtwname
            // 
            this.txtwname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwname.Location = new System.Drawing.Point(157, 120);
            this.txtwname.Name = "txtwname";
            this.txtwname.Size = new System.Drawing.Size(228, 24);
            this.txtwname.TabIndex = 0;
            // 
            // weaponTableTableAdapter
            // 
            this.weaponTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Orange;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMain.Location = new System.Drawing.Point(15, 5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(106, 25);
            this.btnMain.TabIndex = 10;
            this.btnMain.Text = "Main Panel";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // FormWeapons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = global::MilitaryEquipmentManagementSystem.Properties.Resources.cover1;
            this.ClientSize = new System.Drawing.Size(1340, 693);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWeapons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapons";
            this.Load += new System.EventHandler(this.FormWeapons_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button InsertWeapon;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtwregiment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtwid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtwmanufact;
        private System.Windows.Forms.TextBox txtwmodel;
        private System.Windows.Forms.TextBox txtwname;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private MilitaryEquipmentManagementDataSet3 militaryEquipmentManagementDataSet3;
        private System.Windows.Forms.BindingSource weaponTableBindingSource;
        private MilitaryEquipmentManagementDataSet3TableAdapters.weaponTableTableAdapter weaponTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wActiveQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wInServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRegimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMain;
    }
}