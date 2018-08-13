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
            string APPID = "";
            string APIKey = "";
            Hall9001 objHall9001 = new Hall9001("http://profitfy.trade/",APPID,APIKey);
            bool Sucess;
            //Retorna os pares negociados na Profitfy
            var Markets = objHall9001.Markets(out Sucess);
            
            //Cria Ordem de Compra no par BRL-BTC
            var NewBuyOrder = objHall9001.CreateOrderBuy("BRL", "BTC", 1m, 10m,out  Sucess);

            //Retorna Lista de Ordens de compra
            //Informar o numero da ordem no primeiro parâmetro
            //Caso o parâmetro = NULL retorna todas as ordens de compra do usuário
            var ListBuyOrders = objHall9001.GetOrderBuy(null, out Sucess);


            //Cancela Ordens de compra
            //Informar o numero da ordem no primeiro parâmetro
            //Caso o parâmetro = NULL cancela todas as ordens de compra do usuário
            var DeleteBuyOrders = objHall9001.DeleteOrderBuy(null, out Sucess);
            Console.ReadLine();
        }
    }
}
