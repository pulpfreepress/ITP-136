using System;
using System.Drawing;
using System.Windows.Forms;


public class GUITest : Form {

  private TextBox _textbox;
  private Button  _button;
  private FlowLayoutPanel _panel;
  
  public GUITest(){
   _textbox = new TextBox();
   _button  = new Button();
   _panel   = new FlowLayoutPanel();
   
   _button.Text = "Click Me";
   _button.Click += new EventHandler(this.SquareTwoNumbers);
   
   _panel.Controls.Add(_textbox);
   _panel.Controls.Add(_button);
   _panel.Dock = DockStyle.Top;
   
   this.Controls.Add(_panel);
  }
  
  public void SquareTwoNumbers(object sender, EventArgs e){
    try{
      int number = Int32.Parse(_textbox.Text);
      _textbox.Text = (number * number) + " ";
      
      
    }catch(Exception){
      _textbox.Text = "Bad Number!";
    }
  }


  static void Main(){
    Application.Run(new GUITest());
  }
}
