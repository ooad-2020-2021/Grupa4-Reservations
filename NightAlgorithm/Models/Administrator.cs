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
        public String ime { get; set; }
        #endregion
        #region Konstruktor
        public Administrator() { }
        public Administrator(String ime)
        {

            id = GenerišiID();
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
