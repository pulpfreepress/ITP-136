using System;

namespace Animal {
  public class GuardDog : DomesticDog {
     public GuardDog(String f_name, String l_name):base(f_name, l_name){
       Console.WriteLine("GuardDog object created.");
     }
     
     public override void wagTail(){
        Console.WriteLine("The GuardDog wags his tail mean!");
     }

  } // end class
} //end namespace