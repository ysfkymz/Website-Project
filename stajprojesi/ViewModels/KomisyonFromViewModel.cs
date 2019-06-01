using stajprojesi.Models.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stajprojesi.ViewModels
{
    public class KomisyonFromViewModel
    {
        public IEnumerable<komisyon> Komisyon { get; set; }
        public komisyon njs { get; set; }
        public mulakat mul { get; set; }
    }
}