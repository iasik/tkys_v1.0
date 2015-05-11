using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
public class rezervasyon_vt : Veritabani
{
    public islem_sonucu<bool> Ekle(rezervasyon yeni)
    {
        try
        {
            Entity.rezervasyon.Add(yeni);
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
                    sinif = "Rezervasyon Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }

    public islem_sonucu<rezervasyon> Bul(int id)
    {
        try
        {
            var kayitlar = (from r in Entity.rezervasyon
                            where r.id == id
                            select r);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<rezervasyon>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<rezervasyon>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<rezervasyon>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "Rezerzasyon Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(rezervasyon veri)
    {
        try
        {
            var kayit = (from r in Entity.rezervasyon
                         where r.id == veri.id
                         select r).FirstOrDefault();
            kayit.detay = veri.detay;
            kayit.ad = veri.ad;
            kayit.sosyal_tesis_id = veri.sosyal_tesis_id;
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
                    sinif = "Rezervasyon Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from r in Entity.rezervasyon
                            where r.id == id
                            select r);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();

                Entity.rezervasyon.Remove(kayit);
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
                    sinif = "Rezervasyon Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<List<rezervasyon>> Listele()
    {
        try
        {
            var kayitlar = (from b in Entity.rezervasyon
                            select b).ToList();

            return new islem_sonucu<List<rezervasyon>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<rezervasyon>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Rezervasyon Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }
}