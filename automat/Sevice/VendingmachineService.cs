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

        /// <summary>
        /// uses the Getall and Peek method to check if their is a high enough value in coin to beable to make the
        /// purchase before calling the buy method in VendingMachineRepo and then returning a product else it returns null
        /// </summary>
        /// <param name="product">for use as a key value to locate the product</param>
        /// <param name="coin">for use to be able to pay if the value is high enough</param>
        /// <returns>returns a product</returns>
        public Product Buy(string product, double coin)
        {
            Dictionary<string, Product> buyDictionary = _vendingMahince.GetAll();
            Product itembuying = buyDictionary[product];
            Console.WriteLine(itembuying);
            if (coin >= itembuying.Pris)
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
       
        public Double GetChange()
        {
            return _vendingMahince.GetChange();
        }
        
       public Dictionary<string, Product> GetAll()
        {
            return _vendingMahince.GetAll();
        }




    }
}
