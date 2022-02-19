using System;

namespace Animal {
  public class AnimalTester {
    public static void Main(String[] args){
      DomesticDog[] dog_array = new DomesticDog[5];
      
      dog_array[0] = new GuardDog("Spike", "Devil");
      dog_array[1] = new LapDog("Love", "Bug");
      
      dog_array[0].wagTail();
      dog_array[1].wagTail();
    
    } // end main
  } // end class
} // end namespace