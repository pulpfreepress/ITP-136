using System;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.Windows.Forms;

public class Server {
	
	private List<IControllable> _robots;
	private Floor _floor;
	private TcpListener _listener;
	private int _current_robot;
	
	public Server(){
		
	  _robots = new List<IControllable>();
	  _floor = new Floor(_robots);
	  _current_robot = 0;
	  
	}
	
	
	private void StartListener(){
	  _listener = new TcpListener(IPAddress.Any, 5000);
	  _listener.Start();
	  Console.WriteLine("Listener started. Listening on port 5000.");
		
	}
	
	private void ProcessIncomingConnections(){
		while(true){
			Console.WriteLine("Listening for incoming client connections...");
			TcpClient client = _listener.AcceptTcpClient();
			Console.WriteLine("Incoming connection detected...");
			Thread t = new Thread(ProcessClientRequests);
			t.Start(client);
		}
	}
	
	
	private void ProcessClientRequests(object obj){
		Console.WriteLine("Processing client connection in separate thread...");
		TcpClient client = (TcpClient)obj;
		StreamReader reader = new StreamReader(client.GetStream());
		StreamWriter writer = new StreamWriter(client.GetStream());
		
		string s = String.Empty;
		
		try {
			while((s = reader.ReadLine()) != "Exit"){
			   Console.WriteLine("From client: " + s);
			   switch(s){
				 case "Test" : {
					            writer.WriteLine(s);
								writer.Flush();
								break;
				                }
				 case "Rat" : {
				              Rat rat = new Rat();
							  _robots.Add(rat);
							  writer.WriteLine("Rat created!");
							  writer.Flush();
							  _floor.Refresh();
							  break;
						
				             }
							 
				 case "East" : {
					            _robots[_current_robot].FaceEast();
					            _robots[_current_robot].Move();
								_floor.Refresh();
								writer.WriteLine("East called on server...");
								writer.Flush();
					            break;
				               }
							   
				 case "South" : {
					            _robots[_current_robot].FaceSouth();
								_robots[_current_robot].Move();
								_floor.Refresh();
								writer.WriteLine("South called on server...");
								writer.Flush();
					            break;
				                }
				  
				 case "NextRobot" : {
					                 if((++_current_robot) > _robots.Count-1){
										 _current_robot = 0;
									 }
									 writer.WriteLine("Current Robot = " + _current_robot);
									 writer.Flush();
									 break;
				                    }
				   
				 default: {
					 writer.WriteLine("Unknown Command!");
					 writer.Flush();
					 break;
				 }
				   
			   }
			   
			   
			   
			   
			}
			reader.Close();
		    writer.Close();
		    client.Close();
		}catch(Exception){
			if(client != null){
			  reader.Close();
		      writer.Close();
		      client.Close();
			}
		}
		
		Console.WriteLine("Finished Processing Client...");
	}
	
	public static void Main(){
		
		Server s = new Server();
		s.StartListener();
		Thread t = new Thread(s.ProcessIncomingConnections);
		t.Start();
		Application.Run(s._floor);
	
	} // end Main()
	
	
	
} // end Server class

