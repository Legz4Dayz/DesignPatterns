using System;

public class StockReciever {
       private string Name = "ABC";
   private int Quantity = 10;

   public StockReciever(String name, int quantity){
       this.Name = name;
       this.Quantity = quantity;
   }

   public void buy(){
      Console.WriteLine($"Stock Name: {Name} Quantity: {Quantity} bought" );
   }
   public void sell(){
      Console.WriteLine($"Stock Name: {Name} Quantity: {Quantity} sold");
   }

}