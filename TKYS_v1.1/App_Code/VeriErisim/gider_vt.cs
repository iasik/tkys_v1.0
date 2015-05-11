using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

public class gider_vt:Veritabani
{
    public islem_sonucu<bool> Ekle(gider yeni)
    {
        try
        {
            Entity.gider.Add(yeni);
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
                    sinif = "gider veritabanı"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<gider> Bul(int id)
    {
        try
        {
            var kayitlar = (from g in Entity.gider
                            where g.id == id
                            select g);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<gider>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<gider>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<gider>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "gider veritabanı"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(gider veri)
    {
        try
        {
            var kayit = (from g in Entity.gider
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
        catch (Exception hata)
        {
            return new islem_sonucu<bool>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Guncelle",
                    sinif = "gider veritabani",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }
    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from g in Entity.gider
                            where g.id == id
                            select g);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();

                Entity.gider.Remove(kayit);
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
                    sinif = "gider veritabani",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }
    public islem_sonucu<List<gider>> Listele()
    {
        try
        {
            var kayitlar = (from g in Entity.gider
                            select g).ToList();

            return new islem_sonucu<List<gider>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<gider>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "gider veritabani",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }

    //Gider Tablosu deneme
}