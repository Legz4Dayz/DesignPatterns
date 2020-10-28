public class LightOnCommand : ICommand  // ICommand instance passed in demo 
{
    Light receivedLight; 
    public LightOnCommand(Light l){
        this.receivedLight= l;
    }
    public void execute()
    {
        for(int i = 0; i < 20; i++)
        {
            this.receivedLight.on();
            this.receivedLight.off();        
        }
    }

    public void unexecute()
    {
        this.receivedLight.off();
    }

    public void show() => this.receivedLight.showLight();
}