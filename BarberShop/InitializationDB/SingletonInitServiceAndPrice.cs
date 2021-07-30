using BarberShop.Context;
using BarberShop.Models.ServicesAndPrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.InitializationDB
{
    public class SingletonInitServiceAndPrice
    {
        private static SingletonInitServiceAndPrice init = null;
        protected SingletonInitServiceAndPrice()
        {
           
        }

        public static SingletonInitServiceAndPrice NewInstance()
        {
            if (init == null)
            {
                init = new SingletonInitServiceAndPrice();
            }
            return init;
        }

        public List<Service> AddServicePrice()
        {
            List<Service> services = new List<Service>()
            {
                new Service { OurService = "Мужская стрижка", Price = 150 },
                new Service { OurService = "Стрижка бороды",Price = 100 },
                new Service { OurService = "Стрижка усов",Price = 80},
                new Service { OurService = "Стрижка под насадку", Price = 110},
                new Service { OurService = "Детская стрижка(до 11 лет)",Price = 100},
                new Service { OurService = "Бритье опасной бритвой", Price = 120}
            };           
            return services;
        }
    }
}
