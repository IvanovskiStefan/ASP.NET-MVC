using Homework.BurgerApp.App.Models.Domain;
using Homework.BurgerApp.App.Models.Mapper;
using Homework.BurgerApp.App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework.BurgerApp.App.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
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
        public IActionResult Edit(int? id)
        {
            var user = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                var orderFromDb = StaticDb.Orders.FirstOrDefault(x=>x.Id == order.Id);
                orderFromDb.FullName = order.FullName;
                orderFromDb.Adress = order.Adress;
                orderFromDb.Burgers = order.Burgers;
                return RedirectToAction("Create");
            }
            return View();
        }
        [HttpGet]
     
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return new EmptyResult();

            }
            Order orderFromDb = StaticDb.Orders.SingleOrDefault(x => x.Id == id);
            
            if(orderFromDb == null)
            {
                return NotFound();
            }
            OrderViewDetailsModel model = orderFromDb.MapToDetailsViewModel(); 

            return View(model);
        }

    }
}
