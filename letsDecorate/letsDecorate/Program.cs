using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Matt's Pizza");
            Console.WriteLine("Your current order contains:");
            Console.WriteLine("");
            Pizza pizza1 = new MajorMeats();
            Console.WriteLine(pizza1.getDescription()+ " $" + pizza1.cost());
            Console.WriteLine("----");

            Pizza pizza2 = new MattsFavorite();
            pizza2 = new GreenPeppers(pizza2);
            pizza2 = new ItalianSausage(pizza2);
            pizza2 = new Sausage(pizza2);
            pizza2 = new ItalianSausage(pizza2);
            pizza2 = new ArtichokeHearts(pizza2);
            Console.WriteLine(pizza2.getDescription() + " $" + pizza2.cost());
            Console.WriteLine("----");
            Pizza pizza3 = new TheWorks();
            pizza3 = new PortabelloMushrooms(pizza3);
            pizza3 = new KalmataOlives(pizza3);
            pizza3 = new BhutJolokiaPeppers(pizza3);
            pizza3 = new JalapenoPeppers(pizza3);
            pizza3 = new Pepperoni(pizza3);
            Console.WriteLine(pizza3.getDescription() + " $" + pizza3.cost());
            Console.WriteLine("----");

            Pizza pizza4 = new GardenVeggie();
            pizza4 = new ParmigianoReggianoCheese(pizza4);
            pizza4 = new PortabelloMushrooms(pizza4);
            pizza4 = new Onions(pizza4);
            pizza4 = new Bacon(pizza4);
            Console.WriteLine(pizza4.getDescription() + " $" + pizza4.cost());
            Console.WriteLine("----");

            Console.WriteLine("Press the m key to see the menu or any other key to exit.");
            string menuChoice = Console.ReadKey().Key.ToString();
            if (menuChoice=="M"){
                Console.Clear();
                Console.WriteLine("Welcome to Matt's Pizza");
                Console.WriteLine("We offer 4 pies:");
                Console.WriteLine("The Works - 18.99");
                Console.WriteLine("Major Meats - 17.99");
                Console.WriteLine("Matt's Favorite - 17.99");
                Console.WriteLine("Garden Veggie - 16.99");
                Console.WriteLine("");
                Console.WriteLine("Add any of our basic toppings for $0.55 each");
                Console.WriteLine("Green Peppers");
                Console.WriteLine("Onions");
                Console.WriteLine("Portabello Mushrooms");
                Console.WriteLine("Jalapeño Peppers");
                Console.WriteLine("");
                Console.WriteLine("Add any of our premium toppings for $0.85 each");
                Console.WriteLine("Bhut Jolokia Peppers");
                Console.WriteLine("Artichoke Hearts");
                Console.WriteLine("Kalmata Olives");
                Console.WriteLine("Parmigiano Reggiano Cheese");
                Console.WriteLine("");
                Console.WriteLine("Add extra meat for $1.00");
                Console.WriteLine("Pepperoni");
                Console.WriteLine("Sausage");
                Console.WriteLine("Italian Sausage");
                Console.WriteLine("Bacon");
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
