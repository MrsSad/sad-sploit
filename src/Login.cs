using WindowsFormsApp1;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Exploit___remake
{
    public partial class Login : Form
    {
        private Main main = new Main();
        private Point lastPoint;
        public Login()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = ; user id = ; password = ; database = ");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from users where username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}