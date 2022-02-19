using System;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Windows.Forms;


public class Server {

  private TcpListener _listener;
  private RobotManager _robotManager;

  public Server(){
    _robotManager = new RobotManager();
  }
  
  
  
  public void ProcessClientConnection(Object client){
    
    TcpClient itsClient;
	StreamReader itsReader; 
	
	try{
	  itsClient = (TcpClient)client;
	  itsReader = new StreamReader(itsClient.GetStream());
	  string s = String.Empty;
	  
	  while((s = itsReader.ReadLine()) != null){
	     Console.WriteLine(s);
	     switch((char)s[0]){
		 
		   case '1' : _robotManager.AddRat();
		                   break;
						   
		   case '3' : _robotManager.Move();
		              break;
					  
		   case '2' : _robotManager.AddDroid();
		              break;
		   case '4' : _robotManager.Next();
		              break;
		   case '5' : _robotManager.Speak();
		              break;
		 
		 }
	  
	  }
	  
	  
	}catch(Exception e){
	  Console.WriteLine(e);
	}
	
	
	
	
	
  
  }
  

   public void ListenForClients(){
     try{
	 
	    _listener = new TcpListener(IPAddress.Any, 5001);
		_listener.Start();
		Console.WriteLine("Listener started...");
		
		while(true){
		  Console.WriteLine("Waiting for incoming client connections...");
		  TcpClient incomingClient = _listener.AcceptTcpClient();
		  Console.WriteLine("Client connected. Creating Client processing thread...");
		  Thread t = new Thread(this.ProcessClientConnection);
		  t.Start(incomingClient);
		  Console.WriteLine("Client thead started...");
		}
	 
	 
	 }catch(Exception e){
	   Console.WriteLine(e);
	 }


   }   




   public static void Main(){
     Server s = new Server();
	 Thread t = new Thread(s.ListenForClients);
	 t.Start();
	 Application.Run(s._robotManager.Floor);
	 
   }
}