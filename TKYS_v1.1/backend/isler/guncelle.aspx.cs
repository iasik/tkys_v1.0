using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_isler_guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TKYSEntities isturu = new TKYSEntities();
        TKYSEntities kullanici = new TKYSEntities();

        if (!IsPostBack)
        {
            Bul();
            var isturuQuery = (from c in isturu.is_turu
                               select new { c.id, c.ad }).ToList();
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "ad";
            DropDownList1.DataSource = isturuQuery;
            DropDownList1.DataBind();
            DropDownList1.SelectedValue = Request.QueryString["isturu"];// seçili olan id'yi gösteriyor.

            var kullaniciQuery = (from c in kullanici.kullanici
                                  where c.yetki == "2"// sadece işi personel gerçekleştirir...
                                  select new { c.id, c.kullanici_adi }).ToList();
            DropDownList2.DataValueField = "id";
            DropDownList2.DataTextField = "kullanici_adi";
            DropDownList2.DataSource = kullaniciQuery;
            DropDownList2.DataBind();
            DropDownList2.SelectedValue = Request.QueryString["user"];// seçili olan id'yi gösteriyor.
        }
            
    }
    protected void btn_guncelle_Click(object sender, EventArgs e)
    {
        is_vt isvt = new is_vt();
        isler yeni = new isler();
        yeni.id = Convert.ToInt32(Request.QueryString["id"]);
        yeni.ad = txt_ad.Text;
        yeni.detay = txt_detay.Text;
        yeni.is_turu = Convert.ToInt32(DropDownList1.SelectedValue);
        yeni.kullanici_id = Convert.ToInt32(DropDownList2.SelectedValue);
        var sonuc = isvt.Guncelle(yeni);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
    }

    public void Bul()
    {
        is_vt isvt = new is_vt();
        var kayit = isvt.Bul(Convert.ToInt32(Request.QueryString["id"]));
        txt_ad.Text = kayit.veri.ad;
        txt_detay.Text = kayit.veri.detay;
        //dropdownlist yukarda getirdik.
    }
}