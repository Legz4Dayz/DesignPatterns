
public class TakesInterface {

    Interface1 interface1; 
    public TakesInterface(Interface1 o )
    {
        this.interface1 = o;
    }

    public int printInterface1(){
        return interface1.test1();
    }

}