using automat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat.Repo
{
    internal interface IVendingMachine
    {

        Dictionary<string, Queue<Product>> GetAll();

        void RestockCoinStoage(double newcoin);

        double EmptyCoinStoage();

        Product Buy(string product, double coin);
        
        void Restock(string productPlace);
       
        void AddProduct(string newProductName, double newProductPrise, string productPlace);


    }
}
