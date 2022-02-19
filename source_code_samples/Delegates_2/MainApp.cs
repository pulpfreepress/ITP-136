using System;
using System.Windows.Forms;


public class MainApp {

 
 
  private delegate void ClickHandler();
 
 
 
  public MainApp(){
  
    GUI gui = new GUI();
    gui.ButtonOneDelegate = new ClickHandler(ButtonOneClickHandler);
    gui.ButtonTwoDelegate = new ClickHandler(ButtonTwoClickHandler);
    gui.ButtonThreeDelegate = new ClickHandler(ButtonThreeClickHandler);
    gui.ButtonFourDelegate = new ClickHandler(ButtonFourClickHandler);
     
  
    Application.Run(gui);
  }
  

  public void ButtonOneClickHandler(){
  
    Console.WriteLine("Button 1 clicked!");
  
  }
  
  
  public void ButtonTwoClickHandler(){
  
     Console.WriteLine("Button 2 clicked!");
     
  }
  
  
  public void ButtonThreeClickHandler(){
      
      Console.WriteLine("Button 3 clicked!");
  }
  
  
  public void ButtonFourClickHandler(){
  
     Console.WriteLine("Button 4 clicked!");
  
  }



  public static void Main(){
    
    new MainApp();
    
  }

}
