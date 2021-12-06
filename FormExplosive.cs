using DataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Entites;

namespace MilitaryEquipmentManagementSystem
{
    public partial class FormExplosive : Form
    {
        AdminOperations ap = new AdminOperations();
        public FormExplosive()
        {
            InitializeComponent();
        }

        // Insert in database
        private void InsertExplosive_Click(object sender, EventArgs e)
        {
            EntityExplosive ex = new EntityExplosive();
            bool status = false;

            ex.EID = txteid.Text.Trim();
            ex.EName = txtename.Text;
            ex.EManufacturer = txtemanufact.Text;
            ex.EActiveQuantity = txtequantity.Text;
            if (radioButtonYes.Checked)
            {
                ex.EInService = "Yes";
            }
            else if (radioButtonNo.Checked)
            {
                ex.EInService = "No";
            }
            ex.ERegiment = txteregiment.Text;

            status = ap.InsertExplosive(ex);

            if (status == true)
            {
                MessageBox.Show("Explosive Data Inserted Successfully!");
            }
            else
            {
                MessageBox.Show("Explosive Data is Not Inserted Successfully!");
            }
            load();

        }

        // Load From database
        public void load()
        {
            AdminOperations operationsadmin = new AdminOperations();
            DataTable dt = operationsadmin.ViewExplosiveData();
            dataGridView1.DataSource = dt;
        }

        // Delete from Database 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string eid = txteid.Text.Trim();
            bool status = false;

            try
            {
                status = ap.DeleteExplosive(eid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (status == true)
            {
                MessageBox.Show("Explosive Data Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Explosive Data is Not Deleted Successfully!");
            }
            load();

        }

        // Search from Database
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string eid = txteid.Text.Trim();
            EntityExplosive ew = new EntityExplosive();

            try
            {
                ew = ap.SearchExplosive(eid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txteid.Text = ew.EID;
            txtename.Text = ew.EName;
            txtemanufact.Text = ew.EManufacturer;
            txtequantity.Text = ew.EActiveQuantity;
            txteregiment.Text = ew.ERegiment;
            
            if (ew.EInService == "Yes")
            {
                radioButtonYes.Checked = true;
                radioButtonNo.Checked = false;
            }
            else if (ew.EInService == "No")
            {
                radioButtonYes.Checked = false;
                radioButtonNo.Checked = true;
            }

        }

        // Update from Database
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityExplosive ex = new EntityExplosive();
            bool status = false;

            ex.EID = txteid.Text.Trim();
            ex.EName = txtename.Text;
            ex.EManufacturer = txtemanufact.Text;
            ex.EActiveQuantity = txtequantity.Text;
            if (radioButtonYes.Checked)
            {
                ex.EInService = "Yes";
            }
            else if (radioButtonNo.Checked)
            {
                ex.EInService = "No";
            }
            ex.ERegiment = txteregiment.Text;

            status = ap.UpdateExplosive(ex);
            if (status == true)
            {
                MessageBox.Show("Explosive Data Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Explosive Data is Not Updated Successfully!");
            }
            load();
        }

        private void FormExplosive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militaryEquipmentManagementDataSet4.explosiveTable' table. You can move, or remove it, as needed.
           // this.explosiveTableTableAdapter.Fill(this.militaryEquipmentManagementDataSet4.explosiveTable);

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }
    }
}
