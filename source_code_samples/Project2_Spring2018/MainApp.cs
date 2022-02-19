using System;
using System.Windows.Forms;


public class MainApp {
	
	private ControlPanel _controlPanel;
	private RobotRat _robotRat;
	
	
	public MainApp(){
	   _controlPanel = new ControlPanel(this);
	   _robotRat = new RobotRat(20, 20);
	}
	
	public void TurnLeftButton_Click(object sender, EventArgs e){
		_controlPanel.Status = _robotRat.TurnLeft();
	}
	
	public void TurnRightButton_Click(object sender, EventArgs e){
		_controlPanel.Status = _robotRat.TurnRight();
	}
	
	public void ToggleButton_Click(object sender, EventArgs e){
		_controlPanel.Status = _robotRat.TogglePen();
	}
	
	public void MoveButton_Click(object sender, EventArgs e){
	    _robotRat.MoveForward(_controlPanel.SpacesToMove);
		_robotRat.PrintFloor();
	}
	
	
	public static void Main(){
	   MainApp ma = new MainApp();
	   Application.Run(ma._controlPanel);
		
	}
	
	
} // end MainApp class