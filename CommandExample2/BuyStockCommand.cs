public class BuyStockCommand : IOrderCommand {
   private StockReciever abcStock;

   public BuyStockCommand(StockReciever abcStock){
      this.abcStock = abcStock;
   }

   public void execute() {
      abcStock.buy();
   }
}