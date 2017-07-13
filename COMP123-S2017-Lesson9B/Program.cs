using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Gabriel Norman
 * Date: July 11, 2017
 * Description: Lab 24 for Comp123
 * Version: 0.2 Created the Supervillian class and the IHasMaliceClass
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

           /* SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            superHero.AddPower("Invisibility", 40);
            superHero.AddPower("Super strength", 40);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma:" + superHero.Karma); */
        }
    }
}