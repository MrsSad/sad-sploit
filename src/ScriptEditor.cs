using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace SadSploit
{
    public partial class ScriptEditor : Form
    {
        private Point lastPoint;
        public ScriptEditor()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            Hide();
            mn.Show();
        }

        private void __Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Trim() != "")
            {
                Clipboard.SetText(fastColoredTextBox1.Text);
                MessageBox.Show("Copied to clipboard!", "SadSploit - Script Editor", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}
