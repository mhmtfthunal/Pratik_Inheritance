using Pratik_Inheritance.Models;

Ogretmen yeniOgretmen = new Ogretmen()
{
    MaasBilgisi = 24500,
    Ad = "Selim",
    Soyad = "Senses"
};

yeniOgretmen.OgremtenBilgiYazdir();

Console.WriteLine("-----------------------------");

Ogrenci yeniOgrenci = new Ogrenci()
{
    OgrenciNumarasi = 39,
    Ad = "Remzi",
    Soyad = "Durmaz"
};

yeniOgrenci.OgrenciBilgiYazdir();