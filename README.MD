### Proje Adı: Araba Üretim Programı

Bu proje, kullanıcıdan araba bilgilerini alarak bir listeye ekleyen ve bu bilgileri ekrana yazdıran basit bir konsol uygulamasıdır.

#### Özellikler
- Kullanıcıdan araba bilgilerini alır: Seri Numarası, Marka, Model, Renk ve Kapı Sayısı.
- Girilen bilgilerin doğruluğunu kontrol eder.
- Geçersiz girişlerde kullanıcıyı uyarır ve tekrar giriş yapmasını ister.
- Üretilen arabaların bilgilerini ekrana yazdırır.

#### Gereksinimler
- .NET Core SDK

#### Kurulum
1. Bu projeyi yerel makinenize klonlayın:
    ```sh
    git clone <repository-url>
    ```
2. Proje dizinine gidin:
    ```sh
    cd WeekFiveFinal
    ```

#### Kullanım
1. Projeyi çalıştırın:
    ```sh
    dotnet run
    ```
2. Konsolda, araba üretmek isteyip istemediğinizi soran bir mesaj göreceksiniz. `e` veya `h` girerek yanıtlayın.
3. `e` yanıtını verdiğinizde, sizden araba bilgilerini girmenizi isteyecektir. Her bir bilgi için geçerli bir giriş yapın.
4. Geçersiz bir giriş yaptığınızda, hata mesajı alacak ve tekrar giriş yapmanız istenecektir.
5. `h` yanıtını verdiğinizde, üretilen arabaların bilgileri ekrana yazdırılacaktır.

#### Katkıda Bulunma
Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın.

#### Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.