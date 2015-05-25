using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
//Unutma! Kullanıcı girişinden alınan session'dan kullanıcı yetkiyi çekeceğiz ve dropdownlistde yetkileri ona göre listeleyeceğiz.
public class kullanici_vt : Veritabani
{
    public islem_sonucu<kullanici_bilgisi> Giris(string kullanici_adi, string sifre) // siteye giriş yapılan fonksiyon
    {
        try
        {//kullanıcının textbox'a girdiği kullanıcı adı ve şifreyi veritabanında karşılaştırıyoruz.

            var kayitlar = (from k in Entity.kullanici
                            where k.kullanici_adi == kullanici_adi && k.sifre == sifre
                            select k);

            if (kayitlar.Count() > 0)
            {
                var kayit = kayitlar.FirstOrDefault();
                var yetki_kontrol = new kullanici_bilgisi
                {

                    ad = kayit.ad,
                    kullanici_adi = kayit.kullanici_adi,
                    soyad = kayit.soyad,
                    id = kayit.id,                    
                    e_posta = kayit.e_posta
                }; 
                if (kayit.yetki == "1")
                {
                    yetki_kontrol.yetki = UyeTip.yonetici;
                }
                else if (kayit.yetki == "2")
                {
                    yetki_kontrol.yetki = UyeTip.personel;

                }
                else
                {
                    yetki_kontrol.yetki = UyeTip.site_sakini;
                }

                return new islem_sonucu<kullanici_bilgisi>
                {
                    basarili_mi = true,
                    veri = yetki_kontrol,
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
                    sinif = "Kullanıcı Tablosu"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<kullanici_bilgisi> Ekle(kullanici_bilgisi yeni) // kullanıcı ekleyen  fonksiyon
    {
        try {
            var kayitlar = (from u in Entity.kullanici
                            where yeni.e_posta == u.e_posta || yeni.kullanici_adi == u.kullanici_adi
                            select u
                          ).Count();

            if (kayitlar > 0)
            {
                return new islem_sonucu<kullanici_bilgisi>{
                    basarili_mi=false,
                    mesaj="Kullanıcı adı veya e-posta adresi kullanılmaktadır."
                };
            }
            else{

                var yeni_kullanici = new kullanici
                {
                    kullanici_adi = yeni.kullanici_adi,
                    sifre=yeni.sifre,
                    ad=yeni.ad,
                    soyad=yeni.soyad,
                    e_posta=yeni.e_posta,
                    cep_telefonu=yeni.cep_telefonu,
                    cinsiyet=yeni.cinsiyet,
                };
                if (yeni.yetki == UyeTip.yonetici)
                    yeni_kullanici.yetki = "1";
                else if (yeni.yetki == UyeTip.personel)
                    yeni_kullanici.yetki="2";
                else
                    yeni_kullanici.yetki="3";

                Entity.kullanici.Add(yeni_kullanici);
                Entity.SaveChanges();

                return new islem_sonucu<kullanici_bilgisi>
                {
                    basarili_mi = true,
                    //Kullanıcı bilgisi döndürmeye gerek var mı???
                    //veri = new kullanici_bilgisi
                    //{
                    //    kullanici_adi = yeni_kullanici.kullanici_adi,
                    //    sifre = yeni_kullanici.sifre,
                    //    ad = yeni_kullanici.ad,
                    //    soyad = yeni_kullanici.soyad,
                    //    e_posta = yeni_kullanici.e_posta,
                    //    cep_telefonu = yeni_kullanici.cep_telefonu,
                    //    cinsiyet = yeni_kullanici.cinsiyet,
                    //},

                };
            }   
        }
        catch (Exception hata) {
            return new islem_sonucu<kullanici_bilgisi>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "Ekle",
                    sinif = "UyeVeritabani"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
    }
    public islem_sonucu<kullanici_bilgisi> Bul(int id) // kullanıcı bulma fonksiyon
  {
      try {
          var kayitlar = (from u in Entity.kullanici
                          where u.id == id
                          select u
              );

          if (kayitlar.Count() > 0) {
              var kayit = kayitlar.FirstOrDefault();
              var yetki_kontrol = new kullanici_bilgisi
              {
                  kullanici_adi = kayit.kullanici_adi,
                  sifre = kayit.sifre,
                  ad = kayit.ad,
                  soyad = kayit.soyad,
                  e_posta = kayit.e_posta,
                  cep_telefonu = kayit.cep_telefonu,
                  cinsiyet = kayit.cinsiyet,
              };
    
              if (kayit.yetki == "1")
              {
                  yetki_kontrol.yetki = UyeTip.yonetici;
              }
              else if (kayit.yetki == "2")
              {
                  yetki_kontrol.yetki = UyeTip.personel;

              }
              else
              {
                  yetki_kontrol.yetki = UyeTip.site_sakini;
              }


              return new islem_sonucu<kullanici_bilgisi>
              {
                  basarili_mi = true,
                  veri = yetki_kontrol,

              };

          }
          else
          {
              return new islem_sonucu<kullanici_bilgisi>
              {
                  basarili_mi = false,
                  mesaj = "Kayıt Bulunamadı"
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
                  metod = "Bul",
                  sinif = "UyeVeritabani"
              },
              mesaj = "Bir hata ile karşılaşıldı"
          };
      }
  }
    public islem_sonucu<kullanici_bilgisi> Guncelle(kullanici_bilgisi kullanici){
      try{
          var kayitlar=(from u in Entity.kullanici
                        where u.id==kullanici.id
                        select u
                            );
          if (kayitlar.Count() > 0)
          {
              var kayit = kayitlar.FirstOrDefault();

                  kayit.kullanici_adi = kullanici.kullanici_adi;
                  kayit.sifre = kullanici.sifre;
                  kayit.ad = kullanici.ad;
                  kayit.soyad = kullanici.soyad;
                  kayit.e_posta = kullanici.e_posta;
                  kayit.cep_telefonu = kullanici.cep_telefonu;
                  kayit.cinsiyet = kullanici.cinsiyet;
                  //kayit.yetki = kullanici.yetki.ToString();
                  if (kullanici.yetki == UyeTip.yonetici)
                      kayit.yetki = "1";
                  else if (kullanici.yetki == UyeTip.personel)
                      kayit.yetki = "2";
                  else
                      kayit.yetki = "3";  
                  Entity.SaveChanges();

                  return new islem_sonucu<kullanici_bilgisi> { 
                      basarili_mi=true,
                      veri=kullanici
                  };
          }

          else 
          {
              return new islem_sonucu<kullanici_bilgisi>
              {
                  basarili_mi = false,
                  mesaj = "Kayıt Güncellenemedi."
              };
          }
      
       }
        catch (Exception hata) {
            return new islem_sonucu<kullanici_bilgisi>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    hata_mesaji = hata.Message,
                    metod = "Güncelle",
                    sinif = "UyeVeritabani"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }
  }
    public islem_sonucu<bool> Sil(int id)
    {
        try {
            var kayitlar = (from u in Entity.kullanici
                            where u.id == id
                            select u);
            if (kayitlar.Count() > 0) { 
                    var kayit = kayitlar.FirstOrDefault();
                    Entity.kullanici.Remove(kayit);
                    Entity.SaveChanges();
                    return new islem_sonucu<bool> { 
                    basarili_mi=true,
                    };
            }
            else
            {
                return new islem_sonucu<bool>
                {
                    basarili_mi = false,
                    mesaj = "Silinecek kayıt bulunamadı."
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
                    hata_mesaji = hata.Message,
                    metod = "Sil",
                    sinif = "UyeVeritabani"
                },
                mesaj = "Bir hata ile karşılaşıldı"
            };
        }

    }
    public islem_sonucu<List<kullanici>> Listele()
    {
        try
        {
            var kayitlar = (from k in Entity.kullanici
                            select k).ToList();

            return new islem_sonucu<List<kullanici>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<kullanici>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Kullanıcı Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }
    public islem_sonucu<List<kullanici>> site_sakini_listele()
    {
        try
        {
            var kayitlar = (from k in Entity.kullanici
                            where k.yetki == "3"
                            select k).ToList();

            return new islem_sonucu<List<kullanici>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<kullanici>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "site sakini listele",
                    sinif = "Kullanıcı Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }
    public islem_sonucu<List<kullanici>> son_kayitlar()
    {
        try
        {
            var kayitlar = (from k in Entity.kullanici
                            orderby k.id descending 
                            select k ).Take(10).ToList();

            return new islem_sonucu<List<kullanici>>
            {
                basarili_mi = true,
                veri = kayitlar,
            };
        }
        catch (Exception hata)
        {
            return new islem_sonucu<List<kullanici>>
            {
                basarili_mi = false,
                hata_bilgi = new hata
                {
                    metod = "Listele",
                    sinif = "Kullanıcı Tablosu",
                    hata_mesaji = hata.Message,
                },
            };
        }

    }


}