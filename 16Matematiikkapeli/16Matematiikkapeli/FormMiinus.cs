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
    public partial class FormMiinus : Form
    {
        Random rand = new Random();
        int labelone = 0;
        int labeltwo = 0;
        int pisteet = 0;

        public FormMiinus()
        {
            InitializeComponent();
        }

        private void FormMiinus_Load(object sender, EventArgs e)
        {
            lblpisteet.Text = "0";
            labelone = rand.Next(1, 10000);
            labeltwo = rand.Next(1, 10000);

            lblensimmäinen.Text = labelone.ToString();
            lbltoinen.Text = labeltwo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tulos = Int32.Parse(boxtulos.Text);
            int arvo1 = Int32.Parse(lblensimmäinen.Text);
            int arvo2 = Int32.Parse(lbltoinen.Text);
            lblpisteet.Text = pisteet.ToString();


            if (tulos == arvo1 - arvo2)
            {
                pisteet++;
                lblpisteet.Text = pisteet.ToString();

                labelone = rand.Next(1, 10000);
                labeltwo = rand.Next(1, 10000);

                lblensimmäinen.Text = labelone.ToString();
                lbltoinen.Text = labeltwo.ToString();

            }

            else
            {
                MessageBox.Show("Vastauksesi on väärin. Yritä uudelleen!");
            }
        }
    }
}
