using System.Windows.Forms;
using System;
using System.Drawing;

public class InputDialog : Form {

  private Label label1 = null;
  private TextBox textbox1 = null;
  private Button button1 = null;
  
  
  public InputDialog(ComputerSimulator cs){
  
    label1 = new Label();
    label1.Text = "Enter Number:";
    label1.Location = new Point(10, 10);
    
  
    textbox1 = new TextBox();
    textbox1.Location = new Point(10, 30);
    
    button1 = new Button();
    button1.Text = "Enter";
    button1.Location = new Point(70, 100);
    button1.Click += new EventHandler(cs.onEnterButtonClick);
    
    this.Controls.Add(label1);
    this.Controls.Add(textbox1);
    this.Controls.Add(button1);
  }
  
  
  public int Number {
    get { return Convert.ToInt32(textbox1.Text); }
  }
  
  
  
  


} // end class definition