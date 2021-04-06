using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.DataAccess;
using MVC_EF_Start.Models;

namespace MVC_EF_Start.Controllers
{
    public class DatabaseExampleController : Controller
    {
        public ApplicationDbContext dbContext;

        public DatabaseExampleController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View(); 
        }


        public async Task<ViewResult> DatabaseOperations()
        {

            Store store = new Store();
            store.storeId = 1;
            store.storeName = "publix";

            Products a1 = new Products();
            a1.ProductId = 1;
            a1.name = "Shampoo";
            a1.price = 45;
            a1.store = store;

            Products a2 = new Products();
            a2.ProductId = 2;
            a2.name = "Bar Skap";
            a2.price = 10;
            a2.store = store;

            Products a3 = new Products();
            a3.ProductId = 3;
            a3.name = "Laptop";
            a3.price = 200;
            a3.store = store;

            Products a4 = new Products();
            a4.ProductId = 4;
            a4.name = "Facewash";
            a4.price = 30;
            a4.store = store;


            Products a5 = new Products();
            a5.ProductId = 5;
            a5.name = "Chicken";
            a5.price = 14;
            a5.store = store;

            Products a6 = new Products();
            a6.ProductId = 6;
            a6.name = "PopCorn";
            a6.price = 24;
            a6.store = store;

            Products a7 = new Products();
            a7.ProductId = 7;
            a7.name = "Bounty";
            a7.price = 16;
            a7.store = store;

            Products a8 = new Products();
            a8.ProductId = 8;
            a8.name = "okra";
            a8.price = 11;
            a8.store = store;

            Products a9 = new Products();
            a9.ProductId = 9;
            a9.name = "Pendrive";
            a9.price = 42;
            a9.store = store;

            Products a10 = new Products();
            a10.ProductId = 10;
            a10.name = "Watermelon";
            a10.price = 7;
            a10.store = store;

            Orders k1 = new Orders();
            k1.OrderId = 1;
            k1.OrderAmount = 2000;
            k1.store = store;

            Orders k2 = new Orders();
            k2.OrderId = 2;
            k2.OrderAmount = 200;
            k2.store = store;

            Orders k3 = new Orders();
            k3.OrderId = 3;
            k3.OrderAmount = 2200;
            k3.store = store;

            Orders k4 = new Orders();
            k4.OrderId = 4;
            k4.OrderAmount = 2040;
            k4.store = store;

            Orders k5 = new Orders();
            k5.OrderId = 5;
            k5.OrderAmount = 2010;
            k5.store = store;

            Orders k6 = new Orders();
            k6.OrderId = 6;
            k6.OrderAmount = 2300;
            k6.store = store;

            Orders k7 = new Orders();
            k7.OrderId = 7;
            k7.OrderAmount = 2400;
            k7.store = store;

            Orders k8 = new Orders();
            k8.OrderId = 8;
            k8.OrderAmount = 800;
            k8.store = store;

            Orders k9 = new Orders();
            k9.OrderId = 9;
            k9.OrderAmount = 8700;
            k9.store = store;

            Orders k10 = new Orders();
            k10.OrderId = 10;
            k10.OrderAmount = 100;
            k10.store = store;


            OrderProductMap ka1 = new OrderProductMap
            {
                order = k1,
                product = a1,
                productquantity = 12
            };


            OrderProductMap ka2 = new OrderProductMap
            {
                order = k1,
                product = a2,
                productquantity = 34
            };


            OrderProductMap ka3 = new OrderProductMap
            {
                order = k1,
                product = a3,
                productquantity = 24
            };


            OrderProductMap ka4 = new OrderProductMap
            {
                order = k1,
                product = a7,
                productquantity = 15
            };


            OrderProductMap ka5 = new OrderProductMap
            {
                order = k1,
                product = a5,
                productquantity = 5
            };

            OrderProductMap ka6 = new OrderProductMap
            {
                order = k1,
                product = a10,
                productquantity = 23
            };



            OrderProductMap ka7 = new OrderProductMap
            {
                order = k2,
                product = a1,
                productquantity = 43
            };


            OrderProductMap ka8 = new OrderProductMap
            {
                order = k2,
                product = a5,
                productquantity = 55
            };


            OrderProductMap ka9 = new OrderProductMap
            {
                order = k2,
                product = a9,
                productquantity = 120
            };


            OrderProductMap ka10 = new OrderProductMap
            {
                order = k3,
                product = a7,
                productquantity = 80
            };


            OrderProductMap ka11 = new OrderProductMap
            {
                order = k3,
                product = a9,
                productquantity = 60
            };

            OrderProductMap ka12 = new OrderProductMap
            {
                order = k3,
                product = a1,
                productquantity = 150
            };

            OrderProductMap ka13 = new OrderProductMap
            {
                order = k3,
                product = a2,
                productquantity = 16
            };

            OrderProductMap ka14 = new OrderProductMap
            {
                order = k3,
                product = a6,
                productquantity = 25
            };


            OrderProductMap ka15 = new OrderProductMap
            {
                order = k3,
                product = a8,
                productquantity = 160
            };


            OrderProductMap ka16 = new OrderProductMap
            {
                order = k4,
                product = a1,
                productquantity = 18
            };


            OrderProductMap ka17 = new OrderProductMap
            {
                order = k4,
                product = a7,
                productquantity = 70
            };


            OrderProductMap ka18 = new OrderProductMap
            {
                order = k4,
                product = a3,
                productquantity = 90
            };

            OrderProductMap ka19 = new OrderProductMap
            {
                order = k4,
                product = a6,
                productquantity = 170
            };



            OrderProductMap ka20 = new OrderProductMap
            {
                order = k5,
                product = a1,
                productquantity = 220
            };

            OrderProductMap ka21 = new OrderProductMap
            {
                order = k5,
                product = a3,
                productquantity = 21
            };



            OrderProductMap ka22 = new OrderProductMap
            {
                order = k6,
                product = a2,
                productquantity = 210
            };


            OrderProductMap ka23 = new OrderProductMap
            {
                order = k6,
                product = a3,
                productquantity = 24
            };


            OrderProductMap ka24 = new OrderProductMap
            {
                order = k6,
                product = a7,
                productquantity = 28
            };


            OrderProductMap ka25 = new OrderProductMap
            {
                order = k7,
                product = a1,
                productquantity = 28
            };

            OrderProductMap ka26 = new OrderProductMap
            {
                order = k7,
                product = a4,
                productquantity = 115
            };



            OrderProductMap ka27 = new OrderProductMap
            {
                order = k8,
                product = a1,
                productquantity = 45
            };


            OrderProductMap ka28 = new OrderProductMap
            {
                order = k8,
                product = a6,
                productquantity = 70
            };


            OrderProductMap ka29 = new OrderProductMap
            {
                order = k8,
                product = a3,
                productquantity = 30
            };


            OrderProductMap ka30 = new OrderProductMap
            {
                order = k9,
                product = a2,
                productquantity = 143
            };


            OrderProductMap ka31 = new OrderProductMap
            {
                order = k10,
                product = a8,
                productquantity = 510
            };




            dbContext.Products.Add(a1);
            dbContext.Products.Add(a2);
            dbContext.Products.Add(a3);
            dbContext.Products.Add(a4);
            dbContext.Products.Add(a5);
            dbContext.Products.Add(a6);
            dbContext.Products.Add(a7);
            dbContext.Products.Add(a8);
            dbContext.Products.Add(a9);
            dbContext.Products.Add(a10);

            dbContext.Orders.Add(k1);
            dbContext.Orders.Add(k2);
            dbContext.Orders.Add(k3);
            dbContext.Orders.Add(k4);
            dbContext.Orders.Add(k5);
            dbContext.Orders.Add(k6);
            dbContext.Orders.Add(k7);
            dbContext.Orders.Add(k8);
            dbContext.Orders.Add(k9);
            dbContext.Orders.Add(k10);


            dbContext.OrderProductMaps.Add(ka1);
            dbContext.OrderProductMaps.Add(ka2);
            dbContext.OrderProductMaps.Add(ka3);
            dbContext.OrderProductMaps.Add(ka4);
            dbContext.OrderProductMaps.Add(ka5);
            dbContext.OrderProductMaps.Add(ka6);
            dbContext.OrderProductMaps.Add(ka7);
            dbContext.OrderProductMaps.Add(ka8);
            dbContext.OrderProductMaps.Add(ka9);
            dbContext.OrderProductMaps.Add(ka10);
            dbContext.OrderProductMaps.Add(ka11);
            dbContext.OrderProductMaps.Add(ka12);
            dbContext.OrderProductMaps.Add(ka13);
            dbContext.OrderProductMaps.Add(ka14);
            dbContext.OrderProductMaps.Add(ka15);
            dbContext.OrderProductMaps.Add(ka16);
            dbContext.OrderProductMaps.Add(ka17);
            dbContext.OrderProductMaps.Add(ka18);
            dbContext.OrderProductMaps.Add(ka19);
            dbContext.OrderProductMaps.Add(ka20);
            dbContext.OrderProductMaps.Add(ka21);
            dbContext.OrderProductMaps.Add(ka22);
            dbContext.OrderProductMaps.Add(ka23);
            dbContext.OrderProductMaps.Add(ka24);
            dbContext.OrderProductMaps.Add(ka25);
            dbContext.OrderProductMaps.Add(ka26);
            dbContext.OrderProductMaps.Add(ka27);
            dbContext.OrderProductMaps.Add(ka28);
            dbContext.OrderProductMaps.Add(ka29);
            dbContext.OrderProductMaps.Add(ka30);
            dbContext.OrderProductMaps.Add(ka31);
            dbContext.SaveChanges();



            return View();
        }

        public ViewResult LINQOperations()
        {

            //Geting List of orders Where a product 1 is sold

            var data = (from or in dbContext.Orders join opm in dbContext.OrderProductMaps on or.OrderId equals opm.order.OrderId where opm.product.ProductId == 3 select new { or.OrderId }).ToList();

            Console.WriteLine(data);


            var productList = (from op in dbContext.OrderProductMaps where op.productquantity == dbContext.OrderProductMaps.Where(p => p.product.ProductId == 4).Max(x => x.productquantity) select new {op.order.OrderId }).ToList();

            Console.WriteLine(productList);
            ViewBag.Products = data;
            ViewBag.orderList = productList;
            
            return View();
             

        }
    }
}