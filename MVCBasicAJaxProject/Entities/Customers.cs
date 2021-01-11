using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasicAJaxProject.Entities
{
    partial class Customers
    {
      
            public int? pageNo { get; set; }
            public IPagedList<Customers> CustomerList { get; set; }
      
    }
}