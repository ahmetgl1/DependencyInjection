

# Dependency Injection Örnek Ürün Ekleme

Bu proje, dependency injection (bağımlılık enjeksiyonu) prensibini anlamak ve uygulamak amacıyla oluşturulmuştur.

## Dependency Injection Nedir?

Dependency Injection (DI), yazılım geliştirmede kullanılan bir tasarım desenidir. Bu desen, bir bileşenin, ihtiyaç duyduğu dış bağımlılıkları kendisi yaratmak yerine dışarıdan almasını sağlar. Bu sayede kodun daha esnek, bakımı kolay ve test edilebilir olmasını sağlar.

## Dependency Injection Özellikleri

- **Bağımsızlık:** Bir bileşenin, ihtiyaç duyduğu diğer bileşenlere doğrudan bağlı olmamasını sağlar. Bileşenler arası sıkı bağımlılıklar yerine, arayüzler veya soyutlamalar üzerinden etkileşim sağlar.
- **Esneklik:** DI, bileşenler arasındaki bağımlılıkları azaltarak kodun daha esnek olmasını sağlar. Bu sayede, değişiklikler yapmak veya farklı bileşenleri kullanmak daha kolay hale gelir.
- **Test Edilebilirlik:** DI, bağımlılıkların enjekte edilmesiyle kodun test edilebilirliğini artırır. Bağımlılıkların taklitleri (mock) kullanılarak bileşenlerin test edilmesi daha kolay olur.

## Projenin Yapısı

Bu proje, dependency injection prensibini uygulamak için bir örnek sunmaktadır. Özellikle `ProductService` ve `IProductService` arasındaki bağımlılık yönetimi örneklenmiştir.

- `IProductService` arayüzü, ürün işlemlerini tanımlar.
- `ProductService`, bu arayüzü uygular ve ürün işlemlerini gerçekleştirir.
- `Startup.cs` dosyasında `ConfigureServices` metodu, bağımlılıkların enjekte edilmesini yapılandırır.

## Detaylı Teorik İncelemek İsterseniz  👉  [Medium]([https://www.google.com](https://medium.com/@ahmetfatih.guzeller/dependency-injection-prensibi-ve-temel-kullan%C4%B1m-%C5%9Fekilleri-f396daf80f08)https://medium.com/@ahmetfatih.guzeller/dependency-injection-prensibi-ve-temel-kullan%C4%B1m-%C5%9Fekilleri-f396daf80f08)  dan ulaŞabilirsiniz !



