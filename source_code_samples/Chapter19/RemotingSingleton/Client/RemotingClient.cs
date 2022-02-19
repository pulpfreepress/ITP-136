using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

public class RemotingClient {
  public static void Main(){
    try {
    TcpChannel channel = new TcpChannel();
    ChannelServices.RegisterChannel(channel, false);
    TestClass test = (TestClass)Activator.GetObject(typeof(TestClass), "tcp://localhost:8080/TestClass" );
    Console.WriteLine(test.Text);
    test.Text = "This is a new string sent from the client application!";
    Console.WriteLine(test.Text);
    }catch(ArgumentNullException ane){
      Console.WriteLine(ane);
    }catch(RemotingException re){
      Console.WriteLine(re);
    }catch(Exception e){
      Console.WriteLine(e);
    }
  }
}