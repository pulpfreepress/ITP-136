using System;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;

public class Server {
	
	

	private static void ProcessClientRequests(object obj){
		Console.WriteLine("Processing client connection in separate thread...");
		TcpClient client = (TcpClient)obj;
		StreamReader reader = new StreamReader(client.GetStream());
		StreamWriter writer = new StreamWriter(client.GetStream());
		
		string s = String.Empty;
		
		try {
			while((s = reader.ReadLine()) != "Exit"){
			   Console.WriteLine("From client: " + s);
			   writer.WriteLine(s);
			   writer.Flush();
			}
		}catch(Exception e){
			Console.WriteLine(e);
		}
		
		reader.Close();
		writer.Close();
		client.Close();
	}
	
	
	
	public static void Main(){
		
		TcpListener listener = new TcpListener(IPAddress.Any, 5000);
		listener.Start();
		Console.WriteLine("Server started. Listening on port 5000.");
		
		while(true){
			Console.WriteLine("Listening for incoming client connections...");
			TcpClient client = listener.AcceptTcpClient();
			Console.WriteLine("Incoming connection detected...");
			Thread t = new Thread(Server.ProcessClientRequests);
			t.Start(client);
		}
	
	} // end Main()
	
	
	
} // end Server class

