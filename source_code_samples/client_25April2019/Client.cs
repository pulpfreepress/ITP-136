using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;

public class Client : IAppEventHandler {
	
	private ControlPanel _controlPanel;
	private TcpClient    _client;
	private StreamReader _reader;
	private StreamWriter _writer;
	
	public ControlPanel ControlPanel {
		get { return _controlPanel; }
	}
	
	
	
	public Client(){
		_controlPanel = new ControlPanel(this);
		_client = new TcpClient();
	}
	
	
	public void UniversalClickHandler(object sender, EventArgs e){
		_controlPanel.Message += (((Button)sender).Text + " Clicked\r\n");
		
		 switch(((Button)sender).Text){
		   case "Connect" : Connect();
							break;
		   case "Create" : Create();
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

	public void NextRobotHandler(object sender, EventArgs e){
		_writer.WriteLine("NextRobot");
		_writer.Flush();
		_controlPanel.Message = _reader.ReadLine();
		
	}
	
	private void Connect(){
	   Console.WriteLine("Connect() called..."); 
	   Console.WriteLine("IP Address: " + _controlPanel.IpAddress);
	   Console.WriteLine("Port: " + _controlPanel.Port);
	   try {
	   _client.Connect(_controlPanel.IpAddress, _controlPanel.Port);
       _reader = new StreamReader(_client.GetStream());
	   _writer = new StreamWriter(_client.GetStream());	
	   _writer.WriteLine("Test");
	   _writer.Flush();
	   string s = _reader.ReadLine();
	   _controlPanel.Message = s;
	   }catch(Exception){
		   _controlPanel.Message = "Check IP Address and Port";
		   if(_client != null){
			   _client.Close();
		   }
	   }
	}
	
	
	private void Disconnect(){
		_writer.WriteLine("Exit");
		_writer.Flush();
		
	   
	}
	
	
	private void Create(){
		if(_client != null){
			_writer.WriteLine(_controlPanel.RobotType);
			_writer.Flush();
			_controlPanel.Message = _reader.ReadLine();
			
		}
	}
	
	
	
	private void MoveNorth(){
	  Console.WriteLine("MoveNorth() called...");
	}
	
	private void MoveSouth(){
		_writer.WriteLine("South");
		_writer.Flush();
		_controlPanel.Message = _reader.ReadLine();
	}
	
	private void MoveEast(){
		_writer.WriteLine("East");
		_writer.Flush();
		_controlPanel.Message = _reader.ReadLine();
	}
	
	private void MoveWest(){
		Console.WriteLine("MoveWest() called...");
	}
	
	
	public static void Main(){
		
		
		Client client = new Client();
		
		Application.Run(client.ControlPanel);
	}
	
}