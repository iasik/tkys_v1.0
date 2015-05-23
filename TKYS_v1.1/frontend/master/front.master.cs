using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frontend_front : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        
        if(Session[SiteTanim.KullaniciSession]!=null)
        {
            YetkiKontrol();
            BildirimSay();
            BorcSay();
        }
    }

    public void YetkiKontrol()
    {
        if (((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).yetki == UyeTip.yonetici || ((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).yetki == UyeTip.personel)
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
        }
        else
        {
            Panel1.Visible = false;
            Panel3.Visible = true;
        }

    }

    public void BildirimSay()
    {

        bildirim_vt bildirim = new bildirim_vt();

        var kayitlar = bildirim.Kullanici_Bildirim(((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).id);

        lbl_bildirimSayisi.Text = kayitlar.veri.Count().ToString();
    
    }
    public void BorcSay()
    {

        borc_vt borc = new borc_vt();

        var kayitlar = borc.kullanici_borc(((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).id);

        lbl_borc.Text = kayitlar.veri.Count().ToString();

    }
}
