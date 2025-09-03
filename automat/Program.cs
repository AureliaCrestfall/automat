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

          

            Dictionary<string, Product> vendingmachine = vendingservice.GetAll();


            



            foreach (KeyValuePair<string, Product> kv in vendingmachine)
            {
                vendingservice.Restock(kv.Key);
                string place = kv.Key;

                Console.WriteLine("place" + kv.Key + "item" + vendingmachine[place]);

            }
            vendingmachine = vendingservice.GetAll();
            foreach (KeyValuePair<string, Product> kv in vendingmachine)
            {
            }
            Console.WriteLine(vendingservice.Buy("a1", 200));
            Console.WriteLine("change got" +vendingservice.GetChange());
 

            //draw vendingmachine
            
            bool unpaid = false;


            while (unpaid == false)
            {
                Console.Write("enter witch product you want: ");
                string choois = Console.ReadLine();
                Console.Write("enter coins: ");
                int coin = int.Parse(Console.ReadLine());

                    Console.WriteLine(vendingservice.Buy(choois, coin));
                    Console.WriteLine(vendingservice.GetChange());


              
            }





        }
    }
}
