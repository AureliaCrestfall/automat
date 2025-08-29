using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat
{
    internal class VendingMachine
    {
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
            CoinStoage = CoinStoage + newcoin;
        }
        public int EmptyCoinStoage()
        {
            int CoinsGained = CoinStoage;
            CoinStoage = 0;
            return CoinsGained;
        }
        public int Buy(string product,int coin)
        {
            int  leftOverCoin= 0;
            return leftOverCoin;
        }
        public void Restock()
        {

        }
        public void addProduct()
        {

        }

        public VendingMachine()
        {
            CoinStoage = 0;
            ProdutPlacement = new Dictionary<string, Product>();
        }


    }
}
