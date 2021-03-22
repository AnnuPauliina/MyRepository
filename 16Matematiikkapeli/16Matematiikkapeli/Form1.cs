using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16Matematiikkapeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            string id = boxUserID.Text;
            string pass = boxPassword.Text;

            if (id == "Kaktus" && pass == "kaktus2020")
            {
                this.Hide();

                Form2 form2 = new Form2();
                form2.Show();
            }

            else
            {
                MessageBox.Show("Password or email is incorrect.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }

        private void boxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                ResetMyForm();
            }
        }

        private void ResetMyForm()
        {
            boxUserID.Text = "";
            boxPassword.Text = "";
        }

        private void btnKirjaudu_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
