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
        public void RestockCoinStoage(double newcoin)
        {
            _vendingMahince.RestockCoinStoage(newcoin);
        }

        public double EmptyCoinStoage()
        {
            return _vendingMahince.EmptyCoinStoage();
        }
        

        public Product Buy(string product, double coin)
        {
            Dictionary<string, Queue<Product>> buyDictionary = _vendingMahince.GetAll();
            Product itembuying = buyDictionary[product].Peek();
            if (coin >= itembuying.Pris && buyDictionary[product].Count !<=0)
            {
                return _vendingMahince.Buy(product, coin);

            }
            else
            {
                return null;
            }
        }

        public void Restock(string productPlace)
        {
            _vendingMahince.Restock(productPlace);
        }

        public void addProduct(string newProductName, double newProductPrise, string productPlace)
        {
            _vendingMahince.AddProduct( newProductName, newProductPrise,productPlace);
        }
       
    }
}
