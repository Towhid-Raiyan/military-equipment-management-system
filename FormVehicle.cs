using DataAccessLayer.Entites;
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
    public partial class FormVehicle : Form
    {
        AdminOperations ap = new AdminOperations();

        EntityVehicle ev = new EntityVehicle();

        public FormVehicle()
        {
            InitializeComponent();
        }

        //Load Weapon Data from Database
        public void load()
        {
            AdminOperations operationsadmin = new AdminOperations();
            DataTable dt = operationsadmin.ViewVehicle();
            dataGridView1.DataSource = dt;
        }


        // Insert Vehcile Data
        private void InsertVehicle_Click(object sender, EventArgs e)
        {
            EntityVehicle ev = new EntityVehicle();
            bool status = false;

            ev.VID = txtvid.Text.Trim();
            ev.VName = txtvname.Text;
            ev.VModel = txtvmodel.Text;
            ev.VManufact = txtvmanufact.Text;
            ev.VActiveQuantity = txtvquantity.Text;
            ev.VRegiment = txtvregiment.Text;

            try
            {
                status = ap.InsertVehicle(ev);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (status == true)
            {
                MessageBox.Show("Vehicle Data Inserted Successfully!");
            }
            else
            {
                MessageBox.Show("Vehicle Data is Not Inserted Successfully!");
            }
            load();


        }

        // Delete Vehicle Data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string vid = txtvid.Text.Trim();
            bool status = false;

            try
            {
                status = ap.DeleteVehicle(vid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (status == true)
            {
                MessageBox.Show("Vehicle Data Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Vehicle Data is Not Deleted Successfully!");
            }
            load();
        }

        // Update vehicle Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityVehicle ev = new EntityVehicle();
            bool status = false;

            ev.VID = txtvid.Text.Trim();
            ev.VName = txtvname.Text;
            ev.VModel = txtvmodel.Text;
            ev.VManufact = txtvmanufact.Text;
            ev.VActiveQuantity = txtvquantity.Text;
            ev.VRegiment = txtvregiment.Text;

            status = ap.UpdateVehicle(ev);
            if (status == true)
            {
                MessageBox.Show("Vehicle Data Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Vehicle Data is Not Updated Successfully!");
            }
            load();
        }

        //Search Vehicle Data
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string vid = txtvid.Text.Trim();
            EntityVehicle ev = new EntityVehicle();

            try
            {
                ev = ap.SearchVehicle(vid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtvid.Text = ev.VID;
            txtvname.Text = ev.VName;
            txtvmodel.Text = ev.VModel;
            txtvmanufact.Text = ev.VManufact;
            txtvquantity.Text = ev.VActiveQuantity;
            txtvregiment.Text = ev.VRegiment;

        }

        private void FormVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militaryEquipmentManagementDataSet2.vehicleTable' table. You can move, or remove it, as needed.
            //this.vehicleTableTableAdapter.Fill(this.militaryEquipmentManagementDataSet2.vehicleTable);

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }
    }
}
