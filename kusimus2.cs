using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class kusimus2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("kirjuta cm1 sein");
            decimal cm1 = Math.Abs(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("kirjuta cm2 sein2");
            decimal cm2 = Math.Abs(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Põranda pindala");
            Console.WriteLine(cm1*cm2+"cm2");
            Console.WriteLine("Kas tahad remonti teha");
            string otvet = Console.ReadLine();
            if(otvet=="jah")
            {
                Console.WriteLine("Kui palju maksab üks suur ruut meetri hind");
                decimal hind = decimal.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(hind * ((cm1/100) * (cm2/100)),2 )+ "- summa");
            }
            else
            {
                Console.WriteLine("Head aega");

            }




            Console.WriteLine("kirjuta temperatuur");
            decimal temp = decimal.Parse(Console.ReadLine());
            if(temp <18)
            {
                Console.WriteLine(temp + "see väike temperatuur");

            }
            else if(temp==18)
            {
                Console.WriteLine(temp + "see suur temperatuur");
            }
            else if (temp==18)
            {
                Console.WriteLine(temp + "see normaalne temperatuur");
            }




            Console.WriteLine("\n what is your height in centimeters");
            int height = int.Parse(Console.ReadLine());
            if (height<50 && height>300)
            {
                Console.WriteLine(temp + "error");

            }
            else if (height< 100 && height > 49)
            {
                Console.WriteLine(temp + "you are small");
            }
            else if (height <200 && height >99)
            {
                Console.WriteLine(temp + "you are average");
            }
            else
            {
                Console.WriteLine("You are tall");
            }












            Console.ReadLine();
        }
    }
}
