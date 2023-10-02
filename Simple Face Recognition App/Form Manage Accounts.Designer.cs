namespace Simple_Face_Recognition_App
{
    partial class Form_Manage_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Manage_Accounts));
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncrt = new XanderUI.XUISuperButton();
            this.btndel = new XanderUI.XUISuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbluser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbluser.Location = new System.Drawing.Point(9, 15);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(60, 15);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Username";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpass.Location = new System.Drawing.Point(9, 57);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(57, 15);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(218)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(44)))));
            this.txtusername.Location = new System.Drawing.Point(72, 15);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(172, 18);
            this.txtusername.TabIndex = 1;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(218)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(44)))));
            this.txtpassword.Location = new System.Drawing.Point(72, 58);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(172, 18);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Simple_Face_Recognition_App.Properties.Resources.Body_textbox_username;
            this.pictureBox1.Location = new System.Drawing.Point(66, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Simple_Face_Recognition_App.Properties.Resources.Body_textbox_username;
            this.pictureBox2.Location = new System.Drawing.Point(66, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btncrt
            // 
            this.btncrt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.btncrt.ButtonImage = null;
            this.btncrt.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btncrt.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btncrt.ButtonText = "Create Account";
            this.btncrt.CornerRadius = 7;
            this.btncrt.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btncrt.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.btncrt.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.btncrt.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btncrt.Location = new System.Drawing.Point(131, 93);
            this.btncrt.Name = "btncrt";
            this.btncrt.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.btncrt.SelectedTextColor = System.Drawing.Color.White;
            this.btncrt.Size = new System.Drawing.Size(113, 46);
            this.btncrt.SuperSelected = false;
            this.btncrt.TabIndex = 7;
            this.btncrt.TextColor = System.Drawing.Color.White;
            this.btncrt.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btncrt.Click += new System.EventHandler(this.btncrt_Click);
            // 
            // btndel
            // 
            this.btndel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.btndel.ButtonImage = null;
            this.btndel.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btndel.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btndel.ButtonText = "Delete Legacy Accounts(admin)";
            this.btndel.CornerRadius = 7;
            this.btndel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btndel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.btndel.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.btndel.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btndel.Location = new System.Drawing.Point(12, 93);
            this.btndel.Name = "btndel";
            this.btndel.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.btndel.SelectedTextColor = System.Drawing.Color.White;
            this.btndel.Size = new System.Drawing.Size(113, 46);
            this.btndel.SuperSelected = false;
            this.btndel.TabIndex = 7;
            this.btndel.TextColor = System.Drawing.Color.White;
            this.btndel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Form_Manage_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 156);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btncrt);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(284, 195);
            this.MinimumSize = new System.Drawing.Size(284, 195);
            this.Name = "Form_Manage_Accounts";
            this.Text = "Manage User Accounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Manage_Accounts_FormClosing);
            this.Load += new System.EventHandler(this.Form_Manage_Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private XanderUI.XUISuperButton btncrt;
        private XanderUI.XUISuperButton btndel;
    }
}