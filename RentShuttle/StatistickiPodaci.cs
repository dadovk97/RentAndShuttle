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
using System.Windows.Forms.DataVisualization.Charting;

namespace RentShuttle
{
    public partial class StatistickiPodaci : Form
    {
        public StatistickiPodaci()
        {
            InitializeComponent();
            popuni();
            BrojacOcjena();
            DrawPieChart(Ocjena1, Ocjena2, Ocjena3, Ocjena4, Ocjena5);
        }

        int Ocjena5 = 0;
        int Ocjena4 = 0;
        int Ocjena3 = 0;
        int Ocjena2 = 0;
        int Ocjena1 = 0;


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

        DataTable dba;
        private void popuni()
        {
            var con = DB.GetSqlkonekcija();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Ocjena FROM Recenzija", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            dba = new DataTable();
            sda.Fill(dba);
            BindingSource source = new BindingSource();
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ForeColor = Color.Black;
            source.DataSource = dba;
            dataGridView1.DataSource = source;
            sda.Update(dba);

            con.Close();

            int A = 0, B = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[0].Value);
            }
            zbrojOcjena.Text = B.ToString();
            double brojRedaka = dataGridView1.Rows.Count;
            double prosjecnaocjena = B / brojRedaka;
            prosjecnaOcjena.Text = prosjecnaocjena.ToString();
        }

        private void BrojacOcjena()
        {
            var con = DB.GetSqlkonekcija();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 5", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Ocjena5 = Ocjena5 + 1;

            }

            reader.Close();

            SqlCommand cmd1 = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 4", con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                Ocjena4 = Ocjena4 + 1;

            }
            reader1.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 3", con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                Ocjena3 = Ocjena3 + 1;

            }
            reader2.Close();

            SqlCommand cmd3 = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 2", con);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                Ocjena2 = Ocjena2 + 1;

            }
            reader3.Close();

            SqlCommand cmd4 = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 1", con);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                Ocjena1 = Ocjena1 + 1;

            }
            reader4.Close();

            con.Close();
        }

        private void DrawPieChart(int Ocjena1, int Ocjena2, int Ocjena3, int Ocjena4, int Ocjena5)
        {
            chart1.Series.Clear();
            chart1.Legends.Clear();
            
            chart1.Legends.Add("Legenda");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Ocjenjene usluge";
            chart1.Legends[0].BorderColor = Color.Black;
            
            string seriesname = "Ocjene";
            chart1.Series.Add(seriesname);

            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
            
            chart1.Series[seriesname].Points.AddXY("Ocjena 1", Ocjena1);
            chart1.Series[seriesname].Points.AddXY("Ocjena 2", Ocjena2);
            chart1.Series[seriesname].Points.AddXY("Ocjena 3", Ocjena3);
            chart1.Series[seriesname].Points.AddXY("Ocjena 4", Ocjena4);
            chart1.Series[seriesname].Points.AddXY("Ocjena 5", Ocjena5);
        }

    }
}
