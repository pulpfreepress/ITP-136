using System;
using System.Windows.Forms;
using System.Drawing;

namespace Person_Test {

  public class MainApp {
  
  GUI its_gui;
  
  
  public MainApp(){
    its_gui = new GUI(this);
    // Application.Run(its_gui);
    its_gui.showGUI();
  }


public void OnButton1Click(Object source, EventArgs e){
    
      int string_count = 0;
            
            Console.WriteLine("Click Me button clicked!");
            Console.WriteLine(source.ToString());
            
            Console.WriteLine(its_gui.getText());
            
            string[] input_strings = (its_gui.TextBoxText).Split(new char[] {'\n'});
            
            foreach (string s in input_strings){
            
                Console.WriteLine("Instruction Number {0}: " + s, string_count++); 
             }
           
    }
      
  

   public static void Main(string[] args){
      
      new MainApp();
      
   }//end Main method
   
  }
  
  
}