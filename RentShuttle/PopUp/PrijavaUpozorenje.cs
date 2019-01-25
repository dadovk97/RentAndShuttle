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
    public partial class PrijavaUpozorenje : Form
    {
        public PrijavaUpozorenje()
        {
            InitializeComponent();
        }

        private void BtnUredu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prijava otvori = new Prijava();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Prijava otvori = new Prijava();
            this.Hide();
        }
    }
}
