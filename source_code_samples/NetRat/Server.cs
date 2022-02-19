using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using RatSpace;

namespace ThreadedServer {
  public class Server : Form {
    private TcpListener _listener;
    
      
    public Server(){
       
    }
    
    
    public void listenForClients(){
    
    try{
       IPAddress local_address = IPAddress.Parse("127.0.0.1");
       Console.WriteLine("Creating TcpListener");
       _listener = new TcpListener(local_address, 5001);
        Console.WriteLine("Starting TcpListener");
        _listener.Start();
        Console.WriteLine("TcpListener Started");
        
    
      while(true){
       Console.WriteLine("Waiting for TcpClient");
       TcpClient client = _listener.AcceptTcpClient();
       Console.WriteLine("Client Accepted");
       Console.WriteLine("Creating ClientProcessor Object");
                     
       ClientProcessor cp = new ClientProcessor(client, this);
       this.Paint += new PaintEventHandler(cp.updateGraphics);
       Console.WriteLine("Creating Thread");
       Thread t = new Thread(new ThreadStart(cp.processClientRequests));
       Console.WriteLine("Starting Thread");
       t.Start();
       Console.WriteLine("Thread Started");
                     
       }
      }catch(Exception e){
        Console.WriteLine(e.Message);
       }
    }
  
  
    
  
  
    public static void Main(String[] args){
      Console.WriteLine("Creating Server object");
      Server s = new Server();
      Console.WriteLine("Creating client listener thread object");
      Thread t = new Thread(new ThreadStart(s.listenForClients));
      Console.WriteLine("Starting client listener thread");
      t.Start();
      Console.WriteLine("Showing floor");
      Application.Run(s);
      
      
    } // end Main
  } // end class
} // end namespace