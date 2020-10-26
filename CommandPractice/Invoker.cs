using System.Collections.Generic;

public class Invoker {

    // public Invoker(ICommand on, ICommand off, ICommand up, ICommand down){
    //     this.on = on;
    //     this.off = off;
    //     this.up = up;
    //     this.down = down;cd
    // }

    // ICommand off;
    // ICommand up;
    // ICommand down;
    private ICommand onCommand;

    public Invoker(ICommand onCommand){
        this.onCommand = onCommand;
    }

    public void clickOn(){
        this.onCommand.execute();
    }

    public void clickOff(){
        this.onCommand.unexecute();
    }

    public void show(){
        this.onCommand.show();
    }    
}