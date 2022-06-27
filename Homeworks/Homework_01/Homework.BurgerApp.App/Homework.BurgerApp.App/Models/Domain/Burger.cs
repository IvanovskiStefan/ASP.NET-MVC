namespace Homework.BurgerApp.App.Models.Domain
{
    public class Burger
    {
        public int Id { get; set; }
        public int Price   { get; set; }
        public string Name { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

        public Burger(int price, string name, bool isVegetarian, bool isVegan, bool hasFries)
        {
            Price = price;
            Name = name;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;
            HasFries = hasFries;
        }
    }
}
