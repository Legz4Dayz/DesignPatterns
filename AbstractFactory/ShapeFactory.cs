public class ShapeFactory : AbstractFactory
{

    public Shape getShape(string shapeType)
    {
        if(shapeType.Equals("RECTANGLE")){
            return new Rectangle();
        }
        else if(shapeType.Equals("SQUARE"))
            return new Square();
        else
            return null;
    }
}