# Kitaplık Yönetim Sistemi (SQL Server)

Bu proje, C# Windows Forms ve SQL Server kullanılarak geliştirilmiş bir kitap kayıt ve yönetim sistemidir. Uygulama üzerinden kitap ekleme, silme, güncelleme ve listeleme (CRUD) işlemleri yapılabilmektedir.

## Özellikler
* **Kitap Kaydı:** Kitap adı, yazar, sayfa sayısı, fiyat ve yayınevi bilgilerini kaydeder.
* **Kategori Yönetimi:** Kitap türlerini SQL tablosundan (TblTurler) dinamik olarak çeker.
* **Veritabanı Entegrasyonu:** `SqlBaglantisi` sınıfı üzerinden merkezi bir bağlantı yönetimi sağlar.

## Veritabanı Kurulumu
Projenin çalışması için bilgisayarınızda SQL Server kurulu olmalıdır:

1. SQL Server Management Studio (SSMS) uygulamasını açın.
2. `ogrencinotkayit` adında yeni bir veritabanı oluşturun.
3. Proje klasöründe bulunan `script.sql` dosyasını açın ve bu veritabanında çalıştırın (Execute). 
   * *Not: Bu script, `TblKitaplar , TblStok`   ve `TblTurler` tablolarını otomatik oluşturacak ve örnek verileri yükleyecektir.*

## Bağlantı Ayarı
Projeyi kendi bilgisayarınızda çalıştırmak için:
1. `Class1.cs` dosyasını açın.
2. `SqlConnection` satırındaki `Data Source=MELISA;` kısmını kendi SQL Server sunucu adınızla değiştirin.

## Kullanılan Teknolojiler
* **Dil:** C# (.NET)
* **Veritabanı:** Microsoft SQL Server

* **Arayüz:** Windows Forms (WinForms)
