using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_daire_guncelle : System.Web.UI.Page
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
        daire_vt dairevt = new daire_vt();
        daire yeni = new daire();
        //textbox'dan çek sınıftan ürettiğin nesneye ata
        yeni.id = Convert.ToInt32(Request.QueryString["id"]);
        yeni.kat = Convert.ToInt32(txt_kat.Text);
        yeni.daire_no = Convert.ToInt32(txt_daire_no.Text);
        yeni.daire_genisligi = Convert.ToInt32(txt_daire_genisligi.Text);
        yeni.blok = txt_blok.Text;
        yeni.kullanici_id = Convert.ToInt32(DropDownList1.SelectedValue);
        
        var sonuc = dairevt.Guncelle(yeni);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
    }

    public void Bul()
    {
        daire_vt dairevt = new daire_vt();
        var kayit = dairevt.Bul(Convert.ToInt32(Request.QueryString["id"]));
        txt_kat.Text = kayit.veri.kat.ToString();
        txt_blok.Text=kayit.veri.blok;
        txt_daire_no.Text = kayit.veri.daire_no.ToString();
        txt_daire_genisligi.Text = kayit.veri.daire_genisligi.ToString();
        //dropdownlist ile kullanici id yukarda getirdik.
    }
}