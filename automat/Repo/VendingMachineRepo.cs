using automat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat.Repo
{
    internal class VendingMachineRepo:IVendingMachine
    {
        Queue<Product> Stock = new Queue<Product>();
        int _coinStoage;
        Dictionary<string, Product> _produtPlacement;
        int CoinStoage
        {
            get { return _coinStoage; }
            set { _coinStoage = value; }
        }
        Dictionary<string, Product> ProdutPlacement
        {
            get { return _produtPlacement; }
            set { _produtPlacement = value; }
        }








        
        public void RestockCoinStoage(int newcoin)
        {
            CoinStoage += newcoin;
        }
        public int EmptyCoinStoage()
        {
            int CoinsGained = CoinStoage;
            CoinStoage = 0;
            return CoinsGained;
        }
        public int Buy(string product, int coin)
        {
            if (ProdutPlacement.ContainsKey(product))
            {

            }
            int leftOverCoin = 0;
            return leftOverCoin;
        }
        public void Restock()
        {

        }
        public void addProduct(string newProductName, int newProductPrise)
        {

            Product productSemiPlacement = new Product(newProductPrise, newProductName);
            ProdutPlacement.Add("12e", productSemiPlacement);
        }
        

        public VendingMachineRepo()
        {
            CoinStoage = 0;
            ProdutPlacement = new Dictionary<string, Product>();
            ProdutPlacement.Add("a1", new Product( 20, "faxe"));
            ProdutPlacement.Add("a2", new Product(20, "cola"));
            ProdutPlacement.Add("a3", new Product(20, "ice tea"));
            ProdutPlacement.Add("a4", new Product(2, "monster"));
        }
    }
}
