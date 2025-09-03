using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat.Model
{
    internal class Product
    {
        /// <summary>
        /// class for creation of products for the vending machine
        /// </summary>
        string _name;
        double _pris;
        /// <summary>
        /// instanciring of variables
        /// </summary>
       public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
       public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }
       
/// <summary>
/// unchanined constorter for product
/// </summary>
/// <param name="pris"> for assinging a price to the object</param>
/// <param name="name">for assinging a name to the object</param>
        public Product(double pris, string name)
        {
            Pris = pris;
            Name = name;
    
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
