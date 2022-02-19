using System;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

public class MainApp : IHandler {
	
	private Floor _floor;
	private ControlPanel _control_panel;
	private List<IControllable> _robots;
	private int _current_robot;
	
	public MainApp(){
		_robots = new List<IControllable>();
		_floor = new Floor(_robots);
		_floor.Click += FloorClickHandler;
		_current_robot = 0;
		_control_panel = new ControlPanel(this);
		_control_panel.Closing += ControlPanelClosingHandler;
		_control_panel.Visible = true;
	}
	
	public void ButtonClickHandler(object sender, EventArgs e){
		Button b = (Button)sender;
		
		switch(b.Text){
			case "Add Robot": AddRobot(b.Text);
							break;
			case "Next Robot": NextRobot(b.Text);
							break;
			case "Turn Left": TurnLeft(b.Text);
							break;
			case "Turn Right": TurnRight(b.Text);
							break;				
			case "Move": Move(b.Text);
							break;					
		}
	}
	
	
	private void AddRobot(string text){
	   Image picture = new Bitmap("rat.gif");
	   _robots.Add(new Rat(picture));
	   _floor.Refresh();
	   Console.WriteLine(text + " button clicked!");
	}
	
	private void NextRobot(string text){
		if(++_current_robot >= _robots.Count){
			_current_robot = 0;
		}
		Console.WriteLine(text + " button clicked!");
	}
	
	private void TurnLeft(string text){
		_robots[_current_robot].TurnLeft();
		_floor.Refresh();
		Console.WriteLine(text + " button clicked!");
	}
	
	private void TurnRight(string text){
		_robots[_current_robot].TurnRight();
		_floor.Refresh();
		Console.WriteLine(text + " button clicked!");
	}
	
	private void Move(string text){
		_robots[_current_robot].Move();
		_floor.Refresh();
		Console.WriteLine(text + " button clicked!");
		
	}
	
	private void FloorClickHandler(object sender, EventArgs e){
		_control_panel.Visible = true;
	}
	
	private void ControlPanelClosingHandler(object sender, CancelEventArgs e){
		e.Cancel = true;
		((Form)sender).Visible = false;
	}
	
	
	
	public static void Main(){
		MainApp ma = new MainApp();
		Application.Run(ma._floor);
		
		try{
			ma._floor.Close();
			Console.WriteLine("_floor closed!");
		}catch(Exception){
			Console.WriteLine("Exception thrown closing _floor.");
		}
		
		try{
			ma._control_panel.Close();
			Console.WriteLine("_control_panel closed!");
		}catch(Exception){
			Console.WriteLine("Exception thrown closing _control_panel.");
		}
		
	}
	
	
} // end class