﻿

namespace Shop.DAL.Models.Products
{
    public class GetProductsModel
    {
        public int? productid { get; set; }
        public string productname { get; set; }
        public decimal unitprice { get; set; }
        public DateTime? creation_date { get; set; }

    }
}