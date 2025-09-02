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
       

        public Product(double pris, string name)
        {
            Pris = pris;
            Name = name;
    
        }

    }
}
