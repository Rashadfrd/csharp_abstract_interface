using System;
using ClassLibrary;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Market Libraff = new Market();



            int input;
            do
            {
                Console.WriteLine("1.Product elave et");
                Console.WriteLine("2.Product sat");
                Console.WriteLine("3.Productlara bax");
                Console.WriteLine("4.Menudan cix");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        if (input == 1)
                        {
                            Console.WriteLine("Productin adini daxil edin:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Productin sayini daxil edin:");
                            int count = int.Parse(Console.ReadLine());
                            Console.WriteLine("Productin qiymetini daxil edin:");
                            int price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Productin nomresini daxil edin:");
                            string no = Console.ReadLine();

                            Product product  = new Product
                            {
                                Name = name,
                                Price = price,
                                No = no,
                                Count = count
                            };

                            Libraff.AddProduct(product);
                            foreach (var item in Libraff.Products)
                            {
                                Console.WriteLine($"Name: {item.Name} - Price: {item.Price}");
                            }

                        }   
                        break;

                    case 2:
                        if (input == 2)
                        {
                            Console.WriteLine("Satmaq istediyiniz mehsulun no deyerini qeyd edin");
                            string no = Console.ReadLine();

                            Libraff.SellProduct(no);
                        }
                        break;
                    case 3:

                        foreach (var item in Libraff.Products)
                        {
                            Console.WriteLine($"Name: {item.Name} - Price: {item.Price} - No: {item.No} - Count: {item.Count} TotalIncome: {Libraff.TotalIncome}");
                        }



                        break;
                }

            } while (input != 4);
             
        }
    }
}
