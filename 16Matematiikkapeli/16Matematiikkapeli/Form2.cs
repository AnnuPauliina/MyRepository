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
    public partial class Form2 : Form
    {
        public static int plusHighScore;
        public Form2()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            FormPlus formplus = new FormPlus();
            formplus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            FormMiinus formMiinus = new FormMiinus();
            formMiinus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            FormJako formJako = new FormJako();
            formJako.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
;

            FormKerto formKerto = new FormKerto();
            formKerto.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblpluspisteet.Text = FormPlus.highscore.ToString();
             
        }

        private void lblpluspisteet_Click(object sender, EventArgs e)
        {
              
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            lblpluspisteet.Text = FormPlus.highscore.ToString();
            plusHighScore = Int32.Parse(lblpluspisteet.Text);
            Invalidate();
        }
    }
}

