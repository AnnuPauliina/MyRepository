using System;
using System.Windows.Forms;

namespace _16Matematiikkapeli
{
    public partial class FormPlus : Form2
    {

        Random rand = new Random();
        private int labelone = 0;
        private int labeltwo = 0;
        private int pisteet = 0;
        private int tulos = 0;
        private int arvo1 = 0;
        private int arvo2 = 0;

        public static int highscore = 0;

        public int Labeltwo { get => labeltwo; set => labeltwo = value; }
        public int Labelone { get => labelone; set => labelone = value; }

        public FormPlus()
        {
            InitializeComponent();
        }


        private void boxtulos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblensimmäinen_Click(object sender, EventArgs e)
        {

        }

        private void FormPlus_Load(object sender, EventArgs e)
        {
            lblpisteet.Text = "0";
            Labelone = rand.Next(1, 10000);
            Labeltwo = rand.Next(1, 10000);

            lblensimmäinen.Text = Labelone.ToString();
            lbltoinen.Text = Labeltwo.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            tulos = Int32.Parse(boxtulos.Text);
            arvo1 = Int32.Parse(lblensimmäinen.Text);
            arvo2 = Int32.Parse(lbltoinen.Text);
            lblpisteet.Text = pisteet.ToString();

            if (tulos == arvo1 + arvo2)
            {
                pisteet++;
                lblpisteet.Text = pisteet.ToString();
                

                Labelone = rand.Next(1, 10000);
                Labeltwo = rand.Next(1, 10000);

                lblensimmäinen.Text = Labelone.ToString();
                lbltoinen.Text = Labeltwo.ToString();

                boxtulos.Text = "";

                //lblpisteet.Text = Form2.lblpluspisteet.Text();
            }

            else
            {
                MessageBox.Show("Vastauksesi on väärin. Yritä uudelleen!");
                if (Int32.Parse(lblpisteet.Text) > Form2.plusHighScore);
                {
                    int highscore = Int32.Parse(lblpisteet.Text);
                }

            }
        }
    }
}
