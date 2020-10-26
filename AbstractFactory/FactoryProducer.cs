public class ShapeFactoryProducer {

    public static AbstractFactory getRoundedFactory(bool rounded){
        if(rounded)
            return new RoundedShapeFactory();
        else
            return new ShapeFactory();
    }
}
