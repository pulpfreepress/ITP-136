using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading;

public class RemotingClient {
  public static void Main(){
   try {
     RemotingConfiguration.Configure("client.config", false);
     WellKnownClientTypeEntry[] client_types = RemotingConfiguration.GetRegisteredWellKnownClientTypes(); 
     ITest test = (ITest)Activator.GetObject(typeof(ITest), client_types[0].ObjectUrl );
     Console.WriteLine(test.Text);
     for(int i=0; i<100; i++){
       test.Text = "This is string number " + i + " sent from the client application";
       Console.WriteLine(test.Text);
       Thread.Sleep(3000);
     }
    }catch(Exception e){
      Console.WriteLine(e);
    }
  }
}