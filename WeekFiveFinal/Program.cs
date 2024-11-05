using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();

        while (true)
        {
            string cevap;
            do
            {
                Console.WriteLine("Araba üretmek ister misiniz? (e/h)");
                cevap = Console.ReadLine()?.ToLower() ?? string.Empty;
                if (cevap != "e" && cevap != "h")
                {
                    Console.WriteLine("Geçersiz cevap! Lütfen 'e' veya 'h' giriniz.");
                }
            } while (cevap != "e" && cevap != "h");

            if (cevap == "h")
            {
                break;
            }

            Araba yeniAraba = new Araba();

        SeriNumarasiGir:
            Console.Write("Seri Numarası: ");
            string seriNumarasi = Console.ReadLine() ?? string.Empty;
            if (!long.TryParse(seriNumarasi, out _))
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz.");
                goto SeriNumarasiGir;
            }
            yeniAraba.SeriNumarasi = seriNumarasi;

        MarkaGir:
            Console.Write("Marka: ");
            string marka = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(marka) || !Regex.IsMatch(marka, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sadece harflerden oluşan bir metin giriniz.");
                goto MarkaGir;
            }
            yeniAraba.Marka = marka;

        ModelGir:
            Console.Write("Model: ");
            string model = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(model) || !Regex.IsMatch(model, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sadece harflerden oluşan bir metin giriniz.");
                goto ModelGir;
            }
            yeniAraba.Model = model;

        RenkGir:
            Console.Write("Renk: ");
            string renk = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(renk) || !Regex.IsMatch(renk, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sadece harflerden oluşan bir metin giriniz.");
                goto RenkGir;
            }
            yeniAraba.Renk = renk;

        KapiSayisiGir:
            Console.Write("Kapı Sayısı: ");
            if (!int.TryParse(Console.ReadLine(), out int kapiSayisi))
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
                goto KapiSayisiGir;
            }
            yeniAraba.KapiSayisi = kapiSayisi;

            arabalar.Add(yeniAraba);
        }

        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}, Model: {araba.Model}, Renk: {araba.Renk}, Kapı Sayısı: {araba.KapiSayisi}, Üretim Tarihi: {araba.UretimTarihi}");
        }
    }
}