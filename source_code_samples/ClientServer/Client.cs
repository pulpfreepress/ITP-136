using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client {
  public class Client : Form {

    private Button       _button_1;
    private TextBox      _textbox_1;
    private StreamWriter _writer;
    private TcpClient    _client;
    
    public Client(){
     _textbox_1 = new TextBox();
     _textbox_1.Location = new Point(30, 20);
     
     _button_1 = new Button();
     _button_1.Location = new Point(30, 80);
     _button_1.Text = "Send";
     _button_1.Click += new EventHandler(onButton1Click);
     
     try{
        _client = new TcpClient("127.0.0.1", 5001);
        _writer = new StreamWriter(_client.GetStream());
        
        }catch(Exception e){
          Console.WriteLine(e.Message);
         }
    
     this.Width  = 250;
     this.Height = 250;
     
     this.Controls.Add(_textbox_1);
     this.Controls.Add(_button_1);
    }
    
    
    public void onButton1Click(Object o, EventArgs e){
      try{
         _writer.WriteLine(_textbox_1.Text);
         _writer.Flush();
         Console.WriteLine(_textbox_1.Text);
         }catch(Exception ae){
           Console.WriteLine(ae.Message);  
          }
    
    }

   
    public static void Main(String[] args){
      Client client = new Client();
      client.ShowDialog();
  
    } // end Main()
  } // end Client class
} // end namespace