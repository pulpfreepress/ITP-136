using System;

public class DerivedClass : BaseClass {

  public void MethodC(){
    Console.WriteLine("Method C, calling base.MethodB()");
    MethodB();
  }

}