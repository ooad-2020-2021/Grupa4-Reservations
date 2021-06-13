using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NightAlgorithm.Models
{
    public class RegistrovaniKorisnik
    {
        #region Properties
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        [RegularExpression(@"[A-Z|a-z| ]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova i razmaka!")]
        [DisplayName("Korisničko ime")]
        public String  korisničkoIme { get; set; }
        [Required]
        [RegularExpression(@"[A-Z|a-z|0-9| ]*", ErrorMessage = "Obavezno korištenje velikih i malih slova i brojeva!")]
        [DisplayName("Lozinka")]
        public String lozinka { get; set; }
        [Required]
        [DisplayName("Datum rođenja")]

        public DateTime datumRođenja { get; }
        [Required]
        [DisplayName("Spol")]
        [RegularExpression(@"[m|z|M|Z]*", ErrorMessage ="Za ženski spol unesite slovo z, za muški slovo m!")]
        public String spol { get; set; }
        [NotMapped]
        [Required]
        public List<String> listaInteresovanja { get; }
        [NotMapped]
        [Required]
        public List<RegistrovaniKorisnik> listaPrijatelja { get;}
        [NotMapped]
        public List<Događaj> rezervisaniDogađaji { get;}
        #endregion
        #region Konstruktor
        public RegistrovaniKorisnik() { }
        public RegistrovaniKorisnik(String korisničkoIme, String lozinka, DateTime datumRođenja, String spol)
        {
            id = GenerišiID();
            this.korisničkoIme = korisničkoIme;
            this.lozinka = lozinka;
            this.datumRođenja = datumRođenja;
            this.spol = spol;
        }

        public RegistrovaniKorisnik(String korisničkoIme, String lozinka, DateTime datumRođenja, String spol, List<String> listaInteresovanja, List<RegistrovaniKorisnik> listaPrijatelja, List<Događaj> rezervisaniDogađaji)
        {
            id = GenerišiID();
            this.korisničkoIme = korisničkoIme;
            this.lozinka = lozinka;
            this.datumRođenja = datumRođenja;
            this.spol = spol;
            this.listaInteresovanja = listaInteresovanja;
            this.listaPrijatelja = listaPrijatelja;
            this.rezervisaniDogađaji = rezervisaniDogađaji;
        }

        #endregion

        #region Metode
        public void obrisiInteresovanje(String hashtag)
        {
            listaInteresovanja.Remove(hashtag);
        }

        public void dodajInteresovanje(String hashtag)
        {
            listaInteresovanja.Add(hashtag);
        }
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
