using ATM.BLL.Implementation;
using ATM.BLL.Interfaces;
using ATM.BLL.Utility;

namespace ATM.UI
{
    public class Program
    {
        private static readonly IAtmService atmService = new AtmService(new AdminService());


        public static void Main()
        {
            Console.Title = "Gt Bank Atm Machine";
            atmService.Start();
            MainMethod.GetUserChoice();
        }

     
    }
}

