using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automat.Repo;
using automat.Model;


namespace automat.Sevice
{
    internal class VendingmachineService
    {
        IVendingMachine _vendingMahince;
        public VendingmachineService(IVendingMachine repo)
        {
            _vendingMahince = repo;
        }
        public void RestockCoinStoage(int newcoin)
        {
            _vendingMahince.RestockCoinStoage(newcoin);
        }

        public int EmptyCoinStoage()
        {
            return _vendingMahince.EmptyCoinStoage();
        }

        public int Buy(string product, int coin)
        {
            return 1;
        }

        public void Restock()
        {

        }

        public void addProduct()
        {

        }
       
    }
}
