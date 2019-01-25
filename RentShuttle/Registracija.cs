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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

      
        private void registracija1_Click(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();
        

            if(ImeRegistracija.Text == "" || ImeRegistracija.Text == "Ime" || PrezimeRegistracija.Text == "" || 
                PrezimeRegistracija.Text == "Prezime"|| EmailRegistracija.Text == "" || EmailRegistracija.Text == "Email" || LozinkaRegistracija.Text == "" || 
                PotvrdaLozinke.Text == "" )
            { 
                RegistracijaUpozorenje otvori = new RegistracijaUpozorenje();
                otvori.Show();
            }
            
            else if(LozinkaRegistracija.Text != PotvrdaLozinke.Text)
            {
                RegistracijaError otvori = new RegistracijaError();
                otvori.Show();
            }
            
            else
            {
               string query =  "INSERT INTO Registracija(Ime, Prezime, Email, Lozinka) VALUES " +
                   "('" +ImeRegistracija.Text + "', '" + PrezimeRegistracija.Text + "', '" + EmailRegistracija.Text + "', '" +
                   LozinkaRegistracija.Text + "')";
                SqlCommand sqlcomm = new SqlCommand(query, con);
               sqlcomm.ExecuteNonQuery();
                
                this.Hide();
                Pocetna pocetna = new Pocetna();
                pocetna.Show();
                RegistracijaUspjesna otvori = new RegistracijaUspjesna();
                otvori.Show();


            }
            con.Close();
        }

        private void ImeRegistracija_Click(object sender, EventArgs e)
        {
            ImeRegistracija.Clear();
            PanelIme.BackColor = Color.Black;
            ImeRegistracija.ForeColor = Color.Black;

            PanelPrezime.BackColor = Color.WhiteSmoke;
            PrezimeRegistracija.ForeColor = Color.WhiteSmoke;

            MailSlika.Image = RentShuttle.Properties.Resources.mail_white;
            PanelEmail1.BackColor = Color.WhiteSmoke;
            EmailRegistracija.ForeColor = Color.WhiteSmoke;

            LokotSlika.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka1.BackColor = Color.WhiteSmoke;
            LozinkaRegistracija.ForeColor = Color.WhiteSmoke;

            LokotSlika1.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka2.BackColor = Color.WhiteSmoke;
            PotvrdaLozinke.ForeColor = Color.WhiteSmoke;
        }

        private void PrezimeRegistracija_Click(object sender, EventArgs e)
        { 
            PanelIme.BackColor = Color.WhiteSmoke;
            ImeRegistracija.ForeColor = Color.WhiteSmoke;

            PrezimeRegistracija.Clear();
            PanelPrezime.BackColor = Color.Black;
            PrezimeRegistracija.ForeColor = Color.Black;

            MailSlika.Image = RentShuttle.Properties.Resources.mail_white;
            PanelEmail1.BackColor = Color.WhiteSmoke;
            EmailRegistracija.ForeColor = Color.WhiteSmoke;

            LokotSlika.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka1.BackColor = Color.WhiteSmoke;
            LozinkaRegistracija.ForeColor = Color.WhiteSmoke;

            LokotSlika1.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka2.BackColor = Color.WhiteSmoke;
            PotvrdaLozinke.ForeColor = Color.WhiteSmoke;
        }

        private void EmailRegistracija_Click(object sender, EventArgs e)
        {
            PanelIme.BackColor = Color.WhiteSmoke;
            ImeRegistracija.ForeColor = Color.WhiteSmoke;

            PanelPrezime.BackColor = Color.WhiteSmoke;
            PrezimeRegistracija.ForeColor = Color.WhiteSmoke;

            EmailRegistracija.Clear();
            MailSlika.Image = RentShuttle.Properties.Resources.Mail_Black;
            PanelEmail1.BackColor = Color.Black;
            EmailRegistracija.ForeColor = Color.Black;

            LokotSlika.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka1.BackColor = Color.WhiteSmoke;
            LozinkaRegistracija.ForeColor = Color.WhiteSmoke;

            LokotSlika1.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka2.BackColor = Color.WhiteSmoke;
            PotvrdaLozinke.ForeColor = Color.WhiteSmoke;
        }

        private void LozinkaRegistracija_Click(object sender, EventArgs e)
        {
            PanelIme.BackColor = Color.WhiteSmoke;
            ImeRegistracija.ForeColor = Color.WhiteSmoke;

            PanelPrezime.BackColor = Color.WhiteSmoke;
            PrezimeRegistracija.ForeColor = Color.WhiteSmoke;

            MailSlika.Image = RentShuttle.Properties.Resources.mail_white;
            PanelEmail1.BackColor = Color.WhiteSmoke;
            EmailRegistracija.ForeColor = Color.WhiteSmoke;

            LozinkaRegistracija.Clear();
            LozinkaRegistracija.PasswordChar = '*';
            LokotSlika.Image = RentShuttle.Properties.Resources.Lock_Black;
            PanelLozinka1.BackColor = Color.Black;
            LozinkaRegistracija.ForeColor = Color.Black;

            LokotSlika1.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka2.BackColor = Color.WhiteSmoke;
            PotvrdaLozinke.ForeColor = Color.WhiteSmoke;
        }

        private void PotvrdaLozinke_Click(object sender, EventArgs e)
        {
            PanelIme.BackColor = Color.WhiteSmoke;
            ImeRegistracija.ForeColor = Color.WhiteSmoke;

            PanelPrezime.BackColor = Color.WhiteSmoke;
            PrezimeRegistracija.ForeColor = Color.WhiteSmoke;

            LokotSlika.Image = RentShuttle.Properties.Resources.lock_white;
            PanelEmail1.BackColor = Color.WhiteSmoke;
            EmailRegistracija.ForeColor = Color.WhiteSmoke;

            LokotSlika.Image = RentShuttle.Properties.Resources.lock_white;
            PanelLozinka1.BackColor = Color.WhiteSmoke;
            LozinkaRegistracija.ForeColor = Color.WhiteSmoke;

            PotvrdaLozinke.PasswordChar = '*';
            PotvrdaLozinke.Clear();
            LokotSlika1.Image = RentShuttle.Properties.Resources.Lock_Black;
            PanelLozinka2.BackColor = Color.Black;
            PotvrdaLozinke.ForeColor = Color.Black;
        }

        private void Odustani1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }
    }
}
