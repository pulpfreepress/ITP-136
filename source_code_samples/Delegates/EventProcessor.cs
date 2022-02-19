using System;

public class EventProcessor {
  
  private delegate void ButtonHandlerDelegate();
  
  public void Button1Handler(){
    Console.WriteLine("The button handler works!");
  }
  
  public Delegate ButtonHandlerDelegateProperty {
     get { return new ButtonHandlerDelegate(this.Button1Handler); }
  }
  

}