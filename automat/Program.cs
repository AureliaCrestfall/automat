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




            Console.WriteLine("here is a list of the current items we have");

            foreach (KeyValuePair<string, Product> kv in vendingmachine)
            {
                vendingservice.Restock(kv.Key);
                string place = kv.Key;

                Console.WriteLine("place " + kv.Key + " "+ vendingmachine[place]+ " price "+ vendingmachine[place].Pris+" coins");

            }
            vendingmachine = vendingservice.GetAll();
           
            
 

            
            bool unpaid = false;


            while (unpaid == false)
            {
                Console.Write("enter witch product you want: ");
                string choois = Console.ReadLine();
                Console.Write("enter coins: ");
                int coin = int.Parse(Console.ReadLine());

                    Console.WriteLine(vendingservice.Buy(choois, coin)+" obtained");
                    Console.WriteLine("you get "+vendingservice.GetChange()+" coins back");


                Console.Write("type 1 if you wish to buy more from the vending machine: ");
                try
                {
                    string continu = Console.ReadLine();
                    if(continu != "1")
                    {
                        unpaid = true;
                    }
                }
                catch
                {
                    Console.WriteLine("thank you for using the vending machine");
                }
                
            }





        }
    }
}
