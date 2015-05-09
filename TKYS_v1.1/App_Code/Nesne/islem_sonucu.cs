using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for islem_sonucu
/// </summary>
public class islem_sonucu<T>
{
    public bool basarili_mi { get; set; }
    public T veri { get; set; }
    public string mesaj { get; set; }
    public hata hata_bilgi { get; set; }
}