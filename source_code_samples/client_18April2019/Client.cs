using System;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;


public class Client {
	
	
	
	
	public static void Main(){
		TcpClient client = new TcpClient();
		
		client.Connect(IPAddress.Parse("127.0.0.1"), 5000);
		StreamReader reader = new StreamReader(client.GetStream());
		StreamWriter writer = new StreamWriter(client.GetStream());
		
		writer.WriteLine("Hello Server. How are you doing?");
		writer.Flush();
		string s = reader.ReadLine();
		Console.WriteLine("Server replied with " + s);
		
		while(true){
		
		  Console.Write("Message to server: ");
		  s = Console.ReadLine();
		  writer.WriteLine(s);
		  writer.Flush();
		  if(s == "Exit") break;
		  s = reader.ReadLine();
		  Console.WriteLine("Server replied with " + s);
		  
		}
		reader.Close();
		writer.Close();
		client.Close();
		

	}
}