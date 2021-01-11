using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;


namespace MVCBasicAJaxProject.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext Data = new DatabaseContext();
        public ActionResult Index(int? PageNo)
        {
            int _pageNo = PageNo ?? 1;
            var CustomerLists = Data.CustomerLists.
                OrderByDescending(x => x.CustomerId).ToPagedList<Customers>(_pageNo, 10);

            if (Request.IsAjaxRequest()) //By using this if block , we manage to Request is ajax or not.
            {
                return PartialView("~/Views/Home/_CustomerList.cshtml", CustomerLists);
            }
            return View(CustomerLists);

            //This method is build on the IQuerable type Extension and  return with IPagedList type value.
        }
    }
}