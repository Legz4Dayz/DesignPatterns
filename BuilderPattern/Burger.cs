public abstract class Burger : Item {

    public Packing packing(){
        return new Wrapper();
    }

    public abstract string name();

    public abstract float price();
}