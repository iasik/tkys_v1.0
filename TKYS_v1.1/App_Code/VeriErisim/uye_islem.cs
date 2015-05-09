using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for uye_islem
/// </summary>
public class uye_islem:kullanici_vt
{
    public islem_sonucu<kullanici_bilgisi> Giris(string kullanici_adi, string sifre)
    {
        var sonuc = base.Giris(kullanici_adi, sifre);
        if (sonuc.hata_bilgi != null)
        {
            //Hata mesajını veritabanına kaydet
        }
        return sonuc;
    }
    //public islem_sonucu<kullanici_bilgisi> UyeOl(NUyeOl uyeBilgi)
    //{
    //    var sonuc = base.UyeOl(uyeBilgi);
    //    if (sonuc.HataBilgi != null)
    //    {
    //        //Hata mesajını veritabanına kaydet
    //    }
    //    return sonuc;
    //}
    //public islem_sonucu<string> SifremiUnuttum(string ePosta)
    //{
    //    var sonuc = base.SifremiUnuttum(ePosta);
    //    if (sonuc.HataBilgi != null)
    //    {
    //        //Hata mesajını veritabanına kaydet
    //    }
    //    return sonuc;
    //}
}