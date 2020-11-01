using System.Collections.Generic;

public class Invoker {

    private List<ICommand> commandList = new List<ICommand>();
    public Invoker(List<ICommand> InputCommandList){
        this.commandList.AddRange(InputCommandList);
    }

    public void clickOn(){
        this.commandList.ForEach(x => x.execute());
    }

    public void clickOff(){
        this.commandList.ForEach(x => x.execute());
    }

    public void show(){
        this.commandList.ForEach(x => x.execute());
    }    
}