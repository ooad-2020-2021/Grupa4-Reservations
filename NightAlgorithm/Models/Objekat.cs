using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NightAlgorithm.Models
{
    public class Objekat
    {
        #region Properties
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public String naziv { get; set; }
        [Required]
        public int kapacitet { get; set; }
        [Required]
        public String lokacija { get; set; }
        [Required]
        public String brojTelefona { get; set; }
        [Required]
        public String mail { get; set; }

        public Objekat() { }
        public Objekat(String naziv, int kapacitet, String lokacija, String brojTelefona, String mail)
        {

            this.naziv = naziv;
            this.kapacitet = kapacitet;
            this.lokacija = lokacija;
            this.brojTelefona = brojTelefona;
            this.mail = mail;
        }

        #endregion
    }
}
