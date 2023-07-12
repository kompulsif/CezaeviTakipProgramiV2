# Cezaevi Takip Programı C# V2

## Resimler

<p align="center">
  <img src="https://github.com/kompulsif/CezaeviTakipProgramiV2/blob/main/ReadmeImages/firmaSecim.png">
</p>
<p align="center">
  <img src="https://github.com/kompulsif/CezaeviTakipProgramiV2/blob/main/ReadmeImages/kullaniciGirisi.png">
</p>
<p align="center">
<img src="https://github.com/kompulsif/CezaeviTakipProgramiV2/blob/main/ReadmeImages/kullaniciEkle.png">
</p>
<p align="center">
<img src="https://github.com/kompulsif/CezaeviTakipProgramiV2/blob/main/ReadmeImages/anaBolum.png">
</p>
## Tüm Kurulum İşlemleri

### Ön Gereksinimler
* MSSQL Server
* Arduino IDE
* Visual Studio
* Arduino Uno
* RFID-RC522
* Arduino Güç Kablosu
* Ve CH340 Driver kurulu olmalıdır

### Kurulum
* Öncelikle arduino uno kartınızın ve rfid kartınızın bağlantı noktalarını birbirine bağlayın. Resim aşağıdadır;
<p align="center">
<img src="https://github.com/kompulsif/CezaeviTakipProgramiV2/blob/main/ReadmeImages/arduino_pin_yerleri.jpg">
</p>
* Sonra Arduino IDE yardımı ile .ino dosyasındaki kodları arduino'ya aktarın.
* Arduino kartınızı kendi güç kablosu ile bilgisayarınıza bağlayın.
* MSSQL Server ile verilen .sql dosyasındaki kodları çalıştırın ve veritabanınızı oluşturun.
* Sonra da direkt programı verdiğim kullanıcı adı ve parola bilgileri ile açın.
* Program firma seçiminizden sonra COM Port bilgilerini alacaktır, arduino'nun çalıştığı com port bilgisini seçin ve giriş yapabilirsiniz.

## Özellikleri
* RFID özelliği sayesinde rfid kart vb. kartlar ile giriş sağlanabilir
* Kişide RFID okuyucu bulunmuyorsa bile program çökmeden sadece kullanıcı bilgileri ile giriş sağlanabilir
* İstenilen kadar mahkum eklenebilir
* Ziyaretçi kayıtları, İzin kayıtları, personel işlemleri, yoklama işlemleri gibi işlemler mevcut
* Eklenen kullanıcılara neredeyse bütün işlemlerde yetki verme/alma işlemleri yapılabiliyor, hesaplar silinmeden aktifliği kaldırılabiliyor
* Mahkumlar için veritabanına resim eklenebiliyor
* Koğuş Tipi, Görev Yeri vb. numaralandırılmış veri girişlerinde, yazıya tıklanılması halinde bir seçim menüsü açılacaktır, tek tek bakılmasına gerek yoktur
* Yarı Modern Tasarım

## Ek Açıklamalar
* Firma ekleme işlemi admin olarak değilde database admin tarafından yapılacağını düşünerek arayüz olarak eklenmemiştir.
* Zaten varsayılan olarak sql dosyasında bir firma ve kullanıcı ile birlikte gelecektir.
* Kart ekleme işlemi ilk olarak giriş yapıldıktan sonra Ayarlar/Kullanıcı İşlemleri menüsünden eklenebilir.
* Eğer yeni bir mahkum eklendiyse, güncelleme yapıldıysa veya sorgulama yapılacaksa, filtre temizle seçeneğinden sonra mahkum sorgulayın. Program varsayılan olarak ana sayfadaki en son zaman dilimi bilgisini alır. O yüzden aradan bir kaç işlem yaparken zaman geçtiyse, zamanı sıfırlamalısınız. Sadece Filtre Temizle butonu işinizi görecektir.
* Kullanıcı adı: `admin` | Parola: `default_`


#### Herkese İyi Eğlenceler!
