using Homework.BurgerApp.App.Models.Domain;

namespace Homework.BurgerApp.App.Models.ViewModels
{
    public  class OrderViewEditModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public bool IsDelivered { get; set; }

        public List<Burger> Burgers { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
    }
}
