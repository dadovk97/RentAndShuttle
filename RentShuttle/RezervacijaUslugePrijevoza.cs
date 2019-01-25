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
    public partial class RezervacijaUslugePrijevoza : Form
    {
        public RezervacijaUslugePrijevoza()
        {
            InitializeComponent();
            rezervacija.BackColor = Color.Teal;
            rezervacija.ForeColor = Color.White;
            popuniOdrediste();
            popuniPolaziste();
        }

        private void RezervirajUslugu_Click(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();

            if (ImeUsluga.Text == "" || ImeUsluga.Text == "Ime" || PrezimeUsluga.Text == "" || PrezimeUsluga.Text == "Prezime" ||
                OIBUsluga.Text == "" || OIBUsluga.Text == "OIB" || EmailUsluga.Text == "" || EmailUsluga.Text == "Email" || Polaziste.Text == "" ||
                Polaziste.Text == "-Neodređeno-" || Odrediste.Text == "" || Odrediste.Text == "-Neodređeno-" ||  AdresaUsluga.Text == "" || 
                AdresaUsluga.Text == "Adresa" || PostanskiBrojUsluga.Text == "" || PostanskiBrojUsluga.Text == "Poštanski Broj" || 
                BrojMobitelaUsluga.Text == "Broj Mobitela" || BrojMobitelaUsluga.Text == "" || BrojOsobaUsluga.Text == "")
            {
                RezervacijaUslugeUpozorenje otvori = new RezervacijaUslugeUpozorenje();
                otvori.Show();
            }
            else
            {
                string query = "INSERT INTO Prijevoz(ImeKorisnikaPrijevoza,PrezimeKorisnikaPrijevoza,OIBKorisnikaPrijevoza, " +
                    "EmailKorisnikaPrijevoza, Polaziste,Odrediste,VrijemePolazak, Adresa, PostanskiBrojKorisnikaPrijevoza," +
                    "BrojMobitelaKorisnika, BrojOsoba) VALUES" +
                    "('" + ImeUsluga.Text + "', '" + PrezimeUsluga.Text + "', '" + OIBUsluga.Text + "', '" + EmailUsluga.Text + "' " +
                    ", '" + Polaziste.Text.ToString() + "', '" + Odrediste.Text.ToString() + "', '" + DatumPolaskaUsluga.Value.ToString() + "', '" + 
                    AdresaUsluga.Text + "' ,'" + PostanskiBrojUsluga.Text + "','"+ BrojMobitelaUsluga.Text + "','" + 
                    BrojOsobaUsluga.Text + "')";

                SqlCommand sqlcomm = new SqlCommand(query, con);

                sqlcomm.ExecuteNonQuery();
                RezervacijaUslugeUspjesno otvori = new RezervacijaUslugeUspjesno();
                otvori.Show();
                this.Hide();
            }
            con.Close();
        }

        private void odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void ImeUsluga_Click(object sender, EventArgs e)
        {
            ImeUsluga.Clear();
        }

        private void PrezimeUsluga_Click(object sender, EventArgs e)
        {
            PrezimeUsluga.Clear();
        }

        private void OIBUsluga_Click(object sender, EventArgs e)
        {
            OIBUsluga.Clear();
        }

        private void EmailUsluga_Click(object sender, EventArgs e)
        {
            EmailUsluga.Clear();
        }

        private void AdresaUsluga_Click(object sender, EventArgs e)
        {
            AdresaUsluga.Clear();
        }

        private void PostanskiBrojUsluga_Click(object sender, EventArgs e)
        {
            PostanskiBrojUsluga.Clear();
        }

        private void BrojMobitelaUsluga_Click (object sender, EventArgs e)
        {
            BrojMobitelaUsluga.Clear();
        }

        private void popuniPolaziste()
        {
            try
            {
                var con = DB.GetSqlkonekcija();
                string val = "SELECT Grad FROM Poslovnica";
                con.Open();
                SqlDataReader dr = new SqlCommand(val, con).ExecuteReader();

                while (dr.Read())
                {
                    Polaziste.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void popuniOdrediste()
        {
            try
            {
                var con = DB.GetSqlkonekcija();
                string val = "SELECT Grad FROM Poslovnica";
                con.Open();
                SqlDataReader dr = new SqlCommand(val, con).ExecuteReader();

                while (dr.Read())
                {
                    Odrediste.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void rezervacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledRezervacija otvori = new PregledRezervacija();
            otvori.Show();
        }
    }
}
