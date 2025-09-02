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


            vendingservice.RestockCoinStoage(200);
            vendingservice.RestockCoinStoage(200);
            
            Console.WriteLine(vendingservice.EmptyCoinStoage());
            

            ////draw vendingmachine
            //Console.Write("enter witch product you want: ");
            //string choois = Console.ReadLine();
            //Console.Write("enter coins: ");
            //bool unpaid = false;


            //while (unpaid == false)
            //{
            //    try
            //    {
            //        int coin = int.Parse(Console.ReadLine());
            //        unpaid = true;
            //    }
            //    catch
            //    {
            //        Console.Write("error was not a coin please enter a coin: ");
            //        unpaid = false;
            //    }
            //}
        }
    }
}
