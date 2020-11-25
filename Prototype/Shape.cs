using System;

public abstract class Shape : ICloneable {
  private string id;
  protected string type;

  public abstract void draw();

  public string getType(){
      return type;
  }

  public string getId(){
      return id;
  }

  public void setId(string id){
      this.id = id;
  }
   public object Clone(){
      Object clone = null;
      
      try{
          clone = base.MemberwiseClone();
      } catch(Exception e){
          Console.WriteLine(e.Data);
      }
      return clone;
  }   
}