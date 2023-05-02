using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Members
{
    public partial class Home : Form
    {
        private frmGetAllCustomers frmAllCustomers;
        public Home()
        {
            InitializeComponent();
            frmAllCustomers = new frmGetAllCustomers();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void GetAllCustomers_Click(object sender, EventArgs e)
        {
            frmAllCustomers.ShowDialog();

        }

        private void GetCustomerById_Click(object sender, EventArgs e)
        {
            var level = Enums.Find;
            //MessageBox.Show(myGame.P2.Money.ToString());
            frmFindOrDelete frm = new frmFindOrDelete();
            frm.ShowDialog();

        }


        private void Create_Click(object sender, EventArgs e)
        {
            var level = Enums.Create;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var level = Enums.Update;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var level = Enums.Delete;
            frmFindOrDelete frm = new frmFindOrDelete();
            frm.ShowDialog();
        }
    }
}
