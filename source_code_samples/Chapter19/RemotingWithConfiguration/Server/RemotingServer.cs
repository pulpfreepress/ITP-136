using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


public class RemotingServer {
  public static void Main(){
   try {
     RemotingConfiguration.Configure("server.config", false);
     Console.WriteLine("Listening for remote requests. Press any key to exit...");
     Console.ReadLine();
    }catch(Exception e){
      Console.WriteLine(e);
    }
  }
}