using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kap2Standard.Models
{
    public class Mitarbeiter
    {
        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtstag { get; set; }
        public decimal Gehalt { get; set; }

    }
}