using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tenant_management
{

    public partial class AdminLogin : Form
    {
        private string savedUsername = "Admin123";
        public AdminLogin()
        {
            InitializeComponent();
        }
       
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;

            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0';
        }

       
    

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
            else
            {
                savedUsername = txtUsername.Text; // optional
            }
        }

        
      



        private void button1_Click(object sender, EventArgs e)
        {
           

           
            {
                

                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();

                this.Hide(); 
            }
            
            {
               
            }
        }
        

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}







