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
    public partial class TroopPanel : Form
    {
        EntityTroops et = new EntityTroops();
        AdminOperations ap = new AdminOperations();

        string userid;
        public TroopPanel(string username)
        {
            userid = username;
            InitializeComponent();
        }

        private void TroopPanel_Load(object sender, EventArgs e)
        {
            et = ap.loadTroopData(userid);

            lid.Text = et.TroopID;
            lname.Text = et.TroopName;
            lemail.Text = et.TroopEmail;
            lphone.Text = et.TroopPhone;
            lgender.Text = et.TroopGender;
            laddress.Text = et.TroopAddress;
            ldob.Text = et.DateOfBirth;
            lregiment.Text = et.Regiment;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

        
    }
}
