using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_6
{
   public class Program
    {
        static void Main(string[] args)
        {

            Lunch lunch1, lunch2, lunch3, lunch4, lunch5;
            lunch1 = new Lunch();
            lunch2 = new Lunch();
            lunch3 = new Lunch();
            lunch4 = new Lunch();
            lunch5 = new Lunch();

            lunch1.Main = "hamburger";
            lunch1.Side = "fries";
            lunch1.Drink = "cola";


            lunch2.Main = "hot dog";
            lunch2.Side = "chips";
            lunch2.Drink = "lemonade";

            lunch3.Main = "pizza";
            lunch3.Side = "salad";
            lunch3.Drink = "ice tea";

            lunch4.Main = "tuna sandwich";
            lunch4.Side = "fruit cup";
            lunch4.Drink = "water";

            lunch5.Main = "PB Sandwich";
            lunch5.Side = "cookie";
            lunch5.Drink = "milk";

            Display(lunch1, lunch2, lunch3);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4, lunch5);
        }

        static void Display(params Lunch[] lunches)
        {
            Console.WriteLine("{0, -24}{1, -12}{2, -10}",
                "Main", "Side", "Drink", "Color", "Value");
            foreach( Lunch lunch in lunches)
            {
                Console.WriteLine("{0, -24}{1, -12}{2, -10}",
                    lunch.Main, lunch.Side, lunch.Drink);
            }
        }
            


        }
    }

