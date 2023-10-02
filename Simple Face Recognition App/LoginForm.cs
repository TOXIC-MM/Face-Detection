using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simple_Face_Recognition_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }
        HomePage landing = new HomePage();
        public static string username;
        private bool passTxt, userTxt;
        
        private void load() {
            label_error.Visible = false;
            passTxt = false; userTxt = false;
        }

        SqlConnection con = new SqlConnection("Data Source=MM-PC;Initial Catalog=Face;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Txtbox_usernamer_Click(object sender, EventArgs e)
        {
            if (userTxt == false)
            {
                txtbox_usernamer.Text = "";
                userTxt = true;
            }

        }

        private void Txtbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void logintester()
        {

            cmd = new SqlCommand("select * from Acc2 where Username=@Username and Password=@Password", con);
            cmd.Parameters.AddWithValue("@Username", txtbox_usernamer.Text);
            cmd.Parameters.AddWithValue("Password", txtbox_password.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (txtbox_password.Text.ToString() == "admin" && txtbox_usernamer.Text.ToString() == "admin")
                {

                    MessageBox.Show("You are using a legacy account to login please consider changing your password", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                xuiObjectAnimator1.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation.FadeOut, 150);
                this.Hide();
                landing.Show();
             //   xuiObjectAnimator1.FormAnimate(landing, XanderUI.XUIObjectAnimator.FormAnimation.FadeIn, 150);




            }
            else
            {
                label_error.Visible = true;
            }

            con.Close();
        }
        private void Button_login_Click(object sender, EventArgs e)
        {
            logintester();

        }

        private void txtbox_usernamer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtbox_password_Click(object sender, EventArgs e)
        {
            if (passTxt == false)
            {
                txtbox_password.Text = "";
                txtbox_password.PasswordChar = '*';
                passTxt = true;
            }
        }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (passTxt == false)
            {
                txtbox_password.Text = "";
                txtbox_password.PasswordChar = '*';
                passTxt = true;
            }
        }

        private void txtbox_usernamer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtbox_password.Focus();
        }

        private void txtbox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                logintester();
        }


        
    }
}
