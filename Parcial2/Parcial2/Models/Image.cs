using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2.Models
{
    public class Image
    {
       
            public Image()
            {
                Files = new List<HttpPostedFileBase>();
            }

            public List<HttpPostedFileBase> Files { get; set; }
            // Rest of model details
        
    }
}