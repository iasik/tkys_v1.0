using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
public class bildirim_vt : Veritabani
{
    public islem_sonucu<bool> Ekle(bildirim yeni)
    {
        try
        {
            Entity.bildirim.Add(yeni);
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
                    sinif = "Bildirim Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }

    public islem_sonucu<bildirim> Bul(int id)
    {
        try
        {
            var kayitlar = (from b in Entity.bildirim
                            where b.id == id
                            select b);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<bildirim>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<bildirim>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<bildirim>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "Bildirim Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(bildirim veri)
    {
        try
        {
            var kayit = (from b in Entity.bildirim
                         where b.id == veri.id
                         select b).FirstOrDefault();
            kayit.detay = veri.detay;
            kayit.ad = veri.ad;
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
                    sinif = "Bildirim Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from b in Entity.bildirim
                            where b.id == id
                            select b);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();

                Entity.bildirim.Remove(kayit);
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
                    sinif = "Bildirim Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<List<bildirim>> Listele()
    {
        try
        {
            var kayitlar = (from b in Entity.bildirim
                            select b).ToList();

            return new islem_sonucu<List<bildirim>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<bildirim>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Bildirim Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }
}