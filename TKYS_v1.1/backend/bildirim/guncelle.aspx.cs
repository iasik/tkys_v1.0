using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_bildirim_guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TKYSEntities kullaniciSec = new TKYSEntities();
        if (!IsPostBack)
        {
            Bul();
            var isturuQuery = (from c in kullaniciSec.kullanici
                               select new { c.id, c.kullanici_adi }).ToList();
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "kullanici_adi";
            DropDownList1.DataSource = isturuQuery;
            DropDownList1.DataBind();
            DropDownList1.SelectedValue = Request.QueryString["user"];// seçili olan id'yi gösteriyor.

        }

    }
    protected void btn_guncelle_Click(object sender, EventArgs e)
    {
        bildirim_vt bildirimvt = new bildirim_vt();
        bildirim yeni = new bildirim();
        //textbox'dan çek sınıftan ürettiğin nesneye ata
        yeni.id = Convert.ToInt32(Request.QueryString["id"]);
        yeni.ad = txt_ad.Text;
        yeni.detay = txt_detay.Text;
        yeni.kullanici_id = Convert.ToInt32(DropDownList1.SelectedValue);

        var sonuc = bildirimvt.Guncelle(yeni);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
    }

    public void Bul()
    {
        bildirim_vt bildirimvt = new bildirim_vt();
        var kayit = bildirimvt.Bul(Convert.ToInt32(Request.QueryString["id"]));
        txt_ad.Text = kayit.veri.ad;
        txt_detay.Text = kayit.veri.detay;
        //dropdownlist ile kullanici id yukarda getirdik.
    }
}