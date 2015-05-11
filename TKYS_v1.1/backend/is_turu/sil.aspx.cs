﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class backend_is_turu_sil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Request.QueryString["id"]) != null)
            sil(Convert.ToInt32(Request.QueryString["id"]));
        else
            Response.Redirect("listele.aspx");
    }

    public void sil(int id)
    {
        is_turu_vt isturu = new is_turu_vt();
        var sonuc = isturu.Sil(id);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Write("hata");
    }
}