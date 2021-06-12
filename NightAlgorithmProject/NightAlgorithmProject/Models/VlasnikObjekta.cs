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
        [RegularExpression(@"[A-Z|a-z| ]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova i razmaka!")]
        public String lozinka { get; set; }
        
        #endregion
        #region Konstruktor
        public VlasnikObjekta() { }
        public VlasnikObjekta(String korisničkoIme, String lozinka) {

            id = GenerišiID();
            this.korisničkoIme = korisničkoIme;
            this.lozinka = lozinka;
        }

        #endregion
        #region Metode
        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }
        #endregion
    }
}
