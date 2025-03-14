﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TemizlikTakipApp;

namespace TemizlikTakipApp
{
    //Bu Sınıf Tüm kayıt işlemlerinden
    //ve verinin diğer formlar ile 
    //paylaşılmasından sorumludur
    public static class KayitYoneticisi
    {
        public static BindingList<Sinif> Siniflar { get; set; }
        public static BindingList<Ogrenci> Ogrenciler { get; set; }

        public static void Kaydet()
        {
            //Kaydetme işlemleri
            string metin = JsonSerializer.Serialize(Siniflar);

            File.WriteAllText("siniflar.txt", metin);

            string metin2 = JsonSerializer.Serialize(Ogrenciler);

            File.WriteAllText("ogrenciler.txt", metin2);
        }
        public static void Yukle()
        {
            
            if (File.Exists("siniflar.txt"))
            {
                string metin = File.ReadAllText("siniflar.txt");

                var liste = JsonSerializer.Deserialize<List<Sinif>>(metin);
                Siniflar = new BindingList<Sinif>(liste);
            }
            else
            {
                
                Siniflar = new BindingList<Sinif>();
            }
            
            if (File.Exists("ogrenciler.txt"))
            {
                string metin = File.ReadAllText("ogrenciler.txt");

                var liste = JsonSerializer.Deserialize<List<Ogrenci>>(metin);
                Ogrenciler = new BindingList<Ogrenci>(liste);
            }
            else
            {
               
                Ogrenciler = new BindingList<Ogrenci>();
            }
        }
    }
}