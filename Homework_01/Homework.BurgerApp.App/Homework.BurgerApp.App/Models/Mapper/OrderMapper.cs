using Homework.BurgerApp.App.Models.Domain;
using Homework.BurgerApp.App.Models.ViewModels;

namespace Homework.BurgerApp.App.Models.Mapper
{
    public static class OrderMapper
    {
        public static OrderViewModel MapToOrderViewModel(this Order order)
        {
            return new OrderViewModel 
            { 
                Burgers = order.Burgers, 
                FullName=order.FullName,
                IsDelivered = order.IsDelivered 
            };
        }

        public static OrderViewDetailsModel MapToDetailsViewModel (this Order order)
        {
            return new OrderViewDetailsModel
            {
                Id = order.Id,
                Burgers = order.Burgers,
                FullName = order.FullName,
                MyLocation = order.MyLocation,
                TotalPrice = order.Burgers.Select(x=>x.Price).ToList().Sum()
                

            };
        }
    }
}
