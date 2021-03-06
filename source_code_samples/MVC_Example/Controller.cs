/**********************************************
  The Controller class coordinates messaging
  between the Model and the View. In this
  example the Controller also contains the 
  Main() method.
  
  The Controller will respond to designated 
  events generated by the View. The View may
  handle some of its own events.

  Essentially, the Controller knows something
  about the View and the Model, but the View
  knows nothing about the Model and the Model
  knows nothing about the View. 
***********************************************/

using System;
using System.Windows.Forms;



 public class Controller {
   private View its_view = null;
   private Model its_model = null;
 
   public Controller(){
     its_view = new View(this);
     its_model = new Model();
     Application.Run(its_view);
   
   }
   
   
   
   public void onButton1Click(Object o, EventArgs e){
     Console.WriteLine("Clear Button Clicked!");
     its_view.FirstNameText = "";
     its_view.LastNameText = "";
   
   }
   
   public void onButton2Click(Object o, EventArgs e){
        Console.WriteLine("Next Button Clicked!");
        String[] s = its_model.getNext();
        its_view.FirstNameText = s[0];
        its_view.LastNameText  = s[1];
        
      
   }
   
   public void onButton3Click(Object o, EventArgs e){
        Console.WriteLine("Save Button Clicked!");
        its_model.save(its_view.FirstNameText, its_view.LastNameText);
        its_view.MainTextBoxText = its_model.getAllNames();
   }
 
 
   public static void Main(String[] args){
      new Controller();
      
   } // end Main()
 
 } // end Controller class
