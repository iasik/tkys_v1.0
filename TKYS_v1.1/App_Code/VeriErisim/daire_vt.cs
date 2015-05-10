using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
public class daire_vt : Veritabani
{
    public islem_sonucu<bool> Ekle(daire yeni)
    {
        try
        {
            Entity.daire.Add(yeni);
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
                    sinif = "Daire Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }

    public islem_sonucu<daire> Bul(int id)
    {
        try
        {
            var kayitlar = (from d in Entity.daire
                            where d.id == id
                            select d);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<daire>
                {
                    basarili_mi = true,
                    veri = kayit,
                };
            }
            else
            {
                return new islem_sonucu<daire>
                {
                    basarili_mi = false,
                    mesaj = "kayıt bulunamadı",
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<daire>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "bul",
                    sinif = "Daire Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<bool> Guncelle(daire veri)
    {
        try
        {
            var kayit = (from d in Entity.daire
                         where d.id == veri.id
                         select d).FirstOrDefault();
            kayit.blok = veri.blok;
            kayit.kat = veri.kat;
            kayit.daire_no = veri.daire_no;
            kayit.daire_genisligi = veri.daire_genisligi;
            kayit.kullanici_id = veri.kullanici_id;// kullanıcı tablosundan çekecek

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
                    sinif = "Daire tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<bool> Sil(int id)
    {
        try
        {
            var kayitlar = (from d in Entity.daire
                            where d.id == id
                            select d);
            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();

                Entity.daire.Remove(kayit);
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
                    sinif = "Daire Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }
    }

    public islem_sonucu<List<daire>> Listele()
    {
        try
        {
            var kayitlar = (from d in Entity.daire
                            select d).ToList();

            return new islem_sonucu<List<daire>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<daire>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Daire Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }
}