

using Homework.BurgerApp.App.Models.Domain;

namespace Homework.BurgerApp.App.Models.ViewModels
{
    public class OrderViewDetailsModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Burger> Burgers { get; set; }
        public double TotalPrice { get; set; }
        public string  MyLocation { get; set; }

    }
}
