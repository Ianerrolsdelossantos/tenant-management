using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace tenant_management
{
    public partial class AdminLogin : Form
    {


        public AdminLogin()
        {
            InitializeComponent();
        }
       
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Black;

            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '\0';

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.BorderColor = Color.DarkBlue;
       
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.BorderColor = Color.Gray;
    
            SetButtonRadius(button1, 20);
            SetButtonRadius(button2, 20);
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
                savedUsername = txtUsername.Text;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void SetButtonRadius(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
        
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - 1 - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(btn.Width - 1 - radius, btn.Height - 1 - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - 1 - radius, radius, radius), 90, 90);
            path.CloseFigure();
      
            btn.Region = new Region(path);

            btn.Paint += (s, e) =>
            {
                using (GraphicsPath borderPath = new GraphicsPath())
                {
                    borderPath.StartFigure();
                    borderPath.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                    borderPath.AddArc(new Rectangle(btn.Width - 1 - radius, 0, radius, radius), 270, 90);
                    borderPath.AddArc(new Rectangle(btn.Width - 1 - radius, btn.Height - 1 - radius, radius, radius), 0, 90);
                    borderPath.AddArc(new Rectangle(0, btn.Height - 1 - radius, radius, radius), 90, 90);
                    borderPath.CloseFigure();

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    using (Pen pen = new Pen(btn.FlatAppearance.BorderColor, btn.FlatAppearance.BorderSize))
                    {
                        e.Graphics.DrawPath(pen, borderPath);
                    }
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
           
            string correctUsername = "admin";
            string correctPassword = "12345";

            if (username.Any(char.IsDigit))
            {
                MessageBox.Show("Username should not contain numbers.");
                return;
            }
                
            if (username == correctUsername && password == correctPassword)
            {
                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}