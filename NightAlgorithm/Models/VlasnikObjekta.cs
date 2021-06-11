using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NightAlgorithm.Models
{
    public class VlasnikObjekta
    {

        #region Properties
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public String korisničkoIme { get; set; }
        [Required]
        public String lozinka { get; set; }

        public VlasnikObjekta() { }
        public VlasnikObjekta(String korisničkoIme, String lozinka) {

            this.korisničkoIme = korisničkoIme;
            this.lozinka = lozinka;
        }

        #endregion
    }
}
