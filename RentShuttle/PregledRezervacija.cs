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
    public partial class PregledRezervacija : Form
    {
        public PregledRezervacija()
        {
            InitializeComponent();
        }
        DataTable dba;
        int BrojRez;
        int BrojRezUsluga;

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

        private void kreiranjerez_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tip_rezervacije tip_Rezervacije = new Tip_rezervacije();
            tip_Rezervacije.Show();
        }

        private void otkazivanjerez_Click(object sender, EventArgs e)
        {

            var con = DB.GetSqlkonekcija();
            con.Open();
            if (NajamClick.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Rezervacija WHERE BR_Rez ='" + BrojRez + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                RezervacijaOtkazana otvori = new RezervacijaOtkazana();
                otvori.Show();
            }

            else if (UslugaClick.Checked)
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("DELETE FROM Prijevoz WHERE Br_Rez_Prijevoza ='" + BrojRezUsluga + "'", con);
                sda1.SelectCommand.ExecuteNonQuery();
                RezervacijaOtkazana otvori = new RezervacijaOtkazana();
                otvori.Show();
            }
            con.Close();
        }
        
        private void NajamClick_CheckedChanged(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT BR_Rez as BrojRezervacije ,Polaziste,VrijemeDolaskaCCA as Dolazak ,Odrediste, DatumOdredista ,Automobil FROM Rezervacija WHERE EmailKorisnika ='" + PrijavljenKorisnik.emailPrijavljenog + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            dba = new DataTable();
            sda.Fill(dba);
            BindingSource source = new BindingSource();
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            source.DataSource = dba;
            dataGridView1.DataSource = source;
            sda.Update(dba);
            con.Close();
        }

        private void UslugaClick_CheckedChanged(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Br_Rez_Prijevoza as BrojRezervacije,Polaziste,VrijemePolazak as DatumPolaska,Odrediste FROM Prijevoz WHERE EmailKorisnikaPrijevoza ='" + PrijavljenKorisnik.emailPrijavljenog + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            dba = new DataTable();
            sda.Fill(dba);
            BindingSource source = new BindingSource();
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            source.DataSource = dba;
            dataGridView1.DataSource = source;
            sda.Update(dba);
            con.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NajamClick.Checked)
                {
                    BrojRez = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
                
                else if (UslugaClick.Checked)
                {
                    BrojRezUsluga = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {
                PraznaRezervacija otvori = new PraznaRezervacija();
                otvori.Show();
            }
        }

        private void NaslovnaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            NaslovnaKorisnik otvori = new NaslovnaKorisnik();
            otvori.Show();
        }
    }
}



