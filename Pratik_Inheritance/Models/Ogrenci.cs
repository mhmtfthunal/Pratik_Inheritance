using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Inheritance.Models
{
    internal class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi { get; set; }
        public void OgrenciBilgiYazdir()
        {
            Console.WriteLine("Öğrenci Bilgileri:");
            AdSoyadYazdir();
            Console.WriteLine("Öğrenci Numarası: " + OgrenciNumarasi);
        }
    }
}
