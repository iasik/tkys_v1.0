using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

//İşi yapan personel ile ilgili bilgi tutma konusunda bir problem var sanırıım...
public class is_vt : Veritabani
{
    public islem_sonucu<bool> Ekle(isler yeni)
    {
        try
        {
            // İş Türü tablosundan iş türünü alıyoruz. Eğer olmayan bir iş türü gelme durumunu kontrol edelim.
            //Sadece personel işi yapar yönetici işi yapamaz
            Entity.isler.Add(yeni);
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
                    sinif = "İşler Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı."
            };
        }
    }
    public islem_sonucu<isler> Bul(int id)
    {
        try
        {
            var kayitlar = (from i in Entity.isler
                            where i.id == id
                            select i);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<isler>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<isler>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<isler>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "İşler Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(isler veri)
    {
        try
        {
            var kayit = (from i in Entity.isler
                         where i.id == veri.id
                         select i).FirstOrDefault();
            kayit.ad = veri.ad;
            kayit.detay = veri.detay;
            kayit.is_turu = veri.is_turu;// iş türünü alt tablodan aldık ne olacak??
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
                    sinif = "İşler Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }
    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from i in Entity.isler
                            where i.id == id
                            select i);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();

                Entity.isler.Remove(kayit);
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
                    sinif = "İşler Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }
    public islem_sonucu<List<isler>> Listele()
    {
        try
        {
            var kayitlar = (from i in Entity.isler
                            select i).ToList();

            return new islem_sonucu<List<isler>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<isler>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "İşler Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }

}