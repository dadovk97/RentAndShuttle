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
    public partial class RezervacijaUslugeUspjesno : Form
    {
        public RezervacijaUslugeUspjesno()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PregledRezervacija pregledRezervacija = new PregledRezervacija();
            pregledRezervacija.Show();
            this.Close();
        }

        private void BtnUredu_Click(object sender, EventArgs e)
        {
            PregledRezervacija pregledRezervacija = new PregledRezervacija();
            pregledRezervacija.Show();
            this.Close();
        }
    }
}
