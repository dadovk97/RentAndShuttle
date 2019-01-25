using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentShuttle
{
    public partial class NaslovnaReferent : Form
    {
        public NaslovnaReferent()
        {
            InitializeComponent();
        }

        private void danasnjerezervacije_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanasnjeRezervacije rezervacije = new DanasnjeRezervacije();
            rezervacije.Show();
        }

        private void statistickipodaci_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatistickiPodaci statistika = new StatistickiPodaci();
            statistika.Show();
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
    }
}
