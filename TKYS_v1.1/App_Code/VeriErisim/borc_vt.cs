using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

public class borc_vt : Veritabani
{
    public islem_sonucu<bool> Ekle(borc yeni)
    {
        try
        {
            Entity.borc.Add(yeni);
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
                    sinif = "Borç Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }

    public islem_sonucu<borc> Bul(int id)
    {
        try
        {
            var kayitlar = (from    b in Entity.borc
                            where   b.id == id
                            select  b);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<borc>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<borc>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<borc>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "Borç Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(borc veri)
    {
        try
        {
            var kayit = (from b in Entity.borc
                         where b.id == veri.id
                         select b).FirstOrDefault();

            kayit.ad = veri.ad;
            kayit.miktar = veri.miktar;
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
                    sinif = "Borç Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from b in Entity.borc
                            where b.id == id
                            select b);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                Entity.borc.Remove(kayit);
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
                    sinif = "Borç Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<List<borc>> Listele()
    {
        try
        {
            var kayitlar = (from    b in Entity.borc
                            select  b).ToList();

            return new islem_sonucu<List<borc>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<borc>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Borç Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }

    public islem_sonucu<List<borc>> kullanici_borc(int kullanici_id)
    {
        try
        {
            var kayitlar = (from b in Entity.borc
                            where b.kullanici_id == kullanici_id
                            select b).ToList();

            return new islem_sonucu<List<borc>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<borc>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Borç Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }
}