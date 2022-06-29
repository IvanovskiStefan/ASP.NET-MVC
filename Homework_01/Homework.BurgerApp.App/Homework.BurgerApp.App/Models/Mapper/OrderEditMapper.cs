using Homework.BurgerApp.App.Models.Domain;
using Homework.BurgerApp.App.Models.ViewModels;

namespace Homework.BurgerApp.App.Models.Mapper
{
    public static class OrderEditMapper
    {
        public static OrderEditViewModel MapToOrderViewEditModel(this Order order)
        {
            return new OrderEditViewModel { 
                Burgers = order.Burgers, 
                FullName = order.FullName, 
                IsDelivered = order.IsDelivered,
                             
                    
            };
        }
    }
}
