using System;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.IO;

public class Client {
  
    private ControlPanel _itsControlPanel;
	private TcpClient    _itsClient;
	private StreamWriter _itsWriter;
	
	
	public Client(){
	  _itsControlPanel = new ControlPanel(this);
	  this.ConnectToServer();
	  
	
	}
	
	private void ConnectToServer(){
	  try{
	    _itsClient = new TcpClient("127.0.0.1", 5001);
		_itsWriter = new StreamWriter(_itsClient.GetStream());
	  
	  }catch(Exception e){
	    Console.WriteLine(e);
	    
	  }
	}
	
	
	
	public void AddRatHandler(object sender, EventArgs e){
	   try{
	     _itsWriter.WriteLine("1");
		 _itsWriter.Flush();
	   
	   }catch(Exception ex){
	     Console.WriteLine(ex);
	   }
	
	}
	
	public void AddDroidHandler(object sender, EventArgs e){
	  try{
	    _itsWriter.WriteLine("2");
		 _itsWriter.Flush();
	   
	   }catch(Exception ex){
	     Console.WriteLine(ex);
	   }
	
	}
	
	
	public void SpeakButtonHandler(object sender, EventArgs e){
	   try{
	      _itsWriter.WriteLine("5");
		 _itsWriter.Flush();
	   
	   }catch(Exception ex){
	     Console.WriteLine(ex);
	   }
	
	}

	public void MoveButtonHandler(object sender, EventArgs e){
	  try{
	   
	    _itsWriter.WriteLine("3");
		 _itsWriter.Flush();
	   }catch(Exception ex){
	     Console.WriteLine(ex);
	   }
	
	}
	
	public void NextButtonHandler(object sender, EventArgs e){
	  try{
	    _itsWriter.WriteLine("4");
		 _itsWriter.Flush();
	   
	   }catch(Exception ex){
	     Console.WriteLine(ex);
	   }
	
	}








   public static void Main(){
    Client c = new Client();
	Application.Run(c._itsControlPanel);
   }


}