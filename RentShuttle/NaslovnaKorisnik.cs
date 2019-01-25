using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentShuttle
{
    public partial class NaslovnaKorisnik : Form
    {
        public NaslovnaKorisnik()
        {
            InitializeComponent();
        }

        private void odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void rezervacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tip_rezervacije tip_Rezervacije = new Tip_rezervacije();
            tip_Rezervacije.Show();
        }

        private void pregledrez_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledRezervacija rezervacije = new PregledRezervacija();
            rezervacije.Show();
        }
        
        private void bunifuRating2_onValueChanged(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();

            if (bunifuRating2.Value == 1)
            {
                string query = $"INSERT INTO Recenzija(Ocjena) VALUES ('{bunifuRating2.Value}')";
                SqlCommand sqlcomm = new SqlCommand(query, con);

                sqlcomm.ExecuteNonQuery();
                Recenzija otvori = new Recenzija();
                otvori.Show();
                bunifuRating2.Hide();
            }

            if (bunifuRating2.Value == 2)
            {
                string query = $"INSERT INTO Recenzija(Ocjena) VALUES ('{bunifuRating2.Value}')";
                SqlCommand sqlcomm = new SqlCommand(query, con);

                sqlcomm.ExecuteNonQuery();
                Recenzija otvori = new Recenzija();
                otvori.Show();
                bunifuRating2.Hide();

            }

            if (bunifuRating2.Value == 3)
            {
                string query = $"INSERT INTO Recenzija(Ocjena) VALUES ('{bunifuRating2.Value}')";
                SqlCommand sqlcomm = new SqlCommand(query, con);

                sqlcomm.ExecuteNonQuery();
                Recenzija otvori = new Recenzija();
                otvori.Show();
                bunifuRating2.Hide();
            }

            if (bunifuRating2.Value == 4)
            {
                string query = $"INSERT INTO Recenzija(Ocjena) VALUES ('{bunifuRating2.Value}')";
                SqlCommand sqlcomm = new SqlCommand(query, con);

                sqlcomm.ExecuteNonQuery();
                Recenzija otvori = new Recenzija();
                otvori.Show();
                bunifuRating2.Hide();
            }

            if (bunifuRating2.Value == 5)
            {
                string query = $"INSERT INTO Recenzija(Ocjena) VALUES ('{bunifuRating2.Value}')";
                SqlCommand sqlcomm = new SqlCommand(query, con);

                sqlcomm.ExecuteNonQuery();
                Recenzija otvori = new Recenzija();
                otvori.Show();
                bunifuRating2.Hide();
            }
            con.Close();
        }
        
    }
}
