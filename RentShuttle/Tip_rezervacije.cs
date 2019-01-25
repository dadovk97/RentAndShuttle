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
    public partial class Tip_rezervacije : Form
    {
        public Tip_rezervacije()
        {
            InitializeComponent();
        }

        private void rezervacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tip_rezervacije tip_Rezervacije = new Tip_rezervacije();
            tip_Rezervacije.Show();
        }

        private void odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void najam_automobila_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervacijaNajam rezervacija = new RezervacijaNajam();
            rezervacija.Show();
        }

        private void usluga_prijevoza_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervacijaUslugePrijevoza UslugaPrijevoza = new RezervacijaUslugePrijevoza();
            UslugaPrijevoza.Show();
        }
    }
}
