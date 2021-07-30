using BarberShop.Context;
using BarberShop.Models.HomePageDescr;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Controllers
{
    /*
     1.Доделать главную страницу. добавить фото и описание с базы данных +
     2.Создать базу данных +
     3.Создать прайс лист извлеченние данных идёт с базы данных 
     */
    public class HomeController : Controller
    {
        public HomeController(BarberShopDB context)
        {
            Context = context;
        }

        public BarberShopDB Context { get; }

        public IActionResult Index()
        {
            HomePageDescription homePageDesc = Context.HomePageDescriptions.Find(1);
            return View(homePageDesc);
        }

    }
}
