using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NightAlgorithm.Models
{
    public class Administrator
    {

        #region Properties
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public String ime;
        
        public Administrator() { }
        public Administrator(String ime)
        {

            this.ime = ime;
        }
        #endregion

        #region Metode
        public void dodajVlasnika(String korisničkoIme, int lozinka)
        {

            //dodaj novog vlasnika u bazu podataka
        }
        public void obrišiVlasnika(String korisničkoIme)
        {

            //izbrisi postojećeg vlasnika 
        }

        #endregion
    }
}
