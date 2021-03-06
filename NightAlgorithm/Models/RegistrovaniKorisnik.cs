using System;
using System.Collections.Generic;
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
        public String  korisničkoIme { get; set; }
        [Required]
        public String lozinka { get; set; }
        [Required]
        public DateTime datumRođenja { get; }
        [Required]
        public String spol { get; set; }
        [NotMapped]
        public List<String> listaInteresovanja { get; }
        [NotMapped]
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
