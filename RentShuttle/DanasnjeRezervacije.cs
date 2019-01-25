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
using System.Data.OleDb;

namespace RentShuttle
{
    public partial class DanasnjeRezervacije : Form
    {
        public DanasnjeRezervacije()
        {
            InitializeComponent();
        }
        DataTable dba;

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            NaslovnaReferent naslovna = new NaslovnaReferent();
            naslovna.Show();
        }

        private void rezervacije_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanasnjeRezervacije rezervacije = new DanasnjeRezervacije();
            rezervacije.Show();
        }

        private void statistika_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatistickiPodaci statistika = new StatistickiPodaci();
            statistika.Show();
        }

        private void odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void NajamClick_CheckedChanged(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT BR_Rez as BrojRezervacije,PrezimeKorisnika as Prezime,ImeKorisnika as Ime,Polaziste,DatumPolaska,Odrediste,DatumOdredista,Automobil FROM Rezervacija where DatumPolaska = '" + dateTimePicker1.Value.ToString() + "' ;", con);
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

            SqlCommand cmd = new SqlCommand("SELECT Br_Rez_Prijevoza as BrojRezervacije, PrezimeKorisnikaPrijevoza as Prezime,ImeKorisnikaPrijevoza as Ime,Polaziste,VrijemePolazak as DatumOdredista,Odrediste FROM Prijevoz where VrijemePolazak = '" + dateTimePicker1.Value.ToString() + "' ;", con);
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
    }
}
