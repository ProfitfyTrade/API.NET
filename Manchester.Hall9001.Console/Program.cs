using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manchester.Hall9001.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hall9001 objHall9001 = new Hall9001("http://profitfy.trade/");
            bool Sucess;
            var Markets = objHall9001.Markets(out Sucess);
            Console.ReadLine();
        }
    }
}
