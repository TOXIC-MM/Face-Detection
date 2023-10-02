using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Face_Recognition_App
{
    public partial class Form_Manage_Accounts : Form
    {
        public Form_Manage_Accounts()
        {
            InitializeComponent();
            btndel.Enabled = false;

        }
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Create();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtpassword.Focus();
        }


        private void Create()
        {
            if (txtpassword.Text.ToString() == "" && txtusername.Text.ToString() == "")
            {
                MessageBox.Show("Username or Password cannot be empty", "Error Creating Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=MM-PC;Initial Catalog=Face;Integrated Security=True");
                string insertusr = "Insert into Acc2(Username,Password)Values('" + txtusername.Text + "','" + txtpassword.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertusr, con); ;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Successfully Created.", "Local User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btndel.Enabled = true;
                txtpassword.Text = "";
                txtusername.Text = "";
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Manage_Accounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                HomePage landing = new HomePage();
                landing.Show();
            }
        }

        private void Form_Manage_Accounts_Load(object sender, EventArgs e)
        {

        }

        private void btncrt_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MM-PC;Initial Catalog=Face;Integrated Security=True");
            if (MessageBox.Show("This will delete admin account if you didn't made any accounts you will be locked out!", "Delete Admin?", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                string delete = "Delete from Acc2 where ID=2";
                con.Open();
                SqlCommand cmd2 = new SqlCommand(delete, con); ;
                cmd2.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
