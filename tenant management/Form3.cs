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
    public partial class SettingsTab : Form
    {
        public SettingsTab()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard login = new AdminDashboard();
            login.Show();

            // Back to dashboard form
            this.Close();
        }

        private void SettingsTab_Load(object sender, EventArgs e)
        {

        }
    }
}
