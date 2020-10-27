public class Circle : AbstractShape
{
    private int x, y, radius;

    public Circle(int x, int y, int radius, DrawAPI drawAPI) : base(drawAPI)
    {                                // the drawAPI instance is protected by the abstract class DrawAPI
        this.x = x;
        this.y = y;
        this.radius = radius;
    }
    
    public override void draw()
    {
        drawAPI.drawCircle(radius, x, y);
    }
}