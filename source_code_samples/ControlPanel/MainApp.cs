using System;
using System.Windows.Forms;

public class MainApp : IAppEventHandler {
	
	private ControlPanel _controlPanel;
	
	public ControlPanel ControlPanel {
		get { return _controlPanel; }
	}
	
	
	public MainApp(){
		_controlPanel = new ControlPanel(this);
	}
	
	
	public void UniversalClickHandler(object sender, EventArgs e){
		_controlPanel.Message += (((Button)sender).Text + " Clicked\r\n");
		
		 switch(((Button)sender).Text){
		   case "North" : MoveNorth();
		                  break;
		   
		   case "South" : MoveSouth();
		                  break;
		   
		   case "East" :  MoveEast();
		                  break;
		   
		   case "West" :  MoveWest();
		                  break;
			 
		 }
	}
	
	public void ConnectButtonHandler(object sender, EventArgs e){ }
	
	public void MoveButtonHandler(object sender, EventArgs e){ }
	
	
	private void MoveNorth(){
	  Console.WriteLine("MoveNorth() called...");
	}
	
	private void MoveSouth(){
		Console.WriteLine("MoveSouth() called...");
	}
	
	private void MoveEast(){
		Console.WriteLine("MoveEast() called...");
	}
	
	private void MoveWest(){
		Console.WriteLine("MoveWest() called...");
	}
	
	
	public static void Main(){
		
		
		MainApp ma = new MainApp();
		
		Application.Run(ma.ControlPanel);
	}
	
}