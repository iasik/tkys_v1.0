using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GelirVeritabani
/// </summary>
public class GelirVeritabani : Veritabani
{
	public void gelir()
    {
        var yeni = new gelir
        {
            ad = "test",
            miktar = 100,
        };

        Entity.gelir.Add(yeni);
        Entity.SaveChanges();
    }
}