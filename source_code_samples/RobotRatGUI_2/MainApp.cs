using System;
using System.Windows.Forms;

public class MainApp {

   private RobotRat _its_rat;
   private ControlPanel _its_control_panel;
   
   public MainApp(){
      _its_rat = new RobotRat(20, 20);
	  _its_control_panel = new ControlPanel(this);
   }
   
   
   // event handler methods
   public void TurnRightEventHandler(object sender, EventArgs e){
      _its_rat.TurnRight();
   }
   
   public void MoveEventHandler(object sender, EventArgs e){
     _its_rat.MoveForward(_its_control_panel.SpacesToMove);
   }
   
   public void PenDownEventHandler(object sender, EventArgs e){
     _its_rat.SetPenDown();
   }


   // main method
   public static void Main(){
      MainApp ma = new MainApp();
	  Application.Run(ma._its_control_panel);
   }
  
}