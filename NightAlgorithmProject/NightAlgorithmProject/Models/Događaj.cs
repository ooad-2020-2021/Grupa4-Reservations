using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NightAlgorithm.Models
{
    public class Događaj
    {
        #region Properties
        [Required]
        [Key]
        public int idDogađaja { get; set; }
        [Required]
        public String nazivDogađaja { get; set; }
        [Required]
        [RegularExpression(@"[A-Z|a-z| ]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova i razmaka!")]
        public DateTime vrijemePočetka { get; set; }
        [Required]
        [RegularExpression(@"[0-9| ]*")]
        [Range(0.0,60.0)]
        public String tipDogađaja { get; set; }
        [Required]
        public String opisDogađaja { get; set; }
        [Required]
        public String posebneNapomene { get; set; }
        public Boolean dobnoOgraničenje { get; set; }
        [NotMapped]
      
        [RegularExpression(@"[0-9]*")]
        public List<String> specifikatori { get; }
        [NotMapped]
        [Required]
        public List<RegistrovaniKorisnik> prijavljeniKorisnici { get; }
        public List<int> recenzije { get; }
       
        #endregion
        #region Konstruktor
        public Događaj() { }
        public Događaj(String nazivDogađaja, DateTime vrijemepočetka)
        {

            this.idDogađaja = GenerišiID();
            this.nazivDogađaja = nazivDogađaja;
            this.vrijemePočetka = vrijemePočetka;
        }
        #endregion
        #region Metode

        public void dodajSpecifikator(String specifikator)
        {

            specifikatori.Add(specifikator);
        }

        public void obrišiSpecifikator(String specifikator)
        {

            specifikatori.Remove(specifikator);
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
