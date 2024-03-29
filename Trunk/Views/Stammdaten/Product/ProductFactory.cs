﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Views.Stammdaten.Product {
    public class ProductFactory
    {

        public static IProductView createProduct() {
            return new ProductView();
        }

        public static IProductView createProduct(int id, int? ProductNumber, string ProductName, string Ean, double? PricePurchase,
                                                 double? PriceSsale, int? produktCategory, int? ProductSup) {
            return  new ProductView(id, ProductNumber, ProductName, Ean, PricePurchase, PriceSsale,produktCategory, ProductSup);
        }

        public static  IPrdcatView createPrdcat (int id , int? ProductNumber, string ProductName)
        {
            return new PrdcatView(id, ProductNumber, ProductName);
        }

        public static IPrdcatView createNewPrdcat()
        {
            return new PrdcatView();
        }

       

    }
}
