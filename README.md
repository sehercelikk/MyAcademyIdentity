# 📧 EmailApp

**EmailApp**, kullanıcıların e-posta gönderip alabileceği basit bir **ASP.NET Core MVC** uygulamasıdır.  
Uygulamada **Identity kütüphanesi** ile kimlik doğrulama (authentication) ve yetkilendirme (authorization) işlemleri gerçekleştirilmiştir.  
Kullanıcılar sisteme giriş yapabilir, e-posta gönderebilir, gelen kutularını görüntüleyebilirler, mesajlarını taslak olarak ekleyebilir ve çöp kutusuna taşıyabilir.

---

## 🚀 Özellikler

- 🔐 **ASP.NET Core Identity Entegrasyonu**
  - Kullanıcı kaydı, giriş (login) ve yetkilendirme yapılır.

- ✉️ **E-posta Gönderme ve Alma**
  - Kullanıcılar sistem üzerinden e-posta gönderebilir.
  - Gelen e-postalar kullanıcının **Inbox (Gelen Kutusu)** bölümünde listelenir.
  - Gönderilen e-postalar **Sent (Gönderilenler)** klasöründe tutulur.

- 🧩 **Folder Structure**
  - Proje basit ama ölçeklenebilir olacak şekilde katmanlara ayrılmıştır:
    ```
    EmailApp/
    ├── Controllers/
    ├── Models/
    ├── Services/
    ├── Views/
    ├── Context/
    ├── Entities/
    ├── Validations/
    ├── ViewComponents/
    ├── wwwroot/
    ├── Program.cs
    └── appsettings.json
    ```
---

## 🧱 Kullanılan Teknolojiler

| Katman / Araç | Teknoloji |
|----------------|------------|
| Framework | ASP.NET Core MVC |
| Kimlik Doğrulama | ASP.NET Core Identity |
| Veritabanı | SQL Server |
| UI | Razor View |
| DI Yönetimi | Scoped Services |

---

## 🔑 Kullanıcı Yönetimi

Proje, **Microsoft Identity** kütüphanesini kullanır.  
Aşağıdaki işlemler Identity sistemi ile yönetilir:

- Kullanıcı Kaydı  
- Login / Logout  
- Parola Hashleme  
- Kimlik Doğrulama (Authentication)
- Yetki Kontrolü (Authorization)
