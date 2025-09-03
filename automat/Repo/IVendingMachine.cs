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
        /// <summary>
        /// contract for vendingmachineRepo so it has to include the following metodes
        /// </summary>

        Dictionary<string, Product> GetAll();
        void RestockCoinStoage(double newcoin);
        double EmptyCoinStoage();
        Double GetChange();
        Product Buy(string product, double coin);
        void Restock(string productPlace);
        void AddProduct(string newProductName, double newProductPrise, string productPlace);


    }
}
