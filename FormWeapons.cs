using DataAccessLayer.Entities;
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

namespace MilitaryEquipmentManagementSystem
{
    public partial class FormWeapons : Form
    {
        AdminOperations ap = new AdminOperations();
        public FormWeapons()
        {
            InitializeComponent();
        }

        //Insert Weapon Data to database
        private void InsertWeapon_Click(object sender, EventArgs e)
        {
            EntityWeapons ew = new EntityWeapons();
            bool status = false;

            ew.WeaponID = txtwid.Text.Trim();
            ew.WeaponName = txtwname.Text;
            ew.WeaponModel = txtwmodel.Text;
            ew.WeaponManufacturer = txtwmanufact.Text;
            if (radioButtonYes.Checked)
            {
                ew.WeaponInService = "Yes";
            }
            else if(radioButtonNo.Checked)
            {
                ew.WeaponInService = "No";
            }     
            ew.WeaponInQuntity = txtquantity.Text;
            ew.WeaponRegiment = txtwregiment.Text;
            if (txtwregiment.Text == "" || txtwname.Text == "" || txtwmodel.Text == "" || txtwmanufact.Text == "" || txtwid.Text == "" || txtquantity.Text == "" )
            {
                MessageBox.Show("Enter Data to All Field");
            }
            else
            {
                try
                {
                    status = ap.InsertWeapon(ew);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (status == true)
            {
                MessageBox.Show("Weapons Data Inserted Successfully!");
            }
            else
            {
                MessageBox.Show("Weapons Data is Not Inserted Successfully!");
            }
            load();
        }

        //Load Weapon Data from Database
        public void load()
        {
            AdminOperations operationsadmin = new AdminOperations();
            DataTable dt = operationsadmin.ViewWeaponData();
            dataGridView1.DataSource = dt;
        }

        //weapon search
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string wid = txtwid.Text.Trim();
            EntityWeapons ew = new EntityWeapons();

            try
            {
                ew = ap.SearchWeapon(wid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            txtwid.Text = ew.WeaponID;
            txtwname.Text = ew.WeaponName;
            txtwmanufact.Text = ew.WeaponManufacturer;
            txtquantity.Text = ew.WeaponInQuntity;
            txtwregiment.Text = ew.WeaponRegiment;
            txtwmodel.Text = ew.WeaponModel;
            if(ew.WeaponInService == "Yes")
            {
                radioButtonYes.Checked = true;
                radioButtonNo.Checked = false;
            }
            else if(ew.WeaponInService == "No")
            {
                radioButtonYes.Checked = false;
                radioButtonNo.Checked = true;
            }

        }

        //weapon delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string wid = txtwid.Text.Trim();
            bool status = false;

            try
            {
                status = ap.DeleteWeapon(wid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (status == true)
            {
                MessageBox.Show("Weapon Data Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Weapon Data is Not Deleted Successfully!");
            }
            load();

        }

        //weapon update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityWeapons ew = new EntityWeapons();
            bool status = false;

            ew.WeaponID = txtwid.Text.Trim();
            ew.WeaponName = txtwname.Text;
            ew.WeaponModel = txtwmodel.Text;
            ew.WeaponManufacturer = txtwmanufact.Text;
            if (radioButtonYes.Checked)
            {
                ew.WeaponInService = "Yes";
            }
            else if (radioButtonNo.Checked)
            {
                ew.WeaponInService = "No";
            }
            ew.WeaponInQuntity = txtquantity.Text;
            ew.WeaponRegiment = txtwregiment.Text;
            if (txtwregiment.Text == "" || txtwname.Text == "" || txtwmodel.Text == "" || txtwmanufact.Text == "" || txtwid.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("Enter Data to All Field");
            }
            else
            {
                try
                {
                    status = ap.UpdateWeapon(ew);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (status == true)
            {
                MessageBox.Show("Weapons Data Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Weapons Data is Not Updated Successfully!");
            }
            load();

        }

        private void FormWeapons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militaryEquipmentManagementDataSet3.weaponTable' table. You can move, or remove it, as needed.
           // this.weaponTableTableAdapter.Fill(this.militaryEquipmentManagementDataSet3.weaponTable);

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        // End OF CLASS 
    }
}
