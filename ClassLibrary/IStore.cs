using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    interface IStore
    {
        Product[] Products { get; }
        int ProductLimit { get; }
        int TotalIncome { get; }
        void AddProduct(Product product);
        void SellProduct(string no);






    }
}
