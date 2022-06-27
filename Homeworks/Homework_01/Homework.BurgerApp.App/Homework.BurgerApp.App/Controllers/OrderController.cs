using Homework.BurgerApp.App.Models.Domain;
using Homework.BurgerApp.App.Models.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace Homework.BurgerApp.App.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            var orders = StaticDb.Orders;
            var ordersViewModel = orders.Select(x => x.MapToOrderViewModel()).ToList();
            return View(ordersViewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var order = new Order();
            return View(order);

        }
        [HttpPost]
        public IActionResult Create(Order order)
        {
            StaticDb.Orders.Add(order);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var editOrders = StaticDb.Orders;
            var orderViewEditModel = editOrders.FirstOrDefault(x => x.MapToOrderViewEditModel());
            return View();
        }

        [HttpPost]
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

    }
}
