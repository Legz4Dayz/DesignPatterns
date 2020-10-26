using System;

public class Light {

    bool Status = false;
    public void on(){
        this.Status = true;
        Console.WriteLine("Test on: " + Status);
    }

    public void off(){
        this.Status = false;
        Console.WriteLine("Test off: " + Status);
    }

    public void showLight() => Console.Write("Show Light: " + Status);
}