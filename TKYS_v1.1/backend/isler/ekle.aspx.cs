using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_isler_ekle : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TKYSEntities isturu = new TKYSEntities();
        TKYSEntities kullanici = new TKYSEntities();
        if (!IsPostBack)
        {
            var isturuQuery = (from c in isturu.is_turu                            
                               select new { c.id, c.ad }).ToList();
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "ad";
            DropDownList1.DataSource = isturuQuery;
            DropDownList1.DataBind();

            var kullaniciQuery = (  from c in kullanici.kullanici
                                    where c.yetki=="2"// sadece işi personel gerçekleştirir...
                                    select new { c.id, c.kullanici_adi }).ToList();
            DropDownList2.DataValueField = "id";
            DropDownList2.DataTextField = "kullanici_adi";
            DropDownList2.DataSource = kullaniciQuery;
            DropDownList2.DataBind();
            
        }
    }
    protected void btn_ekle_Click(object sender, EventArgs e)
    {
        is_vt islervt = new is_vt();

        isler yeni_gelir = new isler();
        yeni_gelir.ad = txt_ad.Text;
        yeni_gelir.detay = txt_detay.Text;
        yeni_gelir.is_turu = Convert.ToInt32(DropDownList1.SelectedValue);
        yeni_gelir.kullanici_id = Convert.ToInt32(DropDownList2.SelectedValue);
        
        
        
        var sonuc = islervt.Ekle(yeni_gelir);       
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}