using System;
using System.Windows.Forms;

public class MainApp {

   private RobotRat _itsRobotRat;
   private RobotController _itsRobotController;
   
   
   public MainApp(){
   
     _itsRobotRat = new RobotRat();
     _itsRobotController = new RobotController(this);
     Application.Run(_itsRobotController);
   
   }
  
  
    
    
   public void TurnRightButtonHandler(object sender, EventArgs e){
     _itsRobotRat.TurnRight();
   }
   
   
    public void TurnLeftButtonHandler(object sender, EventArgs e){
        _itsRobotRat.TurnLeft();
   }
   
   public void MoveButtonHandler(object sender, EventArgs e){
   
      _itsRobotRat.Move(_itsRobotController.SpacesToMove);
    
   }
    
  
   public static void Main(){
      new MainApp();
   }
  

}