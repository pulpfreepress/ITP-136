using System;
using System.Drawing;
using System.Windows.Forms;


public class RobotController : Form {


  private FlowLayoutPanel _flowPanel;
  private Button _turnRightButton;
  private Button _turnLeftButton;
  private Button _moveButton;
  private TextBox _textbox1;
  
  
  
  public int SpacesToMove {
  
     get { 
     
       int return_value = 0;
       
       try{
       
         return_value = Int32.Parse(_textbox1.Text);
       
       }catch(Exception){
         // ignore
       }
     
       return return_value;
     }
  
  }
  
  
  
  
  public RobotController(MainApp ma){
  
     InitializeComponent(ma);
  }


  public void InitializeComponent(MainApp ma){
  
    _flowPanel = new FlowLayoutPanel();
  
    _turnRightButton = new Button();
    _turnRightButton.Text = "Turn Right";
    _turnRightButton.Click += ma.TurnRightButtonHandler;
    
    
    _turnLeftButton = new Button();
    _turnLeftButton.Text = "Turn Left";
    _turnLeftButton.Click += ma.TurnLeftButtonHandler;
    
    
    _moveButton = new Button();
    _moveButton.Text = "Move";
    _moveButton.Click += ma.MoveButtonHandler;
    
    _textbox1 = new TextBox();
    
    
    
    
    this.Text = "Robot Controller";
    
    
    _flowPanel.Controls.Add(_turnRightButton);
    _flowPanel.Controls.Add(_turnLeftButton);
    _flowPanel.Controls.Add(_moveButton);
    _flowPanel.Controls.Add(_textbox1);
    this.Controls.Add(_flowPanel);
  
  }



} // end class definition