using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Market : IStore
    {
        private Product[] _products = new Product[0];
        public Product[] Products 
        {   get => _products;
        }
        private int _productLimit = 3;
        public int ProductLimit { get => _productLimit; }

        private int _totalincome;
        public int TotalIncome { get => _totalincome; }

        public void AddProduct(Product product)
        {
            int counter = 0;
            if (_products.Length < ProductLimit)
            {
                for (int i = 0; i < _products.Length; i++)
                {
                    if (product.No == _products[i].No)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter != 0)
                    Console.WriteLine("Movcuddur");
                else
                {
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;

                }
            }
            else
                Console.WriteLine("Limit asildi!");
            


        }

        public void SellProduct(string no)
        {
            int counter = 0;
            for (int i = 0; i < _products.Length; i++)
            {
                if (no == _products[i].No)
                {
                    if (_products[i].Count != 0)
                    {
                        counter++;
                        _products[i].Count--;
                        _totalincome += _products[i].Price;
                        Console.WriteLine($"Mehsul sayi: {_products[i].Count} - Umumi gelir: {_totalincome}");
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Bu cur mehsulumuz yoxdur");
            }



        }
    }
}
