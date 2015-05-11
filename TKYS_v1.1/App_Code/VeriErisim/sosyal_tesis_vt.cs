using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
// sosyal tesis
public class sosyal_tesis_vt : Veritabani
{
    public islem_sonucu<bool> Ekle(sosyal_tesis yeni)
    {
        try
        {
            Entity.sosyal_tesis.Add(yeni);
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
                    sinif = "Sosyal Tesis Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }

    public islem_sonucu<sosyal_tesis> Bul(int id)
    {
        try
        {
            var kayitlar = (from s in Entity.sosyal_tesis
                            where s.id == id
                            select s);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<sosyal_tesis>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<sosyal_tesis>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<sosyal_tesis>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "Sosyal Tesis Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(sosyal_tesis veri)
    {
        try
        {
            var kayit = (from s in Entity.sosyal_tesis
                         where s.id == veri.id
                         select s).FirstOrDefault();

            kayit.ad = veri.ad;
            kayit.kapasite = veri.kapasite;

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
                    sinif = "Sosyal Tesis Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from s in Entity.sosyal_tesis
                            where s.id == id
                            select s);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();

                Entity.sosyal_tesis.Remove(kayit);
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
                    sinif = "Sosyal Tesis Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<List<sosyal_tesis>> Listele()
    {
        try
        {
            var kayitlar = (from s in Entity.sosyal_tesis
                            select s).ToList();

            return new islem_sonucu<List<sosyal_tesis>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<sosyal_tesis>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Sosyal Tesis Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }
}