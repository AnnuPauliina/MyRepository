
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;




namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        public SqlConnection dbYhteys = new SqlConnection();
        SqlDataReader reader;
        SqlCommand command;


        public DatabaseHallinta()
        {
           yhteysTiedot = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autokauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public bool connectDatabase()
        {
            dbYhteys.ConnectionString = yhteysTiedot;
            
            try
            { 
                dbYhteys.Open();
                Console.WriteLine("Tietokantayhteys onnistui.");
                return true;

            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }
            
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;

            
        }

        public List<AutonMerkki> getAllAutoMakersFromDatabase()
        {
            List<AutonMerkki> listmerkki = new List<AutonMerkki>();
            connectDatabase();

            command = new SqlCommand("select * from dbo.AutonMerkki", dbYhteys);
            reader = command.ExecuteReader();

            while (reader != null && reader.Read())
            {

                AutonMerkki merkki = new AutonMerkki()
                {
                    Id = (int)reader["ID"],
                    Merkki = reader["Merkki"].ToString()
                };
                listmerkki.Add(merkki);
            }

            disconnectDatabase();

            return listmerkki;
            
        }

        public List<AutonMalli> getAutoModelsByMakerId(int makerId) 
             
        {
            List<AutonMalli> listmalli = new List<AutonMalli>();
            connectDatabase();

            command = new SqlCommand("select * from dbo.AutonMallit where AutonMerkkiID = " + makerId, dbYhteys);
            reader = command.ExecuteReader();

            while (reader != null && reader.Read())
            {

                AutonMalli malli = new AutonMalli()
                {
                    Id = (int)reader["ID"],
                    Auton_mallin_nimi = reader["Auton_mallin_nimi"].ToString(),
                    AutonmerkkiId = (int)reader["AutonMerkkiID"]
                };
                listmalli.Add(malli);
            }

            disconnectDatabase();

            return listmalli;

        }

    }
}
