# 🏥 Sağlık Merkezi Yönetim Sistemi

Sağlık merkezi süreçlerinin dijital ortamda yönetilmesini amaçlayan web tabanlı yönetim sistemi.

Bu proje; sağlık merkezi içerisindeki hasta, doktor, randevu ve diğer operasyonel süreçlerin daha düzenli ve merkezi bir şekilde yönetilebilmesi amacıyla geliştirilmiştir.

## 🎯 Projenin Amacı

Sağlık merkezlerinde gerçekleştirilen temel işlemleri dijital ortama taşıyarak;

* Hasta bilgilerinin düzenli şekilde yönetilmesini,
* Doktor bilgilerinin takip edilmesini,
* Randevu süreçlerinin yönetilmesini,
* Verilerin merkezi bir veritabanında saklanmasını,
* Kullanıcıların işlemleri daha hızlı ve kolay gerçekleştirmesini

sağlayan bir yönetim sistemi oluşturmak amaçlanmıştır.

## 🚀 Temel Özellikler

* 👤 Hasta yönetimi
* 👨‍⚕️ Doktor yönetimi
* 📅 Randevu yönetimi
* 🏥 Sağlık merkezi süreçlerinin yönetimi
* 🗄️ Veritabanı işlemleri
* ✏️ Veri ekleme, güncelleme ve silme işlemleri
* 🔎 Veri görüntüleme ve arama
* 🖥️ Kullanıcı dostu arayüz

> Projede bulunan özellikler geliştirme sürecine bağlı olarak genişletilebilir.

## 🛠️ Kullanılan Teknolojiler

* **C#**
* **.NET**
* **SQL**
* **Git**
* **GitHub**

> Kullanılan framework ve veritabanı teknolojileri projenin güncel sürümüne göre güncellenecektir.

## 🏗️ Proje Yapısı

```text
SaglikMerkezi/
│
├── SaglikMerkezi/
│   ├── Controllers/
│   ├── Models/
│   ├── Views/
│   ├── Data/
│   ├── wwwroot/
│   └── ...
│
├── SaglikMerkezi.sln
└── README.md
```

## 🗄️ Veritabanı

Uygulama, sağlık merkezi içerisindeki bilgilerin merkezi olarak yönetilebilmesi amacıyla ilişkisel veritabanı yapısından yararlanmaktadır.

Veritabanında hasta, doktor ve randevu gibi temel sistem bileşenleri arasında ilişkiler oluşturularak veri bütünlüğünün sağlanması hedeflenmiştir.

## 📸 Ekran Görüntüleri

Projenin önemli ekran görüntüleri aşağıdaki bölümde paylaşılacaktır.

### Giriş Ekranı

![Giriş Ekranı](screenshots/login.png)

### Ana Sayfa / Dashboard

![Dashboard](screenshots/dashboard.png)

### Hasta Yönetimi

![Hasta Yönetimi](screenshots/patients.png)

### Randevu Yönetimi

![Randevu Yönetimi](screenshots/appointments.png)

## ⚙️ Kurulum

Projeyi bilgisayarınıza klonlayın:

```bash
git clone https://github.com/MustafaTasbasi/SaglikMerkezi.git
```

Proje klasörüne girin:

```bash
cd SaglikMerkezi
```

Ardından `SaglikMerkezi.sln` dosyasını Visual Studio ile açarak projeyi çalıştırabilirsiniz.

> Veritabanı bağlantısı kullanılıyorsa, çalıştırmadan önce ilgili bağlantı ayarlarının kendi geliştirme ortamınıza göre yapılandırılması gerekmektedir.

## 💡 Öğrenilen ve Uygulanan Konular

Bu proje geliştirilirken aşağıdaki konularda pratik yapılmıştır:

* C# ile uygulama geliştirme
* .NET ekosistemi
* Veritabanı yönetimi
* CRUD işlemleri
* Nesne yönelimli programlama
* Web uygulaması geliştirme
* Kullanıcı arayüzü tasarımı
* Git ve GitHub ile versiyon kontrolü

## 🔮 Gelecekte Eklenebilecek Özellikler

* 🔐 Rol tabanlı kullanıcı yetkilendirme
* 📊 Gelişmiş yönetim paneli
* 📈 İstatistik ve raporlama ekranları
* 🔔 Randevu bildirimleri
* 📱 Mobil uyumlu arayüz
* 📄 PDF/Excel raporlama
* 🔎 Gelişmiş filtreleme ve arama
* 📝 Hasta geçmişi ve kayıt takibi

## 👨‍💻 Geliştirici

**Mustafa Taşbaşı**

Yönetim Bilişim Sistemleri öğrencisi.

GitHub: [MustafaTasbasi](https://github.com/MustafaTasbasi)

## 📄 Lisans

Bu proje eğitim ve portföy amaçlı geliştirilmiştir.
