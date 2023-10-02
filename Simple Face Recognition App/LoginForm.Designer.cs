namespace Simple_Face_Recognition_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbox_usernamer = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.label_error = new System.Windows.Forms.Label();
            this.button_login = new XanderUI.XUISuperButton();
            this.xuiObjectAnimator1 = new XanderUI.XUIObjectAnimator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_usernamer
            // 
            this.txtbox_usernamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(218)))));
            this.txtbox_usernamer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_usernamer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_usernamer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(169)))));
            this.txtbox_usernamer.Location = new System.Drawing.Point(381, 290);
            this.txtbox_usernamer.Name = "txtbox_usernamer";
            this.txtbox_usernamer.Size = new System.Drawing.Size(226, 22);
            this.txtbox_usernamer.TabIndex = 1;
            this.txtbox_usernamer.Text = "Username";
            this.txtbox_usernamer.Click += new System.EventHandler(this.Txtbox_usernamer_Click);
            this.txtbox_usernamer.TextChanged += new System.EventHandler(this.txtbox_usernamer_TextChanged);
            this.txtbox_usernamer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_usernamer_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.Body_textbox_username;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(370, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 41);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.Body_textbox_username;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(370, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 41);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(218)))));
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(169)))));
            this.txtbox_password.Location = new System.Drawing.Point(381, 337);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(173, 22);
            this.txtbox_password.TabIndex = 2;
            this.txtbox_password.Text = "Password";
            this.txtbox_password.Click += new System.EventHandler(this.Txtbox_password_Click);
            this.txtbox_password.TextChanged += new System.EventHandler(this.Txtbox_password_TextChanged);
            this.txtbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_password_KeyDown);
            this.txtbox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_password_KeyPress);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.BackColor = System.Drawing.Color.Transparent;
            this.label_error.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.White;
            this.label_error.Location = new System.Drawing.Point(399, 373);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(198, 15);
            this.label_error.TabIndex = 3;
            this.label_error.Text = "username or password is not correct";
            // 
            // button_login
            // 
            this.button_login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(218)))));
            this.button_login.ButtonImage = null;
            this.button_login.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.button_login.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.button_login.ButtonText = ">";
            this.button_login.CornerRadius = 10;
            this.button_login.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_login.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(169)))));
            this.button_login.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(73)))));
            this.button_login.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.button_login.Location = new System.Drawing.Point(575, 331);
            this.button_login.Name = "button_login";
            this.button_login.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(73)))));
            this.button_login.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(73)))));
            this.button_login.Size = new System.Drawing.Size(38, 36);
            this.button_login.SuperSelected = false;
            this.button_login.TabIndex = 3;
            this.button_login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(73)))));
            this.button_login.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.Login_Page2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 611);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_usernamer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1018, 650);
            this.MinimumSize = new System.Drawing.Size(1018, 650);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "Face Detection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_usernamer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label label_error;
        private XanderUI.XUISuperButton button_login;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator1;
    }
}

