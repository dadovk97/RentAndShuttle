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
    public partial class RezervacijaNajam : Form
    {
        
        public RezervacijaNajam()
        {
            InitializeComponent();
            popuniPolaziste();
            popuniOdrediste();
            popuniAutomobil();
            popuniBoju();
        }
        string Sjedalica;
        string DodatanVozac;
        string GPS;
        string Prelazak;

        private void nastavakA_Click(object sender, EventArgs e)
        {
            if(imeA.Text == "" || prezimeA.Text == "" || oibA.Text == "" || brvozackeA.Text == "" || emailA.Text == ""
                || adresaA.Text == "" || drzavaA.Text == "" || postbrojA.Text == "" || 
                telefonA.Text == "" || osobeA.Text == "")
            {
                RezervacijaNajamUpozorenje otvori = new RezervacijaNajamUpozorenje();
                otvori.Show();
            }
            else
            {
                ObrazacB.Visible = true;
            }
        }

        private void nastavakB_Click(object sender, EventArgs e)
        {
            if(polazisteB.Text == "" || polazisteB.Text == "-Neodređeno-"|| vrijemedolaskaB.Text == "" ||
               odredisteB.Text == "-Neodređeno-" || odredisteB.Text == "" || automobilB.Text == "" || automobilB.Text == "-Neodređeno-"
               || bojaB.Text == "-Neodređeno-"|| bojaB.Text == "" || osiguranjeB.Text == "")
            {
                RezervacijaNajamUpozorenje otvori = new RezervacijaNajamUpozorenje();
                otvori.Show();
            }
            else
            {
                ObrazacC.Visible = true;
            }
        }

        private void povratakB_Click(object sender, EventArgs e)
        {
            ObrazacB.Visible = false;
            ObrazacA.Visible = true;
        }

        private void RezervirajNajam_Click(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();
    

            if (karticaC.Text == "-Odaberite Karticu-" || brojkarticeC.Text == "" || mjesecC.Text == "" || mjesecC.Text == "mm" || 
                godinaC.Text == "" || godinaC.Text == "yy" || načinplacanjaC.Text == "" || načinplacanjaC.Text == "-Neodređeno-"
                || imeC.Text == "" || prezimeC.Text == "" || oibC.Text == "" || vozackaC.Text == "" || adresaC.Text == "" 
                || drzavaC.Text == "" || postbrojC.Text == "" || telefonC.Text == "")
            {
                RezervacijaNajamUpozorenje otvori = new RezervacijaNajamUpozorenje();
                otvori.Show();
            }
            else
            {
                string query = "INSERT INTO Rezervacija(ImeKorisnika,PrezimeKorisnika,OIBKorisnika,BrojVozacke, " + 
                    " EmailKorisnika, AdresaKorisnika, DrzavaKorisnika,PostanskiBroj,BrojTelefona,BrojOsoba, " +
                    "Polaziste,DatumPolaska,VrijemeDolaskaCCA,Odrediste,DatumOdredista,Automobil,Boja,VrstaOsiguranja, " +
                    "Kartica,BrojKartice,MjesecIstekaKartice,GodinaIstekaKartice,NacinPlacanja," +
                    "ImeVlasnikaKartice,PrezimeVlasnikaKartice,OIBVlasnikaKartice,BrojVozackeDozvole," +
                    "AdresaVlasnikaKartice,DrzavaVlasnikaKartice,PBVlasnikaKartice, BrojTelefonaVlasnikaKartice,SjedalicaZaDijete," +
                    "DodatanVozac, GPS, PrelazakPrekoGranice) VALUES" +
                    "('" + imeA.Text + "', '" + prezimeA.Text + "','" + oibA.Text + "', '" + brvozackeA.Text + "' " +
                    ", '" + emailA.Text + "','" + adresaA.Text + "', '" + drzavaA.Text + "','" +
                    postbrojA.Text + "' ,'" + telefonA.Text + "','" + osobeA.Text + "','" + polazisteB.Text.ToString()+ "','"
                     +datumpolaskaB.Value.ToString()+ "','" + vrijemedolaskaB.Text+ "','"+odredisteB.Text.ToString()+"','"
                     +datumodredistaB.Value.ToString()+ "','"+ automobilB.Text.ToString()+ "','"+ bojaB.Text.ToString()
                     +"','"+osiguranjeB.Text+"','"+karticaC.Text.ToString()+"','"+brojkarticeC.Text+"','"+mjesecC.Text.ToString()
                     +"','"+godinaC.Text.ToString()+"','"+načinplacanjaC.Text.ToString()+"','"+imeC.Text+"','"+prezimeC.Text+"','"
                     +oibC.Text+"','"+vozackaC.Text+"','"+adresaC.Text+"','"+drzavaC.Text+"','"+postbrojC.Text+"','"+telefonC.Text+"','"+Sjedalica+"','"+DodatanVozac+"','"+GPS+"','"+Prelazak+"')";
                SqlCommand sqlcomm = new SqlCommand(query, con);
                sqlcomm.ExecuteNonQuery();
                RezervacijaNajamUspjesno otvori = new RezervacijaNajamUspjesno();
                otvori.Show();
                this.Hide();
            }
            con.Close();
        }

        private void povratakC_Click(object sender, EventArgs e)
        {
            ObrazacC.Visible = false;
            ObrazacB.Visible = true;
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
                    polazisteB.Items.Add(dr.GetValue(0).ToString());
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
                    odredisteB.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void popuniAutomobil()
        {
            try
            {
                var con = DB.GetSqlkonekcija();
                string val = "SELECT Marka_Automobila FROM Automobil";
                con.Open();
                SqlDataReader dr = new SqlCommand(val, con).ExecuteReader();

                while (dr.Read())
                {
                    automobilB.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void popuniBoju()
        {
            try
            {
                var con = DB.GetSqlkonekcija();
                string val = "SELECT Boja_Automobila FROM Automobil";
                con.Open();
                SqlDataReader dr = new SqlCommand(val, con).ExecuteReader();

                while (dr.Read())
                {
                    bojaB.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void usluga1_CheckedChanged(object sender, EventArgs e)
        {
            Sjedalica = "Sjedalica za dijete";
        }

        private void usluga3_CheckedChanged(object sender, EventArgs e)
        {
            DodatanVozac = "Dodatan vozač";
        }

        private void usluga2_CheckedChanged(object sender, EventArgs e)
        {
            GPS = "GPS";
        }

        private void usluga4_CheckedChanged(object sender, EventArgs e)
        {
            Prelazak = "Prelazak preko granice";
        }

        private void rezervacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledRezervacija otvori = new PregledRezervacija();
            otvori.Show();
        }

        private void odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna otvori = new Pocetna();
            otvori.Show();
        }
    }
}
