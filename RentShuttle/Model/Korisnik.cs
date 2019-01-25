using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentShuttle
{
    class Korisnik
    {
        public string id { get; set; }  // po tome cemo znati je li osoba zaposlenik il korisnik, to im mi dodjelujemo, k1, r1
        public string oib { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string lozinka { get; set; }
        public DateTime datum_rodenja { get; set; }
        public string adresa { get; set; }
        public int post_broj { get; set; }
        public int br_mobitela { get; set; }
        public int br_vozacke_dozvole { get; set; }
    }
}
