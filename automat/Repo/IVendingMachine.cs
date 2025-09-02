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
       
       
        
        void RestockCoinStoage(int newcoin);

        int EmptyCoinStoage();

        int Buy(string product, int coin);
        
        void Restock();
       
        void addProduct();


    }
}
