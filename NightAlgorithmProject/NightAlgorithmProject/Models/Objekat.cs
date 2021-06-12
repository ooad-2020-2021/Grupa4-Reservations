﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NightAlgorithm.Models
{
    public class Objekat
    {
        #region Properties
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public String naziv { get; set; }
        [Required]
        [RegularExpression(@"[A-Z|a-z| ]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova i razmaka!")]
        public int kapacitet { get; set; }
        [Required]
        [RegularExpression(@"[0-200]*")]
        public String lokacija { get; set; }
        [Required]
        public String brojTelefona { get; set; }
        [Required]
        [RegularExpression(@"[0-9| ]*")]
        public String mail { get; set; }
        #endregion
        #region Konstruktor
        public Objekat() { }
        public Objekat(String naziv,int kapacitet, String lokacija, String brojTelefona, String mail)
        {

            id = GenerišiID();
            this.naziv = naziv;
            this.kapacitet = kapacitet;
            this.lokacija = lokacija;
            this.brojTelefona = brojTelefona;
            this.mail = mail;
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