
using System.Collections.Generic;

public class BrokerInvoker {       //THE INVOKER
   private List<IOrderCommand> IOrderCommandList = new List<IOrderCommand>(); 

   public void takeIOrderCommand(IOrderCommand IOrderCommand){
      IOrderCommandList.Add(IOrderCommand);		
   }

   public void placeIOrderCommands(){
   
      foreach(IOrderCommand IOrderCommand in IOrderCommandList) {
         IOrderCommand.execute();
      }
      IOrderCommandList.Clear();
   }
}