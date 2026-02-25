string girisMesaji = "Hoşgeldin Kullanıcı, Lütfen geçerli bir kimlik kartı oluşturmak için bilgilerini eksiksiz ve doğru gir.";

Console.WriteLine(girisMesaji);

Console.WriteLine("Ad ve soyadınızı giriniz: ");
string isim = Console.ReadLine();

Console.WriteLine("Yaşınızı giriniz: ");
int yas = int.Parse(Console.ReadLine());

Console.WriteLine("Memleketinizi giriniz: ");
string memleket = Console.ReadLine();

Console.Write("Mesleğinizi giriniz: ");
string meslek = Console.ReadLine();

Console.WriteLine("Kimlik kartınız hazırlanmıştır. Tebrikler :)");

Console.WriteLine("╔══════════════════════════╗");
Console.WriteLine("       KİMLİK KARTI");
Console.WriteLine($"  Ad Soyad  : {isim}");
Console.WriteLine($"  Yaş       : {yas}");
Console.WriteLine($"  Şehir     : {memleket}");
Console.WriteLine($"  Meslek    : {meslek}");
Console.WriteLine("╚══════════════════════════╝");
