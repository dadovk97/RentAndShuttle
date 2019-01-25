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
    public partial class Prijava : Form
    {
        int flag = 0;
        public Prijava()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void EmailPrijava_Click(object sender, EventArgs e)
        {
            EmailPrijava.Clear();
            MailSlika.Image = RentShuttle.Properties.Resources.Mail_Black;
            PanelEmail.BackColor = Color.Black;

            LokotSlika.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka.BackColor = Color.WhiteSmoke;

        }
        private void LozinkaPrijava_Click(object sender, EventArgs e)
        {
            LozinkaPrijava.Clear();
            LozinkaPrijava.PasswordChar = '*';
            LokotSlika.Image = RentShuttle.Properties.Resources.Lock_Black;
            PanelLozinka.BackColor = Color.Black;

            MailSlika.Image = RentShuttle.Properties.Resources.mail_white;
            PanelEmail.BackColor = Color.WhiteSmoke;

        }

        private void Prijava1_Click(object sender, EventArgs e)
        {

            if (EmailPrijava.Text == "" || LozinkaPrijava.Text == "") //korisnik mora popuniti sva polja za registraciju 
            {
                PrijavaUpozorenje otvori = new PrijavaUpozorenje();
                otvori.Show();
             
            }
            else
            {
                var con = DB.GetSqlkonekcija();
                con.Open();

                string zadatak = "select  * from Administrator  where email = '" + EmailPrijava.Text + "' and password = '" + LozinkaPrijava.Text + "';";
                SqlCommand nadji = new SqlCommand(zadatak, con);
                SqlDataReader pronadji = nadji.ExecuteReader();
                if (pronadji.Read())
                {
                    Zaposlenici otvori = new Zaposlenici();
                    otvori.Show();
                    this.Hide();
                    flag++;

                }
                pronadji.Close();
                string zadatak1 = " select  * from Zaposlenik where Email_Zaposlenika  = '" + EmailPrijava.Text + "'and Lozinka_Zaposlenika = '" + LozinkaPrijava.Text + "';";
                SqlCommand nadji1 = new SqlCommand(zadatak1, con);
                 pronadji = nadji1.ExecuteReader();
                if (pronadji.Read())
                {
                    NaslovnaReferent otvori = new NaslovnaReferent();
                    otvori.Show();
                    this.Hide();
                    flag++;
                }
                pronadji.Close();
                string zadatak2 = " select  * from Registracija where Email = '" + EmailPrijava.Text + "'and Lozinka = '" + LozinkaPrijava.Text + "';";
                SqlCommand nadji2 = new SqlCommand(zadatak2, con);
                pronadji = nadji2.ExecuteReader();

                if (pronadji.Read())
                {
                    PrijavljenKorisnik.emailPrijavljenog = (string) pronadji["Email"];
                    this.Hide();
                    NaslovnaKorisnik naslovna = new NaslovnaKorisnik();
                    naslovna.Show();


                    pronadji.Close();
                    flag++;
                }


                else if( flag== 0) {
                    PrijavaError otvori = new PrijavaError();
                    otvori.Show();
                }
                con.Close();
            }


        }

        private void Odustani1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void NoviRacun_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registracija registracija = new Registracija();
            registracija.Show();
        }

        private void EmailPrijava_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
