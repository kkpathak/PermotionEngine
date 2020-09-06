using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermotionEngineProject
{
    public class ProductService
    {
        static void Main(string[] args)
        {
            
                List<Product> products = new List<Product>();
            
                 Console.WriteLine("Total number of order");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("Enter the type of product:A,B,C or D");
                    string type = Console.ReadLine();
                    Product p = new Product(type);
                    products.Add(p);
                }

                int totalPrice = GetTotalPrice(products);
                Console.WriteLine(totalPrice);
                Console.WriteLine("Press enter to exit the program");
                Console.ReadLine();
            }

             public static int GetTotalPrice(List<Product> products)
            {
                int counterOfA = 0;
                int priceofA = 50;
                int counterOfB = 0;
                int priceofB = 30;
                int counterOfC = 0;
                int priceofC = 20;
                int counterOfD = 0;
                int priceofD = 15;
                int fixPriceCPlusD = 30;
                foreach (Product pr in products)
                {
                switch (pr.Id)
                {
                    case "A":
                    case "a":
                        counterOfA += 1;
                        break;
                    case "B":
                    case "b":
                        counterOfB += 1;
                        break;
                    case "C":
                    case "c":
                        counterOfC += 1;
                        break;
                    case "D":
                    case "d":
                        counterOfD += 1;
                        break;
                }
            }
                int totPriceofCD;
                int totalPriceofA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceofA);
                int totalPriceofB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceofB);
                if (counterOfC == 1 && counterOfD == 1)
                {
                    totPriceofCD = fixPriceCPlusD;
                }
                else
                {
                    totPriceofCD = (counterOfC * priceofC) + (counterOfD * priceofD);
                }

                        return totalPriceofA + totalPriceofB + totPriceofCD;

            }
        }
    }

