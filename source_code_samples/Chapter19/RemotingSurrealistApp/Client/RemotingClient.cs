using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

public class RemotingClient {
  public static void Main(){
   try {
     RemotingConfiguration.Configure("client.config", false);
     WellKnownClientTypeEntry[] client_types = RemotingConfiguration.GetRegisteredWellKnownClientTypes(); 
     ISurrealistServer surrealist_server = (ISurrealistServer)Activator.GetObject(typeof(ISurrealistServer), client_types[0].ObjectUrl );
     
     List<Person> surrealists = surrealist_server.GetSurrealists();
     foreach(Person p in surrealists){
       Console.WriteLine(p);
     }
     
    }catch(Exception e){
      Console.WriteLine(e);
    }
  }
}