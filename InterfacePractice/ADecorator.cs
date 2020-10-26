public class ADecorator : A
{
    A Aclass;
    public ADecorator(A a)
    {
        this.Aclass = a;
    }

    public override int test1(){
        return Aclass.test1() + 10;
    }
}