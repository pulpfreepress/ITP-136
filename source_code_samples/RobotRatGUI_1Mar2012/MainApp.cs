/**********************************************
  Purpose of this class is two fold:
    1. To be the application (i.e. Hava a main method.)
	2. To coordinate communication between the Model layer
	   and the View layer

***********************************************/

using System;
using System.Windows.Forms;

public class MainApp {

  private RobotRat _its_robotrat;
  private RobotRatGUI _its_gui;
  
  public MainApp(){
    _its_robotrat = new RobotRat(20, 20);
	_its_gui = new RobotRatGUI(this);
	
  }

  
  /******************************************
    Event Handler Methods
  ******************************************/
  
  public void PenUpButtonClickHandler(object sender, EventArgs e){
     _its_robotrat.SetPenUp();
	
  }
  
  public void PenDownButtonClickHandler(object sender, EventArgs e){
     _its_robotrat.SetPenDown();
	
  }
  
  
  
  
  public void PrintFloorButtonClickHandler(object sender, EventArgs e){
    _its_robotrat.PrintFloor();
  }
  
  
  public void TurnRightButtonClickHandler(object sender, EventArgs e){
    _its_robotrat.TurnRight();
  }
  
  
  public void MoveButtonClickHandler(object sender, EventArgs e){
    _its_robotrat.MoveForward(_its_gui.SpacesToMove);
  }
  

  [STAThread]
  public static void Main(){
    MainApp ma = new MainApp();
	Application.Run(ma._its_gui);
  }



} // end class definition