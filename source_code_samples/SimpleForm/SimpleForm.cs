using System;
using System.Windows.Forms;
using System.Drawing;


public class SimpleForm : Form {


  private Button _button1 = null;




  public SimpleForm(){
  
    _button1 = new Button();
    _button1.Text = "Click Me!";
    _button1.Click += new EventHandler(ButtonOneClickHandler);
    _button1.MouseMove += new MouseEventHandler(ButtonOneMouseMoveHandler);
    _button1.MouseEnter += ButtonOneMouseEnterHandler;
    
    
   
    this.Controls.Add(_button1);
    this.Text = "This is titlebar text";
    
  }
  
  
  
  
  
   public void ButtonOneClickHandler(object sender, EventArgs e){
       Console.WriteLine("Button clicked!");
   }
   
   
   public void ButtonOneMouseMoveHandler(object sender, MouseEventArgs e){
        Console.WriteLine("Mouse moving x:{0} -- y{1}", e.X, e.Y);
   }
   
   
   public void ButtonOneMouseEnterHandler(object sender, EventArgs e){
   
       _button1.Location = new Point(_button1.Location.X + 10, _button1.Location.Y + 10);
     
   }




   public static void Main(){
     Application.Run(new SimpleForm());
     
   }
   
}