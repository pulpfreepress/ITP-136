/**************************************************
  The View provides the user interface experience.
  In this example the View is a Windows Form, but 
  it doesn't have to be.
  
  All user interaction with the program is via 
  the View. 
  
  When an instance of the View is created it will
  need a reference to the Controller object that
  will handle some of the View's events.
***************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;



  public class View : Form {
    private TextBox _textbox_1 = null;
    private TextBox _textbox_2 = null;
    private TextBox _textbox_3 = null;
    private Button  _button_1  = null;
    private Button  _button_2  = null;
    private Button  _button_3  = null;
    private Label   _label_2   = null;
    private Label   _label_3   = null;
    
    
    public View(Controller the_controller){
      _textbox_1 = new TextBox();
      _textbox_1.Location = new Point(10, 10);
      _textbox_1.Multiline = true;
      _textbox_1.ScrollBars = ScrollBars.Vertical;
      _textbox_1.Height = 150;
      _textbox_1.Width  = 200;
      
      _label_2 = new Label();
      _label_2.Text = "First Name:";
      _label_2.Location = new Point(250, 40);
      
      
      _label_3 = new Label();
      _label_3.Text = "Last Name:";
      _label_3.Location = new Point(250, 80);
      
      _textbox_2 = new TextBox();
      _textbox_2.Location = new Point(_label_2.Right + 10, _label_2.Top);
      
      _textbox_3 = new TextBox();
      _textbox_3.Location = new Point(_label_3.Right + 10, _label_3.Top);
      
      
      _button_1 = new Button();
      _button_1.Text = "Clear";
      _button_1.Location = new Point(30, 220);
      _button_1.Click += new EventHandler(the_controller.onButton1Click);
      
      
      _button_2 = new Button();
      _button_2.Text = "Next";
      _button_2.Location = new Point(_button_1.Right + 10, _button_1.Top);
      _button_2.Click += new EventHandler(the_controller.onButton2Click);
      
      _button_3 = new Button();
      _button_3.Text = "Save";
      _button_3.Location = new Point(_button_2.Right + 10, _button_2.Top);
      _button_3.Click += new EventHandler(the_controller.onButton3Click);
      
      
      
      this.Width = 500;
      this.Height = 300;
      
      this.Controls.Add(_textbox_1);
      this.Controls.Add(_label_2);
      this.Controls.Add(_label_3);
      this.Controls.Add(_textbox_2);
      this.Controls.Add(_textbox_3);
      this.Controls.Add(_button_1);
      this.Controls.Add(_button_2);
      this.Controls.Add(_button_3);
      
      
    }
    
    
    public String FirstNameText {
      get { return _textbox_2.Text; }
      set { _textbox_2.Text = value; }
    }
    
    public String LastNameText {
      get { return _textbox_3.Text; }
      set {_textbox_3.Text = value; }
    
    }
    
    
    public String MainTextBoxText {
      get { return _textbox_1.Text; }
      set { _textbox_1.Text = value; }
    
    }
    
  
  


  } // end View class
