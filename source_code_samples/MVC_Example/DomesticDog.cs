using System;


  public abstract class DomesticDog : Animal, TailWagger {
  
    public DomesticDog(String f_name, String l_name):base(f_name, l_name){
      Console.WriteLine("DomesticDog object created.");
    }
    
    
    public abstract void wagTail();
  
  } // end class
