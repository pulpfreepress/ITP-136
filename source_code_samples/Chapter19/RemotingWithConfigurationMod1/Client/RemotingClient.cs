using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

public class RemotingClient {
  public static void Main(){
   try {
     RemotingConfiguration.Configure("client.config", false);
     WellKnownClientTypeEntry[] client_types = RemotingConfiguration.GetRegisteredWellKnownClientTypes(); 
     ITest test = (ITest)Activator.GetObject(typeof(ITest), client_types[0].ObjectUrl );
     Console.WriteLine(test.Text);
     test.Text = "This is a new string sent from the client application";
     Console.WriteLine(test.Text);
    }catch(Exception e){
      Console.WriteLine(e);
    }
  }
}