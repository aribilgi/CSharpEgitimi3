using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEgitim.Models
{
    public class AnasayfaViewModel
    {
        public Kullanici Kullanici { get; set; }
        public Adres Adres { get; set; }
        public List<Adres> AdresList { get; set; }
    }
}