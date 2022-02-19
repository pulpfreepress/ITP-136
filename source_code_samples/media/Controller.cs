using System;
using System.Windows.Forms;



public class Controller {


  private Model _itsModel;
  private View _itsView;

   public Controller(){
     _itsModel = new Model();
	 _itsView = new View(this);
	 Application.Run(_itsView);
   }
   
   
   public void AddButtonHandler(object sender, EventArgs e){
     Console.WriteLine("There are now " + _itsModel.AddMedia(_itsView.GetMedia()) + " Media objects in the library!");
     foreach(Media m in _itsModel.MediaList){
	   Console.WriteLine(m.Description);
	 }
   
   }
   
   
   public void NextButtonHandler(object sender, EventArgs e){
     Console.WriteLine("Next button clicked!");
   }
   
   public static void Main(){
     new Controller();
   }


}