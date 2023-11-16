using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristiansBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set;} // displays all the product details

        public IEnumerable<SelectListItem> CategoryList { get; set; } // install the new feature package
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
