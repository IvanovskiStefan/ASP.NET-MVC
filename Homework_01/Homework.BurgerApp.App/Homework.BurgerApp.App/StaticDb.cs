using Homework.BurgerApp.App.Models.Domain;

namespace Homework.BurgerApp.App
{
    public class StaticDb
    {

        public static List<Burger> Burgers = new()

        {
            new Burger(200,"Delicatess",false,false,true),
            new Burger(400,"UltraSpecialBurger",true,true,true),
            new Burger(150,"HotDog",false,false,true),
            new Burger(600,"MediumHeartAttack",false,false,true)

        };

        public static List<Order> Orders = new()
        {
            new Order(1,"Stefan Ivanovski","Ul.Makarska",false,new List<Burger>(){Burgers[0],Burgers[1],Burgers[3] },"Kisela Voda"),
            new Order(2,"Valentino Rossi","Ul.RacingStreet",true,new List<Burger>(){Burgers[1],Burgers[3] },"MIlano"),
            new Order(3,"Batule Batulkovski","Ul.Batulevska",true,new List<Burger>() { Burgers[3], Burgers[3], Burgers[3] },"Batuleee")

        };
    };
}
