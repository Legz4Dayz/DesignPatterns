public class RoundedShapeFactory : AbstractFactory
{

    public Shape getShape(string shapeType)
    {
        if(shapeType.Equals("RECTANGLE")){
            return new RoundedRectangle();
        }
        else if(shapeType.Equals("SQUARE"))
            return new RoundedSquare();
        else
            return null;
    }
}