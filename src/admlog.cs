using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace SadSploit
{
    public partial class admlog : Form
    {
        private Point lastPoint;
        public admlog()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = ; user id = ; password = ; database = ");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from roots where username = '" + adminuser.Text + "' and password = '" + adminpass.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AdminForm adm = new AdminForm();
                adm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
