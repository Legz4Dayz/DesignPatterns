public abstract class AbstractShape {
    protected DrawAPI drawAPI;                  //Cannot be accessed

    protected AbstractShape(DrawAPI drawAPI)    //Cannot be accessed 
    {
        this.drawAPI = drawAPI;
    }

    public abstract void draw();
}