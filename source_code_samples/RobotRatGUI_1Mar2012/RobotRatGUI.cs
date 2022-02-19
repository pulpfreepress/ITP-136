using System;
using System.Windows.Forms;
using System.Drawing;

public class RobotRatGUI : Form {


 private TableLayoutPanel _layoutPanel;
 private Button _penUpButton;
 private Button _penDownButton;
// private Button _turnLeftButton;
 private Button _turnRightButton;
 private Button _printFloorButton;
 private Button _moveButton;
 private TextBox _spacesToMoveTextBox;
 
 
 
 public int SpacesToMove {
 
   get {
        int spaces_to_move = 0;
        try{
		 spaces_to_move = Int32.Parse(_spacesToMoveTextBox.Text);
		}catch(Exception){
		  _spacesToMoveTextBox.Text = "Invalid Int Value!";
		}
        return spaces_to_move;
      }
 
 }
 
 
 public RobotRatGUI(MainApp ma){
   InitializeComponent(ma);
 }
 

 
 private void InitializeComponent(MainApp ma){
   _layoutPanel = new TableLayoutPanel();
   _layoutPanel.ColumnCount = 2;
   _layoutPanel.RowCount = 4;
   _layoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
   _layoutPanel.Dock = DockStyle.Fill;
   
   _penUpButton = new Button();
   _penUpButton.Text = "Pen Up";
   _penUpButton.Click += ma.PenUpButtonClickHandler;
   
   
   _penDownButton = new Button();
   _penDownButton.Text = "Pen Down";
   _penDownButton.Click += ma.PenDownButtonClickHandler;
   
   
   _printFloorButton = new Button();
   _printFloorButton.Text = "Print Floor";
   _printFloorButton.Click += ma.PrintFloorButtonClickHandler;
   
   _turnRightButton = new Button();
   _turnRightButton.Text = "Turn Right";
   _turnRightButton.Click += ma.TurnRightButtonClickHandler;
   
   _moveButton = new Button();
   _moveButton.Text = "Move";
   _moveButton.Click += ma.MoveButtonClickHandler;
   _moveButton.Dock = DockStyle.Fill;
   
   _spacesToMoveTextBox = new TextBox();
   _spacesToMoveTextBox.Width = 100;
   
   
  
  
    _layoutPanel.Controls.Add(_penUpButton);
	_layoutPanel.Controls.Add(_penDownButton);
	_layoutPanel.Controls.Add(_turnRightButton);
	_layoutPanel.Controls.Add(_printFloorButton);
	_layoutPanel.SetColumnSpan(_spacesToMoveTextBox, 2);
	_layoutPanel.Controls.Add(_spacesToMoveTextBox);
	_layoutPanel.SetColumnSpan(_moveButton, 2);
	_layoutPanel.Controls.Add(_moveButton);
	
	
	this.Controls.Add(_layoutPanel);
 
    this.Text = "Robot Rat Control Panel";
 
 
 }
 


} // end class definition