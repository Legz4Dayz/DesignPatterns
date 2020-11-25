using System;

namespace CommandExample2
{
    class Program
    {
        static void Main(string[] args)
        {

        StockReciever IBMStock = new StockReciever("IBM", 20);
        StockReciever GoogleStock = new StockReciever("Google", 10);

        BrokerInvoker BrokerInvoker = new BrokerInvoker();
        
        BrokerInvoker.takeIOrderCommand(new BuyStockCommand(IBMStock));
        BrokerInvoker.takeIOrderCommand(new SellStockCommand(GoogleStock));
        BrokerInvoker.placeIOrderCommands();
        }
    }
}
