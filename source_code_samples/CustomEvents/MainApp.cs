using System;

namespace CustomEventExample {

  public class MainApp {
   public static void Main(){
     Console.WriteLine("Custom Events are Cool!");
     
     Publisher p = new Publisher();
     Subscriber s = new Subscriber(p);
     p.countMinutes();
   
   } // end main
  } //end MainApp class definition
} // end CustomEventExample namespace 