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
        [RegularExpression(@"[A-Z|a-z| ]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova i razmaka!")]
        public String tekst { get; set; }
        [Required]
        public RegistrovaniKorisnik primalacNotifikacije;
        #endregion
        #region Konstruktor
        public Notifikacija() { }
        public Notifikacija(String naziv, String tekst, RegistrovaniKorisnik primalacNotifikacije)
        {

            this.id = GenerišiID();
            this.naziv = naziv;
            this.tekst = tekst;
            this.primalacNotifikacije = primalacNotifikacije;
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
