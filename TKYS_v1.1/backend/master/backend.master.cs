using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class backend_backend : System.Web.UI.MasterPage
{
    public string bildirim_sayisi;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        YetkiKontrol();
        bildirim();
    }

    public void YetkiKontrol()
    {
        if(Session[SiteTanim.KullaniciSession]!=null)
        {
            if (((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).yetki == UyeTip.yonetici || ((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).yetki == UyeTip.personel)
            {
                kullanici_adi.Text = ((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).kullanici_adi;
            }
            else
                Response.Redirect("~/frontend");
        }
        else
            Response.Redirect("~/frontend");
    }

    protected void bildirim()
    {
        bildirim_vt bildirim = new bildirim_vt();
        var sonuc = bildirim.Kullanici_Bildirim(((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).id);
        if(sonuc.basarili_mi)
        {
            rpt_bildirim.DataSource = sonuc.veri;
            rpt_bildirim.DataBind();
            bildirim_sayisi = sonuc.veri.Count().ToString();
            lbl_bildirim.Text = bildirim_sayisi;
        }
    }
}
