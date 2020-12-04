using App.Core.Entities.BD_Entities;
using App.Core.Interfaces;
using App.Core.UseCases;
using App.Infrastructure.Datos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Unity;
using WebAppControler.Models;

namespace WebAppControler.Controllers
{
    public class HomeController : Controller
    {
        static ManageOperations<Product> ManageOperationsProduct;

        public IActionResult Index()
        {
            InitializeContainer();
            var entity = new Product
            {
                Code = "12345",
                Name = "Producto de Prueba",
                Stock = 5,
                Buy_P = 500,
                Sell_P = 600,
                Date = DateTime.Now,
                DateUpdate = DateTime.Now,
                Status = true
            };
            var obj = ManageOperationsProduct.Create(entity);
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        static void InitializeContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IOperations<Product>, ManageOperations<Product>>();
            container.RegisterType<IRepository<Product>, GenericRepository<Product>>();
            ManageOperationsProduct = container.Resolve<ManageOperations<Product>>();
        }
    }
}
