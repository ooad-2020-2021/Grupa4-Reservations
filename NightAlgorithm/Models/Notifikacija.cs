using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NightAlgorithm.Models
{
    public class Notifikacija
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public String naziv { get; set; }
        [Required]
        public String tekst { get; set; }
        [Required]
        public RegistrovaniKorisnik primalacNotifikacije;

        public Notifikacija(int id, String naziv, String tekst, RegistrovaniKorisnik primalacNotifikacije)
        {

            this.id = id;
            this.naziv = naziv;
            this.tekst = tekst;
            this.primalacNotifikacije = primalacNotifikacije;
        }

        #endregion
    }
}
