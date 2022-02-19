using System;


  public class LapDog : DomesticDog {
     public LapDog(String f_name, String l_name):base(f_name, l_name){
       Console.WriteLine("LapDog object created.");
     }
     
     public override void wagTail(){
        Console.WriteLine("The LapDog wags his tail real nice!");
     }

  } // end class
