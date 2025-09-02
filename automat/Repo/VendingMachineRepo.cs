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
        double _coinStoage;
        Dictionary<string, Queue<Product>> _produtPlacement;
        Dictionary<string, Product> _products;
        Dictionary<string, Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }


        double CoinStoage
        {
            get { return _coinStoage; }
            set { _coinStoage = value; }
        }
        public Dictionary<string, Queue<Product>> ProdutPlacement
        {
            get { return _produtPlacement; }
            set { _produtPlacement = value; }
        }
        public Dictionary<string, Queue<Product>> GetAll()
        {
            return ProdutPlacement;
        }

        public void RestockCoinStoage(double newcoin)
        {
            CoinStoage += newcoin;
        }
        public double EmptyCoinStoage()
        {
            double CoinsGained = CoinStoage;
            CoinStoage = 0;
            return CoinsGained;
        }
        public Product Buy(string product, double coin)
        {
            Product buyPlaceholder = ProdutPlacement[product].Peek();

            if (ProdutPlacement.ContainsKey(product))
            {
                coin -= buyPlaceholder.Pris;
                _coinStoage += buyPlaceholder.Pris;
                return ProdutPlacement[product].Dequeue();

            }
            return null;

        }
        public void Restock(string productPlace)
        {
            try
            {
                Product RestockPlaceholder = ProdutPlacement[productPlace].Peek();
                if (ProdutPlacement[productPlace].Count() >= 10)
                {
                    ProdutPlacement[productPlace].Enqueue(Products[productPlace]);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            

        }
        public void AddProduct(string newProductName, double newProductPrise,string productPlace)
        {
            Product productSemiPlacement = new Product(newProductPrise, newProductName);

            if (ProdutPlacement.ContainsKey(productPlace))
            {
                ProdutPlacement[productPlace].Enqueue(productSemiPlacement);
            }
            else
            {
                Products.Add(productPlace, productSemiPlacement);
                ProdutPlacement.Add(productPlace, new Queue<Product>());
                ProdutPlacement[productPlace].Enqueue(productSemiPlacement);
            }
        }
        

        public VendingMachineRepo()
        {
            CoinStoage = 0;
            ProdutPlacement = new Dictionary<string, Queue<Product>>();
            ProdutPlacement.Add("a1", new Queue<Product>());
            ProdutPlacement.Add("a2", new Queue<Product>());
            ProdutPlacement.Add("a3", new Queue<Product>());
            ProdutPlacement.Add("a4", new Queue<Product>());
            Products = new Dictionary<string, Product>();
            Products.Add("a1", new Product(5, "faxe"));
            Products.Add("a2", new Product(20, "ice tea"));
            Products.Add("a3", new Product(8, "cola"));
            Products.Add("a4", new Product(2, "monster"));
            ProdutPlacement["a1"].Enqueue(Products["a1"]);
            ProdutPlacement["a2"].Enqueue(Products["a2"]);
            ProdutPlacement["a3"].Enqueue(Products["a3"]);
            ProdutPlacement["a4"].Enqueue(Products["a4"]);
        }
    }
}
