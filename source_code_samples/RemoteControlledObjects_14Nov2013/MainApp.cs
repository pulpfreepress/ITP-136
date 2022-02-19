using System;
using System.Windows.Forms;


public class MainApp {


   private RobotManager _its_robot_manager;
   private ControlPanel    _its_control_panel;
   
   public MainApp() {
   
     _its_robot_manager = new RobotManager();
	 _its_control_panel = new ControlPanel(this);
   
   }
   
   
   public void AddRatHandler(object sender, EventArgs e){
     _its_robot_manager.AddRat();
   
   }
   
   
   public void SpeakButtonHandler(object sender, EventArgs e){
     _its_robot_manager.Speak();
   }
   
   public void MoveButtonHandler(object sender, EventArgs e){
   
      _its_robot_manager.Move();
   }
   
   public void NextButtonHandler(object sender, EventArgs e){
     _its_robot_manager.Next();
   }
   
   public void AddDroidHandler(object sender, EventArgs e){
     _its_robot_manager.AddDroid();
   }






   public static void Main(){
     MainApp ma = new MainApp();
	 Application.Run(ma._its_control_panel);
   }


}
