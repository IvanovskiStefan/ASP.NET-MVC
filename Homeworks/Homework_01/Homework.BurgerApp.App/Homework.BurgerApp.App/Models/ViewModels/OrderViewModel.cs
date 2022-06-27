using Homework.BurgerApp.App.Models.Domain;

namespace Homework.BurgerApp.App.Models.ViewModels
{
    public class OrderViewModel
    {
        public string FullName { get; set; }

        public bool IsDelivered { get; set; }

        public List<Burger> Burgers { get; set; }
    

    }
}
