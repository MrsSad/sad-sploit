using WindowsFormsApp1;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SadSploit
{
    public partial class AdminForm : Form
    {
        private Point lastPoint;
        public AdminForm()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server = remotemysql.com; user id = OFwjckvGPT; password = JfSCc4x5oz; database = OFwjckvGPT");
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "users");
                dataGridView1.DataSource = ds.Tables["users"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "")
            {
                if (txtpass.Text != "")
                {
                    try
                    {
                        string MyConnection2 = "server = remotemysql.com; user id = OFwjckvGPT; password = JfSCc4x5oz; database = OFwjckvGPT";
                        string Query = "INSERT INTO `users` (`id`, `username`, `password`) VALUES (NULL, '" + txtuser.Text + "', '" + txtpass.Text + "')";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Succesfully registered in: user:'" + txtuser.Text + "'with password: '" + txtpass.Text + "'");
                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                        MySqlConnection connection = new MySqlConnection("server = remotemysql.com; user id = OFwjckvGPT; password = JfSCc4x5oz; database = OFwjckvGPT");
                        MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users", connection);
                        connection.Open();
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "users");
                        dataGridView1.DataSource = ds.Tables["users"];
                        connection.Close();
                        txtuser.Text = "";
                        txtpass.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all of data!", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Please fill all of data!", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                try
                {
                    string MyConnection2 = "server = remotemysql.com; user id = OFwjckvGPT; password = JfSCc4x5oz; database = OFwjckvGPT";
                    string Query = "DELETE FROM `users` WHERE `users`.`id` = '" + txtid.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Succesfully deleted user with id '" + txtid.Text + "'");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    MySqlConnection connection = new MySqlConnection("server = remotemysql.com; user id = OFwjckvGPT; password = JfSCc4x5oz; database = OFwjckvGPT");
                    MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "users");
                    dataGridView1.DataSource = ds.Tables["users"];
                    connection.Close();
                    txtid.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Please fill all of data!", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void __Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void X_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            Hide();
            main.Show();
        }

        private void dataGridView1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void dataGridView1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
