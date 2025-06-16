using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Inheritance.Models
{
    internal class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public void AdSoyadYazdir()
        {
            Console.WriteLine("\nAd: " + Ad + " " + "\nSoyad: " + Soyad);
        }
    }
}
