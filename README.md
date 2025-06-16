# Pratik - Inheritance (Kalıtım) Uygulaması

Bu çalışma, nesne tabanlı programlamada (OOP) kalıtım (inheritance) kavramını pekiştirmek amacıyla oluşturulmuştur. "BaseKisi" adında bir temel sınıf (base class) tanımlanarak, "Ogretmen" ve "Ogrenci" adlarında iki alt sınıf (derived class) bu sınıftan türetilmiştir.

## ✨ Amaçlar

* Kalıtım yapısını anlamak
* Kod tekrarını azaltarak temel yapıdan türeyen yapılar oluşturmak
* Ortak özellikleri base class üzerinden yönetebilmek

## 📓 Yapılar

### BaseKisi (Temel Sınıf)

* Ortak özellikler: `Ad`, `Soyad`
* Ortak metot: `AdSoyadYazdir()`

### Ogretmen (BaseKisi'den türetilen sınıf)

* Ekstra özellik: `MaasBilgisi`
* Özel metot: `OgremtenBilgiYazdir()` → AdSoyadYazdir + maaş bilgisi

### Ogrenci (BaseKisi'den türetilen sınıf)

* Ekstra özellik: `OgrenciNumarasi`
* Özel metot: `OgrenciBilgiYazdir()` → AdSoyadYazdir + öğrenci numarası

## 🎓 Kazanımlar

* "is-a" (bir türdür) ilişkisi kurularak nesne tasarımının doğru yönetilmesi
* Ortak yapıların base class'a taşınmasıyla temiz kod geliştirme
* Kalıtım üzerinden metod ve property kullanımı

## ⚠️ Notlar

* `Ogretmen` ve `Ogrenci` sınıfları `BaseKisi`'den türediği için `Ad` ve `Soyad` özelliklerini direkt kullanabilir.
* Kalıtım yapısı, tekrar eden kodların tek bir temel sınıfta toplanmasını sağlar.

Bu çalışmayla birlikte C# dilinde temel OOP yaklaşımıyla daha yapılı ve geliştirilebilir uygulamalar oluşturabilirsiniz.
