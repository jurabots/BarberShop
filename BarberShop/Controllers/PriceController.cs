using BarberShop.Context;
using BarberShop.InitializationDB;
using BarberShop.Models.ServicesAndPrice;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Controllers
{
    public class PriceController : Controller
    {
        public PriceController(BarberShopDB context)
        {
            Context = context;
        }
        public BarberShopDB Context { get; }

        public IActionResult ShowPriceAndService()
        {
            if (Context.Service.Count() == 0 || Context.Service.Count() < 6)
            {
                var service = Context.Service
                    .Where(x => x.Id >= 1).ToList();
                Context.Service.RemoveRange(service);
                SingletonInitServiceAndPrice init = SingletonInitServiceAndPrice.NewInstance();
                Context.Service.AddRange(init.AddServicePrice());
                Context.SaveChanges();
            }
            return View(Context.Service.ToList());
        }
    }
  

}
