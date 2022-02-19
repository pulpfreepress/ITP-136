using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ThreadedServer {
  public class Server {
    
    private StreamReader _reader;
    private StreamWriter _writer;
      
    public Server(TcpClient client){
      _reader = new StreamReader(client.GetStream());
      _writer = new StreamWriter(client.GetStream());
      Console.WriteLine("New server thread created...");
    }
    
    
    public void processClientRequests(){
      try{
         String s;
         while((s = _reader.ReadLine()) != null){
           Console.WriteLine(s);
          } // end while
        }catch(Exception e){
          Console.WriteLine(e.Message);
        }finally{
          Console.WriteLine("Client Processing Complete!!");
        }
    }
  
  
  
    public static void Main(String[] args){
      try{
         IPAddress local_address = IPAddress.Parse("127.0.0.1");
         Console.WriteLine("Creating TcpListener");
         TcpListener listener = new TcpListener(local_address, 5001);
         Console.WriteLine("Starting TcpListener");
         listener.Start();
         Console.WriteLine("TcpListener Started");
         
         while(true){
           Console.WriteLine("Waiting for TcpClient");
           TcpClient client = listener.AcceptTcpClient();
           Console.WriteLine("Client Accepted");
           Console.WriteLine("Creating Server Object");
           Server s = new Server(client);
           Console.WriteLine("Creating Thread");
           Thread t = new Thread(new ThreadStart(s.processClientRequests));
           Console.WriteLine("Starting Thread");
           t.Start();
           Console.WriteLine("Thread Started");
          }
         
         }catch(Exception e){
            Console.WriteLine(e.Message);
          }
      
      
    } // end Main
  } // end class
} // end namespace