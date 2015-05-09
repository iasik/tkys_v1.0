using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for kullanici_bilgisi
/// </summary>
public class kullanici_bilgisi
{
    public bool cinsiyet { get; set; }
    public string kullanici_adi { get; set; }
    public string ad { get; set; }
    public string soyad { get; set; }
    public string sifre { get; set; }
    public int id { get; set; }
    public UyeTip yetki { get; set; }
    public string e_posta { get; set; }
    public string cep_telefonu { get; set; }
}