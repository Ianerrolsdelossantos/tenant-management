using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tenant_management
{
    public partial class TenantTab : Form
    {
        public TenantTab()
        {
            InitializeComponent();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard login = new AdminDashboard();
            login.Show();

            // Back to dashboard form
            this.Close();
        }
    }
}
