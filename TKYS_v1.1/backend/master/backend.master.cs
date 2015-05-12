using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class backend_backend : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        YetkiKontrol();
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
}
