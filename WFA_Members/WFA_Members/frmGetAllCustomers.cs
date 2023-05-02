using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Members
{
    public partial class frmGetAllCustomers : Form
    {
        Member_Services services;
        public frmGetAllCustomers()
        {
            InitializeComponent();
            services = new Member_Services();
        }

        private void GetAllCustomers_Load(object sender, EventArgs e)
        {
            var result = services.GetAllCustomers();

            DGView.DataSource = result;
        }
    }
}
