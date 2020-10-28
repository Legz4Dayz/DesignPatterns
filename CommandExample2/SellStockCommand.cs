public class SellStockCommand : IOrderCommand {
   private StockReciever abcStock;

   public SellStockCommand(StockReciever abcStock){
      this.abcStock = abcStock;
   }

   public void execute() {
      abcStock.sell();
   }
}