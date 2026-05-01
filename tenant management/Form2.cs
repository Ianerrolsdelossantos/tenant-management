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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_LocationChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Optional: confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                  "Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Go back to login form
                AdminLogin login = new AdminLogin();
                login.Show();

                // Close current form
                this.Hide(); // or this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SettingsTab login = new SettingsTab();
            login.Show();

            // Close dashboard form
            this.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            INBOX login = new INBOX();
            login.Show();

            // Back to dashboard form
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reporttab login = new Reporttab();
            login.Show();

            // Back to dashboard form
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaymentTab login = new PaymentTab();
            login.Show(); 

            // Back to dashboard form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TenantTab login = new TenantTab();
            login.Show();

            // Back to dashboard form
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            RoomUnittab login = new RoomUnittab();
            login.Show();

            // Back to dashboard form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard login = new AdminDashboard();
            login.Show();

            // Back to dashboard form
            this.Close();
        }
    }
}
public class dateTimePicker1 : DateTimePicker
{
    protected override void OnValueChanged(EventArgs eventargs)
    {
        base.OnValueChanged(eventargs);
        // Your custom logic here
    }
}