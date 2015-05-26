using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_kullanici_guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var item1 = yetki.Items.FindByValue("1");
        var item2 = yetki.Items.FindByValue("2");
        if (((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).yetki == UyeTip.personel || ((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).yetki == UyeTip.site_sakini)
        {
            item1.Enabled = false;
            item2.Enabled = false;
        }
        if (!IsPostBack)
        {
            Bul();

            yetki.SelectedValue.DefaultIfEmpty();
            bool sorgu=false;
            if (Request.QueryString["cinsiyet"] == "False")
                sorgu = false;
            else if (Request.QueryString["cinsiyet"] == "True")
                sorgu = true;

            if (sorgu)
            {
                cinsiyet.SelectedValue = "1" ;
            }
            else 
            {
                cinsiyet.SelectedValue = "0";
            }
            //hata var burda..
            if (Request.QueryString["yetki"]=="1")
            {
                yetki.SelectedValue = "1";
            }
            else if (Request.QueryString["yetki"] == "2")
            {
                yetki.SelectedValue = "2";
            }
            else
            {
                yetki.SelectedValue = "3";
            }

        }

    }
    protected void btn_guncelle_Click(object sender, EventArgs e)
    {
        kullanici_vt kullanicivt = new kullanici_vt();
        kullanici_bilgisi yeni = new kullanici_bilgisi();

        yeni.id = Convert.ToInt32(Request.QueryString["id"]);
        yeni.ad = txt_ad.Text;
        yeni.soyad =txt_soyad.Text;
       /* if (cinsiyet.Checked)
        {
            yeni.cinsiyet = false;
        }
        else
        {
            yeni.cinsiyet = true;
        }*/
        yeni.e_posta = txt_e_posta.Text;
        yeni.cep_telefonu = txt_cep_telefonu.Text;
        yeni.kullanici_adi = txt_kullanici_adi.Text;
        yeni.sifre = txt_sifre.Text;
        if (yetki.SelectedValue == "1")
        {
            yeni.yetki = UyeTip.yonetici;
        }
        else if (yetki.SelectedValue == "2")
        {
            yeni.yetki = UyeTip.personel;
        }
        else
        {
            yeni.yetki = UyeTip.site_sakini;
        }
        //Label1.Text = yeni.ad + "-" + yeni.soyad + "-" + yeni.cinsiyet + "-" + yeni.e_posta + "-" + yeni.cep_telefonu + "-" + yeni.kullanici_adi + "-" + yeni.sifre + "-" + yeni.yetki;
        var sonuc = kullanicivt.Guncelle(yeni);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
    }

    public void Bul()
    {
        kullanici_vt kullanicivt = new kullanici_vt();
        var kayit = kullanicivt.Bul(Convert.ToInt32(Request.QueryString["id"]));
        txt_ad.Text = kayit.veri.ad;
        txt_soyad.Text = kayit.veri.soyad;
        txt_cep_telefonu.Text = kayit.veri.cep_telefonu;
        txt_e_posta.Text = kayit.veri.e_posta;
        txt_kullanici_adi.Text = kayit.veri.kullanici_adi;
        txt_sifre.Text = kayit.veri.sifre;
        //dropdownlist ile kullanici id yukarda getirdik.
    }
}