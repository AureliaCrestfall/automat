using automat.Model;
using automat.Repo;
using automat.Sevice;

namespace automat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachineRepo vendingRepo = new VendingMachineRepo();
            VendingmachineService vendingservice = new VendingmachineService(vendingRepo);

            //Dictionary<string, Dictionary<Product, Queue<Product>>> vender = new Dictionary<string, Dictionary<Product, Queue<Product>>>();
            //vendingservice.RestockCoinStoage(200);
            //vendingservice.RestockCoinStoage(200);
            //vender.Add("a1", new Dictionary<Product, Queue<Product>>());
            //vender["a1"].Add(new Product(20, "faxe"),new Queue<Product>());
            //vender["a1"][new Product(20, "faxe")].Enqueue(new Product(20,"faxe"));
            //Console.WriteLine(vendingservice.EmptyCoinStoage());
          



            ////draw vendingmachine
            Console.Write("enter witch product you want: ");
            string choois = Console.ReadLine();
            Console.Write("enter coins: ");
            bool unpaid = false;


            while (unpaid == false)
            {
                try
                {
                    int coin = int.Parse(Console.ReadLine());
                    vendingservice.Buy(choois,coin);

                }
                catch
                {
                    Console.Write("error was not a coin please enter a coin: ");
                }
            }





        }
    }
}
