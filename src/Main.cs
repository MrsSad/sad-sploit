using SadSploit;
using WeAreDevs_API;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private Point lastPoint;
        private ExploitAPI a = new ExploitAPI();
        public Main()
        {
            InitializeComponent();
        }
        //
        //
        /////////
        //Load//
        ///////
        //
        //
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        //
        //
        ////////////
        //Buttons//
        //////////
        //
        //
        private void OWNT_Click(object sender, EventArgs e)
        {
            admlog admin = new admlog();
            Hide();
            admin.Show();
        }
        //
        //
        private void button4_Click(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("RobloxPlayerBeta");
            if (pname.Length != 0)
            {
                a.LaunchExploit();
            }
            else
            {
                MessageBox.Show("Please run roblox first!", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        //
        //
        private void ScriptE_Click(object sender, EventArgs e)
        {
            ScriptEditor sc = new ScriptEditor();
            sc.Show();
            Hide();
        }
        //
        //
        private void button7_Click(object sender, EventArgs e)
        {
            if (a.isAPIAttached() == true)
            {
                WebClient wb = new WebClient();
                string tk = wb.DownloadString("https://pastebin.com/raw/4Gh79Ujt");
                a.SendLuaScript(tk);
                tk = "";
            }
            else
            {
                MessageBox.Show("Did you attached SadSploit?", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }
        //
        //
        private void button5_Click(object sender, EventArgs e)
        {
            if (FR.Visible == true)
            {
                FR.Hide();
            }
            else
            {
                FR.Show();
            }
        }
        //
        //
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured!", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
        }
        //
        //
        private void Clear_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Trim() != "")
            {
                fastColoredTextBox1.Text = "";
            }
        }
        //
        //
        private void __Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //
        //
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //
        private void Exec_Click(object sender, EventArgs e)
        {
            if (a.isAPIAttached() == true)
            {
                if (fastColoredTextBox1.Text != "")
                {
                    a.SendLuaScript(fastColoredTextBox1.Text);
                }
                else
                {
                    MessageBox.Show("Why you going to execute nothing?", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Did you attached SadSploit?", "SadSploit - ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        //
        //
        ////////////////
        //Move events//
        //////////////
        //
        //
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        //
        //
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //
        //
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        //
        //
        //////////
        //Timer//
        ////////
        //
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] x = Process.GetProcessesByName("RobloxPlayerBeta");
            if (x.Length > 0)
            {
                a.LaunchExploit();
            }
        }
        //
        //
    }
}


