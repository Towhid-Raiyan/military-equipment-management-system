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
    public partial class LoginForm : Form
    {
        AdminOperations adminOperations = new AdminOperations();
        TroopLogin tl = new TroopLogin();

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            paneltroop.Visible = false;
            panelAdmin.Visible = false;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
            paneltroop.Visible = false;    
            panelAdmin.Visible = true;
        }

        private void btnTroop_Click(object sender, EventArgs e)
        {
            
            panelAdmin.Visible = false;
            paneltroop.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormTroopsAdmin formTroopsAdmin = new FormTroopsAdmin();
            formTroopsAdmin.Show();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {

            string username = txtadminuser.Text.Trim();
            string password = txtadminpass.Text.Trim();
            bool status = false;
            

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password feild can not be empty!");
            }
            else
            {
                try
                {
                    status = adminOperations.login(username, password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (status == true)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Information!");
                }
                
            }

        }

        private void troopLogin_Click(object sender, EventArgs e)
        {
            string username = txttroopuser.Text.Trim();
            string password = txttrooppass.Text.Trim();
            bool status = false;

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password feild can not be empty!");
            }
            else
            {
                try
                {
                    status = tl.trooplogin(username, password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (status == true)
                {
                    //MessageBox.Show("Success");
                    TroopPanel tp = new TroopPanel(username);
                    tp.Show();
                    this.Hide();

                    /*AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();*/
                }
                else
                {
                    MessageBox.Show("Invalid Information!");
                }

            }

        }
    }
}
