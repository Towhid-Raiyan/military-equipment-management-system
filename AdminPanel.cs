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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTroopsAdmin fta = new FormTroopsAdmin();
            fta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormWeapons fw = new FormWeapons();
            fw.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVehicle fv = new FormVehicle();
            fv.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormExplosive fe = new FormExplosive();
            fe.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
    }
}
