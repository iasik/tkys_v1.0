using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

public class is_turu_vt:Veritabani
{
    public islem_sonucu<bool> Ekle(is_turu yeni)
    {
        try
        {
            Entity.is_turu.Add(yeni);
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
                    sinif = "İş Türü Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı."
            };
        }
    }
    public islem_sonucu<is_turu> Bul(int id)
    {
        try
        {
            var kayitlar = (from i in Entity.is_turu
                            where i.id == id
                            select i);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<is_turu>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<is_turu>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<is_turu>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "İş Türü Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(is_turu veri)
    {
        try
        {
            var kayit = (from i in Entity.is_turu
                         where i.id == veri.id
                         select i).FirstOrDefault();
            kayit.ad = veri.ad;
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
                    sinif = "İş Türü Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }
    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from i in Entity.is_turu
                            where i.id == id
                            select i);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();

                Entity.is_turu.Remove(kayit);
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
                    sinif = "İş Türü Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }
    public islem_sonucu<List<is_turu>> Listele()
    {
        try
        {
            var kayitlar = (from i in Entity.is_turu
                            select i).ToList();

            return new islem_sonucu<List<is_turu>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<is_turu>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "İş Türü Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }

}