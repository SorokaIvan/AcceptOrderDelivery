using AcceptOrderDelivery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AcceptOrderDelivery.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrdersDbContext _ordersDbContext;
        private readonly OrderNumberGenerator _generator;

        public HomeController(OrdersDbContext ordersDbContext, OrderNumberGenerator generator)
        {
            _ordersDbContext = ordersDbContext;
            _generator = generator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }

        public IActionResult OrdersList()
        {
            var orders = _ordersDbContext.Orders.Select(o => o).ToList();
            return View(orders);
        }


        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderNumber = _generator.Generate();
                _ordersDbContext.Add(order);
                _ordersDbContext.SaveChanges();
                return RedirectToAction("OrdersList");
            }
            else
            {
                return View(order);
            }
        }

    }
}