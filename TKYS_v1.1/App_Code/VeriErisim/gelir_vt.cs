using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

/// <summary>
/// Summary description for gelir_vt
/// </summary>
public class gelir_vt : Veritabani
{
	public islem_sonucu<bool> Ekle(gelir yeni)
    {
        try
        {
            Entity.gelir.Add(yeni);
            Entity.SaveChanges();
            return new islem_sonucu<bool>
            {
                basarili_mi = true,
            };
        }
        catch(Exception hata)
        {
            return new islem_sonucu<bool>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "Ekle",
                    sinif = "gelir veritabanı"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }

    public islem_sonucu<gelir> Bul(int id)
    {
        try
        {
            var kayitlar = (from g in Entity.gelir
                            where g.id == id
                            select g);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<gelir>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<gelir>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<gelir>
             {
                 basarili_mi = false,
                 hata_bilgi = new hata
                 {
                     hata_mesaji = hata.Message,
                     metod = "bul",
                     sinif = "gelir veritabanı"
                 },
                 mesaj = "Bir hata ile karşılaşıldı"
             };
        }
    }
    public islem_sonucu<bool> Guncelle(gelir veri)
    {
        try
        {
            var kayit = (from g in Entity.gelir
                        where g.id == veri.id
                        select g).FirstOrDefault();
            kayit.ad = veri.ad;
            kayit.miktar = veri.miktar;

            Entity.SaveChanges();

            return new islem_sonucu<bool>
            {
                basarili_mi = true,
            };
        }
        catch(Exception hata)
        {
            return new islem_sonucu<bool>{
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Guncelle",
                    sinif = "gelir veritabani",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from g in Entity.gelir
                            where g.id == id
                            select g);
            if(kayitlar.Count()>0)
            {
                var kayit = kayitlar.FirstOrDefault();

                Entity.gelir.Remove(kayit);
                Entity.SaveChanges();
                return new islem_sonucu<bool>
                {
                    basarili_mi = true
                };
            }
            else
            {
                return new islem_sonucu<bool>
                {
                    basarili_mi = false,
                    mesaj = "veri bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<bool>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Sil",
                    sinif = "gelir veritabani",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<List<gelir>> Listele()
    {
        try
        {
            var kayitlar = (from g in Entity.gelir
                            select g).ToList();

            return new islem_sonucu<List<gelir>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<gelir>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "gelir veritabani",
                    hata_mesaji = hata.Message,
                },
            };
        }
        
    }
    public void test()
    {
        var kayit = (from g in Entity.gelir
                     where g.id == 1
                     select g).FirstOrDefault();

        kayit.ad = "mert";
        kayit.miktar = 15555;

        Entity.SaveChanges();
    }
}