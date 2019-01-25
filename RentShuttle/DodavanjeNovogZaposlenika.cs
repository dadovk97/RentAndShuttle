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
    public partial class DodavanjeNovogZaposlenika : Form
    {
        public DodavanjeNovogZaposlenika()
        {
            InitializeComponent();
            popuniPoslovnicu();
        }

        private void PopisZaposlenika_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zaposlenici PopisZaposlenika = new Zaposlenici();
            PopisZaposlenika.Show();
        }

        private void Odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void OibZaposlenika_Click(object sender, EventArgs e)
        {
            OibZaposlenika.Clear();

        }

        private void ImeZaposlenika_Click(object sender, EventArgs e)
        {
            ImeZaposlenika.Clear();
        }

        private void PrezimeZaposlenika_Click(object sender, EventArgs e)
        {
            PrezimeZaposlenika.Clear();
        }

        private void EmailZaposlenika_Click(object sender, EventArgs e)
        {
            EmailZaposlenika.Clear();
        }

        private void LozinkaZaposlenika_Click(object sender, EventArgs e)
        {
            LozinkaZaposlenika.Clear();
            LozinkaZaposlenika.PasswordChar = '*';
        }

        private void AdresaZaposlenika_Click(object sender, EventArgs e)
        {
            AdresaZaposlenika.Clear();
        }

        private void PostanskiBrojZaposlenika_Click(object sender, EventArgs e)
        {
            PostanskiBrojZaposlenika.Clear();
        }

        private void MobitelZaposlenika_Click(object sender, EventArgs e)
        {
            MobitelZaposlenika.Clear();
        }

        private void BrojRacunaZaposlenika_Click(object sender, EventArgs e)
        {
            BrojRacunaZaposlenika.Clear();
        }


        private void DodajNovogKorisnika_Click(object sender, EventArgs e)
        {
            
            if (OibZaposlenika.Text == "" || OibZaposlenika.Text == "OIB"  || ImeZaposlenika.Text == "" || ImeZaposlenika.Text == "Ime"
                || PrezimeZaposlenika.Text == "" ||PrezimeZaposlenika.Text == "Prezime" || EmailZaposlenika.Text == "" || EmailZaposlenika.Text == "Email"
                    || LozinkaZaposlenika.Text == "" || LozinkaZaposlenika.Text == "Lozinka" || DatumRodenja.Value.ToString() == "" 
                    || AdresaZaposlenika.Text == "" || AdresaZaposlenika.Text == "Adresa" || PostanskiBrojZaposlenika.Text == "" 
                    || PostanskiBrojZaposlenika.Text == "Poštanski Broj" || MobitelZaposlenika.Text == "" || MobitelZaposlenika.Text == "Broj Mobitela" 
                    || BrojRacunaZaposlenika.Text == "" || BrojRacunaZaposlenika.Text == "Broj Računa"  || ZaposlenikPoslovnica.Text == "" || ZaposlenikPoslovnica.Text == "Neodređeno")
            {
                DodavanjeNovogaZaposlenikaUpozorenje otvori = new DodavanjeNovogaZaposlenikaUpozorenje();
                otvori.Show();
            }
            else
            {
                var con = DB.GetSqlkonekcija();
                con.Open();

                string query = "INSERT INTO Zaposlenik(OIB_Zaposlenika, Ime_Zaposlenika, Prezime_Zaposlenika, Email_Zaposlenika, Lozinka_Zaposlenika, " +
                    "Datum_Rodenja_Zaposlenika,Adresa_Zaposlenika, Post_Broj_Zaposlenika, Br_Mobitela_Zaposlenika, Broj_Racuna_Zaposlenika, Poslovnica) VALUES " +
                    "('" + OibZaposlenika.Text + "', '" + ImeZaposlenika.Text + "', '" + PrezimeZaposlenika.Text + "', '" + EmailZaposlenika.Text + "' " +
                    ", '" + LozinkaZaposlenika.Text + "', '" + DatumRodenja.Value.ToString() + "', '" + AdresaZaposlenika.Text + "', '" + PostanskiBrojZaposlenika.Text + "'" +
                    ", '" + MobitelZaposlenika.Text + "', '" + BrojRacunaZaposlenika.Text + "','" + ZaposlenikPoslovnica.Text + "')";

                SqlCommand sqlcomm = new SqlCommand(query, con);
                sqlcomm.ExecuteNonQuery();
                ZaposlenikDodan otvori = new ZaposlenikDodan();
                otvori.Show();
                this.Hide();
                  con.Close();
            }
        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zaposlenici PopisZaposlenika = new Zaposlenici();
            PopisZaposlenika.Show();
        }

        private void popuniPoslovnicu()
        {
            try
            {
                var con = DB.GetSqlkonekcija();
                string val = "SELECT Grad FROM Poslovnica";
                con.Open();
                SqlDataReader dr = new SqlCommand(val, con).ExecuteReader();

                while (dr.Read())
                {
                    ZaposlenikPoslovnica.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
    }
}
