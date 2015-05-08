using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

/// <summary>
/// Summary description for Veritabani
/// </summary>
public class Veritabani
{
    protected TKYSEntities _entity;
    protected TKYSEntities Entity
    {
        get
        {
            if (_entity == null)
                _entity = new TKYSEntities();
            return _entity;
        }
    }
}