using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat.Model
{
    internal class Product
    {
        string _name;
        double _pris;
        Queue<Product> _stock;

        string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }
        Queue<Product> Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public void ChangePris(double newPris)
        {
            Pris = newPris;
        }

        public Product(double pris, string name)
        {
            Pris = pris;
            Name = name;
    
        }

    }
}
