using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


public class RemotingServer {
  public static void Main(){
    
    try{
    TcpChannel channel = new TcpChannel(8080);
    ChannelServices.RegisterChannel(channel, false);
    RemotingConfiguration.RegisterWellKnownServiceType(typeof(TestClass), "TestClass", WellKnownObjectMode.Singleton);
    Console.WriteLine("Listening for remote requests. Press any key to exit...");
    Console.ReadLine();
    }catch(ArgumentNullException ane){
      Console.WriteLine("Channel argument was null!");
      Console.WriteLine(ane);
    }catch(RemotingException re){
      Console.WriteLine("Channel has already been registered!");
      Console.WriteLine(re);
    }catch(Exception e){
      Console.WriteLine(e);
    }
    
  }
}