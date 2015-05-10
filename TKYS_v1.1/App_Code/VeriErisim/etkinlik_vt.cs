using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
public class etkinlik_vt :Veritabani
{
    public islem_sonucu<bool> Ekle(etkinlik yeni)
    {
        try
        {
            Entity.etkinlik.Add(yeni);
            Entity.SaveChanges();
            return new islem_sonucu<bool>
            {
                basarili_mi = true,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<bool>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "Ekle",
                    sinif = "Etkinlik Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }

    public islem_sonucu<etkinlik> Bul(int id)
    {
        try
        {
            var kayitlar = (from    e in Entity.etkinlik
                            where   e.id == id
                            select  e);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<etkinlik>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<etkinlik>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<etkinlik>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "Etkinlik Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(etkinlik veri)
    {
        try
        {
            var kayit = (from b in Entity.etkinlik
                         where b.id == veri.id
                         select b).FirstOrDefault();

            kayit.ad = veri.ad;
            kayit.detay = veri.detay;
            kayit.tarih = veri.tarih;
            kayit.kullanici_id = veri.kullanici_id;

            Entity.SaveChanges();

            return new islem_sonucu<bool>
            {
                basarili_mi = true,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<bool>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Guncelle",
                    sinif = "Etkinlik Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from e in Entity.etkinlik
                            where e.id == id
                            select e);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                Entity.etkinlik.Remove(kayit);
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
                    sinif = "Etkinlik Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<List<etkinlik>> Listele()
    {
        try
        {
            var kayitlar = (from    e in Entity.etkinlik
                            select  e).ToList();

            return new islem_sonucu<List<etkinlik>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<etkinlik>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Etkinlik Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }

}