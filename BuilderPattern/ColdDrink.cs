public abstract class ColdDrink : Item
{
    public Packing packing()
    {
        return new Bottle();        
    }
    public abstract string name();

    public abstract float price();
}