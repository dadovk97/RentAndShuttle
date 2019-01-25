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
    public partial class RegistracijaError : Form
    {
        public RegistracijaError()
        {
            InitializeComponent();
        }

        private void BtnUredu_Click(object sender, EventArgs e)
        {
            Registracija otvori = new Registracija();
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Registracija otvori = new Registracija();
            this.Hide();
        }
    }
}
