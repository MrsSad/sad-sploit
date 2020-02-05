namespace SadSploit
{
    partial class admlog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admlog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminuser = new FlatUI.FlatTextBox();
            this.adminpass = new FlatUI.FlatTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flatButton1 = new FlatUI.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SadSploit.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // adminuser
            // 
            this.adminuser.BackColor = System.Drawing.Color.Transparent;
            this.adminuser.FocusOnHover = false;
            this.adminuser.Location = new System.Drawing.Point(48, 103);
            this.adminuser.MaxLength = 32767;
            this.adminuser.Multiline = false;
            this.adminuser.Name = "adminuser";
            this.adminuser.ReadOnly = false;
            this.adminuser.Size = new System.Drawing.Size(193, 29);
            this.adminuser.TabIndex = 1;
            this.adminuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminuser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adminuser.UseSystemPasswordChar = false;
            // 
            // adminpass
            // 
            this.adminpass.BackColor = System.Drawing.Color.Transparent;
            this.adminpass.FocusOnHover = false;
            this.adminpass.Location = new System.Drawing.Point(48, 191);
            this.adminpass.MaxLength = 32767;
            this.adminpass.Multiline = false;
            this.adminpass.Name = "adminpass";
            this.adminpass.ReadOnly = false;
            this.adminpass.Size = new System.Drawing.Size(193, 29);
            this.adminpass.TabIndex = 2;
            this.adminpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminpass.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adminpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin Password";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BackgroundImage = global::SadSploit.Properties.Resources.background;
            this.flatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.CausesValidation = false;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(48, 283);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(193, 32);
            this.flatButton1.TabIndex = 5;
            this.flatButton1.Text = "Login";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // admlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 409);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminpass);
            this.Controls.Add(this.adminuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admlog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatTextBox adminuser;
        private FlatUI.FlatTextBox adminpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FlatUI.FlatButton flatButton1;
    }
}