// See https://aka.ms/new-console-template for more information
public class Ogrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public Servis Servis { get; set; }

    public Ogrenci(string ad, string soyad, Servis servis)
    {
        Ad = ad;
        Soyad = soyad;
        Servis = servis;
    }
}
public class Servis
{
    public string Plaka { get; set; }
    public string Sofor { get; set; }
    public string Guzergah { get; set; }

    public Servis(string plaka, string sofor, string guzergah)
    {
        Plaka = plaka;
        Sofor = sofor;
        Guzergah = guzergah;
    }
}


class Program
{
    static void Main()
    {
        // Servisler
        var servisler = new List<Servis>
        {
            new Servis("34ABC123", "DENİZ ARSLAN", "Kızılay - Bahçelievler"),
            new Servis("06DEF456", "EDANUR EL", "Çankaya - Dikmen")
        };

        // Öğrenciler
        var ogrenciler = new List<Ogrenci>
        {
            new Ogrenci("Nursena", "Akbulut", servisler[0]),
            new Ogrenci("Serdar", "Çelen", servisler[1])
        };

        // Öğrenciye göre servis bilgilerini ekrana yazdır
        foreach (var ogrenci in ogrenciler)
        {
            Console.WriteLine($"Öğrenci: {ogrenci.Ad} {ogrenci.Soyad}");
            Console.WriteLine($"Servis Plakası: {ogrenci.Servis.Plaka}");
            Console.WriteLine($"Şoför: {ogrenci.Servis.Sofor}");
            Console.WriteLine($"Güzergah: {ogrenci.Servis.Guzergah}");
            Console.WriteLine();
        }
    }
}

