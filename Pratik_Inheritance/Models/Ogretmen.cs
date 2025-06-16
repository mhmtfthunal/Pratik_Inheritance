using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Inheritance.Models
{
    internal class Ogretmen : BaseKisi
    {
        public int MaasBilgisi { get; set; }
        public void OgremtenBilgiYazdir()
        {
            Console.WriteLine("Öğretmen Bilgileri:");
            AdSoyadYazdir();
            Console.WriteLine("Maaş: " + MaasBilgisi +" "+"TL");
        }
    }
}
