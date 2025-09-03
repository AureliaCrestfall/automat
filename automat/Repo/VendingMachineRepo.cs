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
        Dictionary<string, Queue<Product>> _produtPlacements;
        Dictionary<string, Product> _products;
        double _leftOverCoin;
        
        double LeftOverCoin
        {
            get{ return _leftOverCoin; }
            set { _leftOverCoin = value; }
        }
        
        Dictionary<string, Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }
        double coinStoage
        {
            get { return _coinStoage; }
            set { _coinStoage = value; }
        }
        public Dictionary<string, Queue<Product>> ProdutPlacements
        {
            get { return _produtPlacements; }
            set { _produtPlacements = value; }
        }
        /// <summary>
        ///  Method for getting all of the contents for the dictionary 
        /// </summary>
        /// <returns>returns the dictionary ProdutPlacement </returns>
        public Dictionary<string, Product> GetAll()
        {
            return Products;
        }
        /// <summary>
        /// method for getting back change from the Buy method
        /// </summary>
        /// <returns> returns change as a double</returns>
        public Double GetChange()
        {
            double change = LeftOverCoin;
            _leftOverCoin = 0;

            return change;
        }
        /// <summary>
        /// Method for filling CoinStoage with newcoin
        /// </summary>
        /// <param name="newcoin">the variable that gets added to coinStoage</param>
        public void RestockCoinStoage(double newcoin)
        {
            coinStoage += newcoin;
        }
        /// <summary>
        /// empties Coinstoage and returns the values as coinsGained
        /// </summary>
        /// <returns> returns coinsGained as a double</returns>
        public double EmptyCoinStoage()
        {
            double coinsGained = coinStoage;
            coinStoage = 0;
            return coinsGained;
        }
        /// <summary>
        /// handles buying products by using the param product to location the product as the key value
        /// and coin as the payment for the product and then putting the left over double in _leftOverCoin
        /// for the use of the GetChange method and then returning a prodct by dequeueing the dictionary
        /// else if the dictionary doesn't conntain the key value it reurns null
        /// </summary>
        /// <param name="product"> for finding the kay value in dictionary</param>
        /// <param name="coin"> for calculating the what value should go into _leftOverCoin by - coin and the price for the product in queue</param>
        /// <returns>returns a product unless the kay value dosn't exists</returns>
        public Product Buy(string product, double coin)
        {
            Product buyPlaceholder = ProdutPlacements[product].Peek();

            if (ProdutPlacements.ContainsKey(product))
            {
                coin -= buyPlaceholder.Pris;
                _leftOverCoin = coin;
                _coinStoage += buyPlaceholder.Pris;

                return ProdutPlacements[product].Dequeue();

            }
            return null;

        }
        /// <summary>
        /// method for restocking the queue in the dictionary when called enqueues the product
        /// at the key value productPlace until their is 10 of them in the queue using the Products dictionary 
        /// to make sure that the correct product is enqueued in the queue
        /// </summary>
        /// <param name="productPlace">for finding the kay value in the dictionaries</param>
        public void Restock(string productPlace)
        { 
               while(ProdutPlacements[productPlace].Count() >= 10) 
               {
                    ProdutPlacements[productPlace].Enqueue(Products[productPlace]);
               }
        }
        /// <summary>
        /// adds a product to the dictionary ProdutPlacements by using newProductName and newProductPrise to create a new object
        /// the adding the object to Products using productPlace as the kay value and then enqueueing it ind
        /// ProductPlacements using the same key value as before
        /// if ProdutPlacements already contains a key value of productplace then it just enqueues the producr
        /// ind that queue
        /// </summary>
        /// <param name="newProductName">for the name of the new product</param>
        /// <param name="newProductPrise">for the pris of the new product</param>
        /// <param name="productPlace">for the use of a key value</param>
        public void AddProduct(string newProductName, double newProductPrise,string productPlace)
        {
            Product productSemiPlacement = new Product(newProductPrise, newProductName);

            if (ProdutPlacements.ContainsKey(productPlace))
            {
                ProdutPlacements[productPlace].Enqueue(productSemiPlacement);
            }
            else
            {
                Products.Add(productPlace, productSemiPlacement);
                ProdutPlacements.Add(productPlace, new Queue<Product>());
                ProdutPlacements[productPlace].Enqueue(productSemiPlacement);
            }
        }
        
        
        public VendingMachineRepo()
        {
            coinStoage = 0;
            ProdutPlacements = new Dictionary<string, Queue<Product>>();
            ProdutPlacements.Add("a1", new Queue<Product>());
            ProdutPlacements.Add("a2", new Queue<Product>());
            ProdutPlacements.Add("a3", new Queue<Product>());
            ProdutPlacements.Add("a4", new Queue<Product>());
            Products = new Dictionary<string, Product>();
            Products.Add("a1", new Product(5, "faxe"));
            Products.Add("a2", new Product(20, "ice tea"));
            Products.Add("a3", new Product(8, "cola"));
            Products.Add("a4", new Product(2, "monster"));
            ProdutPlacements["a1"].Enqueue(Products["a1"]);
            ProdutPlacements["a1"].Enqueue(Products["a1"]);
            ProdutPlacements["a2"].Enqueue(Products["a2"]);
            ProdutPlacements["a3"].Enqueue(Products["a3"]);
            ProdutPlacements["a4"].Enqueue(Products["a4"]);
        }
    }
}
