using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Materials.Web.Models
{
    public class ProductModel
    {        
        public long ProductId { get; set; }
        public string Logo { get; set; }
        public string ProductName { get; set; }
        public string File { get; set; }
        public string Program { get; set; }
        //public string SearchText { get; set; }
    }
}