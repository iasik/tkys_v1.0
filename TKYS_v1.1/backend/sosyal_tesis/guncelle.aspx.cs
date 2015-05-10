using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_sosyal_tesis_guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        Bul();
    }
    protected void btn_guncelle_Click(object sender, EventArgs e)
    {
        sosyal_tesis_vt sosyaltesisvt = new sosyal_tesis_vt();
        sosyal_tesis yeni = new sosyal_tesis();
        //textbox'dan çek sınıftan ürettiğin nesneye ata
        yeni.id = Convert.ToInt32(Request.QueryString["id"]);
        yeni.ad = txt_ad.Text;
        yeni.kapasite = Convert.ToInt32(txt_kapasite.Text);


        var sonuc = sosyaltesisvt.Guncelle(yeni);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
    }

    public void Bul()
    {
        sosyal_tesis_vt sosyaltesisvt = new sosyal_tesis_vt();
        var kayit = sosyaltesisvt.Bul(Convert.ToInt32(Request.QueryString["id"]));
        txt_ad.Text = kayit.veri.ad;
        txt_kapasite.Text = kayit.veri.kapasite.ToString();
        //dropdownlist ile kullanici id yukarda getirdik.
    }
}