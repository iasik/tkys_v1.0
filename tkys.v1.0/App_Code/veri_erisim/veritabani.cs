using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for veritabani
/// </summary>
public class veritabani
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