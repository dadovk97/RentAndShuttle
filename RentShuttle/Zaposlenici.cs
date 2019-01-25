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
    public partial class Zaposlenici : Form
    {
        public Zaposlenici()
        {
            InitializeComponent();
        }

        private void NoviZaposlenikbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodavanjeNovogZaposlenika DodajNovogZaposlenika = new DodavanjeNovogZaposlenika();
            DodajNovogZaposlenika.Show();
        }

        private void Odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }
        DataTable dba;
        private void Prikazibtn_Click(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Ime_Zaposlenika as Ime, Prezime_Zaposlenika as Prezime, Email_Zaposlenika as Email, Lozinka_Zaposlenika as Lozinka, Datum_Rodenja_Zaposlenika as Datum_rodenja, Br_Mobitela_Zaposlenika as Broj_mobitela, Broj_Racuna_Zaposlenika as Broj_racuna, Poslovnica  FROM Zaposlenik;", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            dba = new DataTable();
            sda.Fill(dba);
            BindingSource source = new BindingSource();
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            source.DataSource = dba;
            dataGridView1.DataSource = source;
            sda.Update(dba);
            con.Close();
        }
    }
}
