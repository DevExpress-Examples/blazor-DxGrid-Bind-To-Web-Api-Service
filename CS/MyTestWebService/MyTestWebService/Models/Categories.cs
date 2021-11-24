﻿using System;
using System.Collections.Generic;

namespace MyTestWebService.Models {
    public partial class Categories {
        public Categories() {
            Products = new HashSet<Products>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
