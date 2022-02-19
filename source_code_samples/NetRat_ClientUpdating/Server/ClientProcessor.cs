using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using RatSpace;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace ThreadedServer {
  public class ClientProcessor{
    
    private StreamReader _reader;
    private StreamWriter _writer;
    private TcpClient    _client;
    private Bitmap       _drawing_area;
    private Form         _form;
    private Rat          _rat;
      
    public ClientProcessor(TcpClient client, Form form){
      _client = client;
      _form   = form;
      _drawing_area   = new Bitmap(form.ClientRectangle.Width, form.ClientRectangle.Height);
      _reader = new StreamReader(client.GetStream());
      _writer = new StreamWriter(client.GetStream());
      _rat    = new Rat("rat.gif");
      Console.WriteLine("New client processor thread created...");
    }
    
    
    public void processClientRequests(){
      try{
      string s = "";
      while((s = _reader.ReadLine()) != null){
        
           Console.WriteLine(s);
           
           switch((char)s[0]){
             case '1': moveEast();
			           SerializeRat();
                       
                       break;
             case '2': moveSouth();
                       SerializeRat();			 
                       break;
             
             default: Console.WriteLine("Unrecognized Command!");
                      break;
           } // end switch
           
         }//end while  
           
           }catch(Exception e){ 
               Console.WriteLine(e.Message);
             }finally{
                _reader.Close();
	        _writer.Close();
                _client.Close();
             }
      
    
    }
  
  
    public void moveEast(){
      Console.WriteLine("Move east young Rat...");
      Graphics graphics = Graphics.FromImage(_drawing_area);
      _rat.X += 3;
      graphics.DrawImage(_rat.Image, _rat.Point);
      _form.Invalidate();
      
    
    }
    
    public void moveSouth(){
      Console.WriteLine("Move south young Rat...");
      Graphics graphics = Graphics.FromImage(_drawing_area);
      _rat.Y += 3;
      graphics.DrawImage(_rat.Image, _rat.Point);
      _form.Invalidate();
    }
    
    public void updateGraphics(object sender, PaintEventArgs e){
       Graphics graphics = e.Graphics;
       graphics.DrawImage( _drawing_area, 0, 0, _drawing_area.Width, _drawing_area.Height);
    }
  
    public void SerializeRat(){
	  BinaryFormatter bf = new BinaryFormatter();
	  bf.Serialize(_client.GetStream(), _rat);
	}
  
  } // end class
} // end namespace