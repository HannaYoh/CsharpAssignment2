using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            
            
                Console.WriteLine("Choose an item");
                Console.WriteLine(" Item..........Price in birr");
                Console.WriteLine("1.Tea.........10 per bag");
                Console.WriteLine("2.Coffee......15 per bag");
                Console.WriteLine("3.Milk........20 per liter");
               
            do {
                Console.WriteLine("Enter correct choice");
                choice = Convert.ToInt32(Console.ReadLine());
            }while (choice != 1 && choice !=2 && choice !=3);

            double amount;
            
            
                Console.WriteLine("Enter amount per bag or liter");
                amount = Convert.ToDouble(Console.ReadLine());
            
                double beforevat = 0;
                if (choice == 1)
                {
                    beforevat = 10 * amount;
                }
                else if (choice == 2)
                {
                    beforevat = 15 * amount;
                }
                else
                {
                    beforevat = 20 * amount;
                }
                Console.WriteLine("Price before vat = " + beforevat);
            double vatAmount = beforevat * 0.15;
            Console.WriteLine("VAT = " + vatAmount);
            double aftervat = beforevat * 1.15;
                Console.WriteLine("Total price = " + aftervat);
                Console.ReadKey();
            
        }
    }
}
