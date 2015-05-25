using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class frontend_rezervasyon_yapildi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("rezervasyon.aspx");
        }
        else
        {
            yapildi(Convert.ToInt32(Request.QueryString["id"]));
        }
    }
        public void yapildi(int id)
    {
        rezervasyon_vt rezerv = new rezervasyon_vt();
        rezervasyon rezervasyon1 = new rezervasyon();
        rezervasyon1.ad = "rezervasyon";
        rezervasyon1.detay = "rezervasyon_detay";
        rezervasyon1.sosyal_tesis_id = Convert.ToInt32(Request.QueryString["id"]);
        rezervasyon1.kullanici_id = ((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).id;
        var sonuc = rezerv.Ekle(rezervasyon1);
        if(sonuc.basarili_mi)
        {
            Response.Redirect("rezervasyon.aspx");
        }
        else
            Response.Redirect("rezervasyon.aspx");
    }
   }
