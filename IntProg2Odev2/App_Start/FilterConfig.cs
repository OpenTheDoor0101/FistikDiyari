﻿using System.Web;
using System.Web.Mvc;

namespace IntProg2Odev2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
