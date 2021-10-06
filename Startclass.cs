using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Startclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            if(eesnimi.ToLower()=="Juku")
            {
                Console.WriteLine("Tule minu juurde külla! Lähme kinno! Kui vana sa oled?{ }",eesnimi);
                int vanus = int.Parse(Console.ReadLine());
                if (vanus < 0 ||  vanus>=120)
                {
                    Console.WriteLine("Viga andmetega!");

                }
                else if(vanus<=6)
                {
                    Console.WriteLine("Tasuta pilet!");
                }
                else if(vanus>6 && vanus<=14)
                {
                    Console.WriteLine("Lastepilet!");
                }
                else if (vanus <=15)
                {
                    Console.WriteLine("Täispilet!");
                }
                else if (vanus >65)
                {
                    Console.WriteLine("sooduspilet!");
                }

            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }

            
            int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);



            Console.WriteLine("Tere, sisestage esimene nimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, sisestage teine nimi");
            string eesnimi2 = Console.ReadLine();
            if (eesnimi.ToLower() == "Daria" && eesnimi2.ToLower()=="natasha")
            {
                Console.WriteLine("Te olete pinginaabrid")
            }
 





                Console.ReadLine();
        }
    }
}
