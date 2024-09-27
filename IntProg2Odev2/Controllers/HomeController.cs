using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntProg2Odev2.Models;

namespace IntProg2Odev2.Controllers
{
    [Authorize]
    public class HomeController : Controller
        
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            List<Table> sliderList = new List<Table>();
            using (var dbContext = new findikDbContext())
            {
                sliderList = dbContext.Table.ToList();
            }
                return View(sliderList);
        }

        public ActionResult UretimGrafigi () 
        {
            List<UretimGrafigi> uretimList  = new List<UretimGrafigi>();
            using(var dbContext = new findikDbContext())
            {
                uretimList = dbContext.UretimGrafigi.ToList();
            }
            return View(uretimList);
        }

        public ActionResult UretimSehirleri ()
        {
            List<UretimSehirleri> tbl_uretim = new List<UretimSehirleri>();
            using (var dbContext = new findikDbContext())
            {
                tbl_uretim = dbContext.UretimSehirleri.ToList();
            }
            return View(tbl_uretim);
        }

        public ActionResult FistikCesitleri ()
        {
            List <FistikCinsi> tbl_cins = new List<FistikCinsi> ();
            using(var dbContext = new findikDbContext()) 
            { 
                tbl_cins = dbContext.FistikCinsi.ToList();
            }
            return View(tbl_cins);
        }
    }
}