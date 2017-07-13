using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Gabriel Norman
 * Date: July 11, 2017
 * Description: Lab 24 for Comp123
 * Version: 0.3 Created the Supervillian object and populated it in the driver class
 */

namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            superHero.AddPower("Invisibility", 40);
            superHero.AddPower("Super strength", 40);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma:" + superHero.Karma);

            SuperVillian superVillian = new SuperVillian("Evil Dude", 40);
            superVillian.AddPower("Mocking the Elderly", 10);
            superVillian.AddPower("Loitering", 10);
            superVillian.AddPower("Eye Lasers", 40);
            superVillian.AddPower("Volcanic Sneeze", 50);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Malice:" + superVillian.Malice); 
        }
    }
}