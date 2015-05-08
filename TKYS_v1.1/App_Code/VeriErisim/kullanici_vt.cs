using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for kullanici_vt
/// </summary>
public class kullanici_vt : Veritabani
{
    protected islem_sonucu<kullanici_bilgisi> Giris (string kullanici_adi, string sifre) // siteye giriş yapılan fonksiyon
    {
        try
        {//kullanıcının textbox'a girdiği kullanıcı adı ve şifreyi veritabanında karşılaştırıyoruz.
            var kayitlar = (from k in Entity.kullanici
                            where k.kullanici_adi == kullanici_adi && k.sifre == sifre
                            select k);

            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                return new islem_sonucu<kullanici_bilgisi>
                {
                    basarili_mi = true,
                    veri = new kullanici_bilgisi
                    {

                        ad = kayit.ad,
                        kullanici_adi = kayit.kullanici_adi,
                        soyad = kayit.soyad,
                        id = kayit.id,
                        yetki = kayit.yetki,
                        e_posta = kayit.e_posta
                    }
                };
            }
            else
            {
                return new islem_sonucu<kullanici_bilgisi>
                {
                    basarili_mi = false,
                    mesaj = "Üye kaydı bulunamadı"
                };
            }
        }
        catch (Exception hata)
        {
            return new islem_sonucu<kullanici_bilgisi>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "Giris",
                    sinif = "UyeVeritabani"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }

 
}