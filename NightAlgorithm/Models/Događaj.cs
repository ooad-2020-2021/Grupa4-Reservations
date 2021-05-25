using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime vrijemePočetka { get; set; }
        public String tipDogađaja { get; set; }
        public String opisDogađaja { get; set; }
        public String posebneNapomene { get; set; }
        public Boolean dobnoOgraničenje { get; set; }
        public List<String> specifikatori { get; }
        public List<RegistrovaniKorisnik> prijavljeniKorisnici { get; }
        public List<int> recenzije { get; }

        public Događaj(int idDogađaja, String nazivDogađaja, DateTime vrijemepočetka)
        {

            this.idDogađaja = idDogađaja;
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

        #endregion
    }
}
