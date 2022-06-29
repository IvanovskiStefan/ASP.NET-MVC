namespace Homework.BurgerApp.App.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public bool IsDelivered { get; set; }
        public List<Burger> Burgers { get; set; }
        public string MyLocation { get; set; }

        public Order(int id,string fullName, string adress, bool isDelivered, List<Burger> burgers, string myLocation)
        {
            Id = id;
            FullName = fullName;
            Adress = adress;
            IsDelivered = isDelivered;
            Burgers = burgers;
            MyLocation = myLocation;
        }
        public Order()
        {

        }
    }


   
}
