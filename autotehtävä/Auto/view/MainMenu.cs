using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.model;
using Autokauppa.controller;
using System.Data.SqlClient;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();




        KaupanLogiikka registerHandler = new KaupanLogiikka();

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ComboAutonmerkki.DataSource = dbModel.getAllAutoMakersFromDatabase();
            ComboAutonmerkki.DisplayMember = "Merkki";
            ComboAutonmerkki.ValueMember = "ID";

            int index = ComboAutonmerkki.SelectedIndex;

            ComboAutonmalli.DataSource = dbModel.getAutoModelsByMakerId(index);
            ComboAutonmalli.DisplayMember = "Auton_mallin_nimi";
            ComboAutonmalli.ValueMember = "ID";


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TestaaTietokantayhteytta_Click(object sender, EventArgs e)
        {
            registerHandler.TestDatabaseConnection();
        }

        private void ComboAutonmerkki_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = ComboAutonmerkki.SelectedIndex;
            

            ComboAutonmalli.DataSource = dbModel.getAutoModelsByMakerId(index);
            ComboAutonmalli.DisplayMember = "Auton_mallin_nimi";
            ComboAutonmalli.ValueMember = "ID";
        }
    }

}
