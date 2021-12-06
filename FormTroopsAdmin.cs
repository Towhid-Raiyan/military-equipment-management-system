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
    public partial class FormTroopsAdmin : Form
    {
        AdminOperations ap = new AdminOperations();

        public FormTroopsAdmin()
        {
            InitializeComponent();
        }
        private void FormTroopsAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militaryEquipmentManagementDataSet1.troopTable' table. You can move, or remove it, as needed.
            //this.troopTableTableAdapter.Fill(this.militaryEquipmentManagementDataSet1.troopTable);    
            datetroopsDOB.CustomFormat = "dd-MM-yyyy";
            datetroopsDOB.Format = DateTimePickerFormat.Custom;
            load();
        }

        public void load()
        {
            AdminOperations operationsadmin = new AdminOperations();
            DataTable dt = operationsadmin.ViewTroopData();
            dataGridView1.DataSource = dt;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            EntityTroops et = new EntityTroops();
            bool status = false;

            et.TroopID = txttroopId.Text;
            et.TroopName = txttroopName.Text.Trim();
            et.TroopEmail = txttroopEmail.Text;
            et.TroopAddress = txttroopAddress.Text;
            et.TroopPhone = txttroopPhone.Text;
            et.TroopGender = Convert.ToString(cbtroopsGender.SelectedItem);
            et.DateOfBirth = datetroopsDOB.Value.ToString();
            et.Regiment = txttroopRegiment.Text;
            et.AssignPassword = txttroopPassword.Text.Trim();

            if (txttroopId.Text == "" || txttroopName.Text == "" || txttroopEmail.Text == "" || txttroopAddress.Text == "" || txttroopPhone.Text == "" || datetroopsDOB.Text == "" || txttroopPassword.Text == "" || txttroopRegiment.Text == "")
            {
                MessageBox.Show("Enter All Fields");
            }
            else
            {
                try
                {
                    status = ap.InsertTroops(et);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (status == true)
                {
                    MessageBox.Show("Troop Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Troop Data is Not Inserted Successfully!");
                }

            }
            load();
        }


        //search button 
        private void button4_Click(object sender, EventArgs e)
        {
            string tid = txttroopId.Text.Trim();
            EntityTroops et = new EntityTroops();
            DateTime dob;

            et = ap.SearchTroop(tid);

            txttroopName.Text = et.TroopName;
            txttroopId.Text = et.TroopID;
            txttroopEmail.Text = et.TroopEmail;
            txttroopPhone.Text = et.TroopPhone;
            txttroopAddress.Text = et.TroopAddress;
            txttroopRegiment.Text = et.Regiment;
            txttroopPassword.Text = et.AssignPassword;
            //txtdob.Text = et.DateOfBirth;
            dob = Convert.ToDateTime(et.DateOfBirth);
            datetroopsDOB.Value = dob;
            if(et.TroopGender == "Male")
            {
                cbtroopsGender.SelectedIndex = 0;
            }
            else
            {
                cbtroopsGender.SelectedIndex = 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tid = txttroopId.Text.Trim();
            bool status = false;

            try
            {
                status = ap.DeleteTroop(tid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (status == true)
            {
                MessageBox.Show("Troop Data Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Troop Data is Not Deleted Successfully!");
            }
            load();

        }


        //update button
        private void button3_Click(object sender, EventArgs e)
        {
            EntityTroops et = new EntityTroops();
            bool status = false;

            et.TroopID = txttroopId.Text;
            et.TroopName = txttroopName.Text.Trim();
            et.TroopEmail = txttroopEmail.Text;
            et.TroopAddress = txttroopAddress.Text;
            et.TroopPhone = txttroopPhone.Text;
            et.TroopGender = Convert.ToString(cbtroopsGender.SelectedItem);
            et.DateOfBirth = datetroopsDOB.Text;
            et.Regiment = txttroopRegiment.Text;
            et.AssignPassword = txttroopPassword.Text.Trim();

            if (txttroopId.Text == "" || txttroopName.Text == "" || txttroopEmail.Text == "" || txttroopAddress.Text == "" || txttroopPhone.Text == "" || datetroopsDOB.Text == "" || txttroopPassword.Text == "" || txttroopRegiment.Text == "")
            {
                MessageBox.Show("Enter All Fields");
            }
            else
            {
                try
                {
                    status = ap.update(et);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (status == true)
                {
                    MessageBox.Show("Troop Data Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Troop Data is Not Updated Successfully!");
                }

            }
            load();

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }


    }
}
