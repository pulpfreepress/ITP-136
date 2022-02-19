using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;

public class MainApp : IAppEventHandler {
	
	private ControlPanel _controlPanel;
	private TcpClient    _client;
	
	public ControlPanel ControlPanel {
		get { return _controlPanel; }
	}
	
	
	
	public MainApp(){
		_controlPanel = new ControlPanel(this);
	}
	
	
	public void UniversalClickHandler(object sender, EventArgs e){
		_controlPanel.Message += (((Button)sender).Text + " Clicked\r\n");
		
		 switch(((Button)sender).Text){
		   case "Connect" : Connect();
							break;
		   case "Disconnect" : Disconnect();
							break;
		   
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

	private void Connect(){
	   Console.WriteLine("Connect() called..."); 
	   Console.WriteLine("IP Address: " + _controlPanel.IpAddress);
	   Console.WriteLine("Port: " + _controlPanel.Port);
	}
	
	
	private void Disconnect(){
	   Console.WriteLine("Disconnect() called..."); 
	}
	
	
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