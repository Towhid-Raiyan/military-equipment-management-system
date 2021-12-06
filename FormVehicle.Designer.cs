
namespace MilitaryEquipmentManagementSystem
{
    partial class FormVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehicle));
            this.label8 = new System.Windows.Forms.Label();
            this.txtvregiment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvquantity = new System.Windows.Forms.TextBox();
            this.txtvmanufact = new System.Windows.Forms.TextBox();
            this.txtvmodel = new System.Windows.Forms.TextBox();
            this.txtvname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vActiveQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRegimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.militaryEquipmentManagementDataSet2 = new MilitaryEquipmentManagementSystem.MilitaryEquipmentManagementDataSet2();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InsertVehicle = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.militaryEquipmentManagementDataSet1 = new MilitaryEquipmentManagementSystem.MilitaryEquipmentManagementDataSet1();
            this.militaryEquipmentManagementDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableTableAdapter = new MilitaryEquipmentManagementSystem.MilitaryEquipmentManagementDataSet2TableAdapters.vehicleTableTableAdapter();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
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
            // txtvregiment
            // 
            this.txtvregiment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvregiment.Location = new System.Drawing.Point(157, 365);
            this.txtvregiment.Name = "txtvregiment";
            this.txtvregiment.Size = new System.Drawing.Size(228, 24);
            this.txtvregiment.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vehicle ID";
            // 
            // txtvid
            // 
            this.txtvid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvid.Location = new System.Drawing.Point(157, 72);
            this.txtvid.Name = "txtvid";
            this.txtvid.Size = new System.Drawing.Size(228, 24);
            this.txtvid.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Active Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vehicle Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehicle Name ";
            // 
            // txtvquantity
            // 
            this.txtvquantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvquantity.Location = new System.Drawing.Point(157, 311);
            this.txtvquantity.Name = "txtvquantity";
            this.txtvquantity.Size = new System.Drawing.Size(228, 24);
            this.txtvquantity.TabIndex = 3;
            // 
            // txtvmanufact
            // 
            this.txtvmanufact.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvmanufact.Location = new System.Drawing.Point(157, 250);
            this.txtvmanufact.Name = "txtvmanufact";
            this.txtvmanufact.Size = new System.Drawing.Size(228, 24);
            this.txtvmanufact.TabIndex = 2;
            // 
            // txtvmodel
            // 
            this.txtvmodel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvmodel.Location = new System.Drawing.Point(157, 190);
            this.txtvmodel.Name = "txtvmodel";
            this.txtvmodel.Size = new System.Drawing.Size(228, 24);
            this.txtvmodel.TabIndex = 1;
            // 
            // txtvname
            // 
            this.txtvname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvname.Location = new System.Drawing.Point(157, 131);
            this.txtvname.Name = "txtvname";
            this.txtvname.Size = new System.Drawing.Size(228, 24);
            this.txtvname.TabIndex = 0;
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
            this.vIDDataGridViewTextBoxColumn,
            this.vNameDataGridViewTextBoxColumn,
            this.vModelDataGridViewTextBoxColumn,
            this.vManufacturerDataGridViewTextBoxColumn,
            this.vActiveQuantityDataGridViewTextBoxColumn,
            this.vRegimentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleTableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(470, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 644);
            this.dataGridView1.TabIndex = 6;
            // 
            // vIDDataGridViewTextBoxColumn
            // 
            this.vIDDataGridViewTextBoxColumn.DataPropertyName = "vID";
            this.vIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.vIDDataGridViewTextBoxColumn.Name = "vIDDataGridViewTextBoxColumn";
            // 
            // vNameDataGridViewTextBoxColumn
            // 
            this.vNameDataGridViewTextBoxColumn.DataPropertyName = "vName";
            this.vNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.vNameDataGridViewTextBoxColumn.Name = "vNameDataGridViewTextBoxColumn";
            this.vNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // vModelDataGridViewTextBoxColumn
            // 
            this.vModelDataGridViewTextBoxColumn.DataPropertyName = "vModel";
            this.vModelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.vModelDataGridViewTextBoxColumn.Name = "vModelDataGridViewTextBoxColumn";
            this.vModelDataGridViewTextBoxColumn.Width = 130;
            // 
            // vManufacturerDataGridViewTextBoxColumn
            // 
            this.vManufacturerDataGridViewTextBoxColumn.DataPropertyName = "vManufacturer";
            this.vManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.vManufacturerDataGridViewTextBoxColumn.Name = "vManufacturerDataGridViewTextBoxColumn";
            this.vManufacturerDataGridViewTextBoxColumn.Width = 130;
            // 
            // vActiveQuantityDataGridViewTextBoxColumn
            // 
            this.vActiveQuantityDataGridViewTextBoxColumn.DataPropertyName = "vActiveQuantity";
            this.vActiveQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.vActiveQuantityDataGridViewTextBoxColumn.Name = "vActiveQuantityDataGridViewTextBoxColumn";
            // 
            // vRegimentDataGridViewTextBoxColumn
            // 
            this.vRegimentDataGridViewTextBoxColumn.DataPropertyName = "vRegiment";
            this.vRegimentDataGridViewTextBoxColumn.HeaderText = "Regiment";
            this.vRegimentDataGridViewTextBoxColumn.Name = "vRegimentDataGridViewTextBoxColumn";
            this.vRegimentDataGridViewTextBoxColumn.Width = 150;
            // 
            // vehicleTableBindingSource
            // 
            this.vehicleTableBindingSource.DataMember = "vehicleTable";
            this.vehicleTableBindingSource.DataSource = this.militaryEquipmentManagementDataSet2;
            // 
            // militaryEquipmentManagementDataSet2
            // 
            this.militaryEquipmentManagementDataSet2.DataSetName = "MilitaryEquipmentManagementDataSet2";
            this.militaryEquipmentManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.InsertVehicle);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(14, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 187);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activities";
            // 
            // InsertVehicle
            // 
            this.InsertVehicle.BackColor = System.Drawing.Color.PeachPuff;
            this.InsertVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertVehicle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertVehicle.Location = new System.Drawing.Point(19, 34);
            this.InsertVehicle.Name = "InsertVehicle";
            this.InsertVehicle.Size = new System.Drawing.Size(121, 36);
            this.InsertVehicle.TabIndex = 4;
            this.InsertVehicle.Text = "Insert Weapon";
            this.InsertVehicle.UseVisualStyleBackColor = false;
            this.InsertVehicle.Click += new System.EventHandler(this.InsertVehicle_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtvregiment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtvid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtvquantity);
            this.groupBox1.Controls.Add(this.txtvmanufact);
            this.groupBox1.Controls.Add(this.txtvmodel);
            this.groupBox1.Controls.Add(this.txtvname);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 451);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Information";
            // 
            // militaryEquipmentManagementDataSet1
            // 
            this.militaryEquipmentManagementDataSet1.DataSetName = "MilitaryEquipmentManagementDataSet1";
            this.militaryEquipmentManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // militaryEquipmentManagementDataSet1BindingSource
            // 
            this.militaryEquipmentManagementDataSet1BindingSource.DataSource = this.militaryEquipmentManagementDataSet1;
            this.militaryEquipmentManagementDataSet1BindingSource.Position = 0;
            // 
            // vehicleTableTableAdapter
            // 
            this.vehicleTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Orange;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMain.Location = new System.Drawing.Point(15, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(106, 25);
            this.btnMain.TabIndex = 9;
            this.btnMain.Text = "Main Panel";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // FormVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilitaryEquipmentManagementSystem.Properties.Resources.cover1;
            this.ClientSize = new System.Drawing.Size(1340, 693);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.FormVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryEquipmentManagementDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvregiment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvquantity;
        private System.Windows.Forms.TextBox txtvmanufact;
        private System.Windows.Forms.TextBox txtvmodel;
        private System.Windows.Forms.TextBox txtvname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button InsertVehicle;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource militaryEquipmentManagementDataSet1BindingSource;
        private MilitaryEquipmentManagementDataSet1 militaryEquipmentManagementDataSet1;
        private MilitaryEquipmentManagementDataSet2 militaryEquipmentManagementDataSet2;
        private System.Windows.Forms.BindingSource vehicleTableBindingSource;
        private MilitaryEquipmentManagementDataSet2TableAdapters.vehicleTableTableAdapter vehicleTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vActiveQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRegimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMain;
    }
}