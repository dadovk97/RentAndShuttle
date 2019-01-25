using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentShuttle
{
    class Rezervacija
    {
        public int id_rezervacije { get; set; }
        public DateTime datum_rezervacije { get; set; }
        public int email_korisnika { get; set; }
        public int br_osoba { get; set; }
        public string polaziste { get; set; } // po gradu, a po poštanskom broju unutar poslovnice znamo koji to grad i posovnica
        public DateTime datum_polaska { get; set; }
        public string odrediste { get; set; }
        public DateTime datum_odredista { get; set; }
        public int broj_kreditne_kartice { get; set; }
        public DateTime cvv_kod { get; set; }

    }
}
