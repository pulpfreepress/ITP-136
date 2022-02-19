using System;
using System.Windows.Forms;
using System.Drawing;


public class ControlPanel : Form {
	
	/****************
	 Private fields
	 ****************/
	 
	 private TableLayoutPanel _mainTableLayoutPanel;
	 private TableLayoutPanel _upperTableLayoutPanel;
	 private TableLayoutPanel _middleTableLayoutPanel;
	 private TableLayoutPanel _lowerTableLayoutPanel;
	 private Button _turnLeftButton;
	 private Button _turnRightButton;
	 private Button _togglePenButton;
	 private Button _moveButton;
	 private Label _spacesLabel;
	 private Label _statusLabel;
	 private TextBox _spacesTextBox;
	 
	 /****************
	  Properties
	  ****************/
	  
	  public string Status {
		set {
			_statusLabel.Text = value;
		}
	  }
	  
	  public int SpacesToMove {
		 get {
			int spacesToMove = 0; 
			
			try{
              spacesToMove = Int32.Parse(_spacesTextBox.Text);
			}catch(Exception){
              Status = "Pleae Enter a valid integer value!";
			}
			return spacesToMove;
		 }
	  }
	 
	 
	 
	 public ControlPanel(MainApp ma){
		 
		 InitializeComponent(ma);
	 }
	 
	 
	 private void InitializeComponent(MainApp ma){
       
	   _spacesLabel = new Label();
	   _spacesLabel.Text = "Spaces To Move:";
	   
	   _spacesTextBox = new TextBox();
	   
	    _upperTableLayoutPanel = new TableLayoutPanel();
		_upperTableLayoutPanel.RowCount = 1;
		_upperTableLayoutPanel.ColumnCount = 2;
		_upperTableLayoutPanel.SetColumn(_spacesLabel, 0);
		_upperTableLayoutPanel.SetColumn(_spacesTextBox, 1);
		_upperTableLayoutPanel.Controls.Add(_spacesLabel);
		_upperTableLayoutPanel.Controls.Add(_spacesTextBox);
		_upperTableLayoutPanel.Dock = DockStyle.Fill;
		
		
		
		
		_turnLeftButton = new Button();
		_turnLeftButton.Text = "Turn Left";
		_turnLeftButton.Click += ma.TurnLeftButton_Click;
	   
	    _turnRightButton = new Button();
		_turnRightButton.Text = "Turn Right";
		_turnRightButton.Click += ma.TurnRightButton_Click;
		
	   _togglePenButton = new Button();
	   _togglePenButton.Text = "Toggle Pen";
	   _togglePenButton.Click += ma.ToggleButton_Click;
	   
		
		_middleTableLayoutPanel = new TableLayoutPanel();
		_middleTableLayoutPanel.RowCount = 1;
		_middleTableLayoutPanel.ColumnCount = 3;
		_middleTableLayoutPanel.SetColumn(_turnLeftButton, 0);
		_middleTableLayoutPanel.SetColumn(_togglePenButton, 1);
		_middleTableLayoutPanel.SetColumn(_turnRightButton, 2);
		_middleTableLayoutPanel.Controls.Add(_turnLeftButton);
		_middleTableLayoutPanel.Controls.Add(_togglePenButton);
		_middleTableLayoutPanel.Controls.Add(_turnRightButton);
		_middleTableLayoutPanel.Dock = DockStyle.Fill;
		
		_moveButton = new Button();
		_moveButton.Text = "Move";
		_moveButton.Click += ma.MoveButton_Click;
		
		
		_lowerTableLayoutPanel = new TableLayoutPanel();
		_lowerTableLayoutPanel.ColumnCount = 3;
		_lowerTableLayoutPanel.RowCount = 1;
		_lowerTableLayoutPanel.SetColumn(_moveButton, 1);
		_lowerTableLayoutPanel.Controls.Add(_moveButton);
		  
		 _statusLabel = new Label();
		 _statusLabel.Dock = DockStyle.Fill;
		 _statusLabel.TextAlign = ContentAlignment.MiddleCenter;
		 
		 
		 
		 
	   _mainTableLayoutPanel = new TableLayoutPanel();
	   _mainTableLayoutPanel.RowCount = 4;
	   _mainTableLayoutPanel.ColumnCount = 1;
	  
	   
	   _mainTableLayoutPanel.SetRow(_upperTableLayoutPanel, 0);
	   _mainTableLayoutPanel.SetRow(_middleTableLayoutPanel, 1);
	   _mainTableLayoutPanel.SetRow(_lowerTableLayoutPanel, 2);
	   _mainTableLayoutPanel.SetRow(_statusLabel, 3);
	   _mainTableLayoutPanel.Controls.Add(_upperTableLayoutPanel);
	   _mainTableLayoutPanel.Controls.Add(_middleTableLayoutPanel);
	   _mainTableLayoutPanel.Controls.Add(_lowerTableLayoutPanel);
	   _mainTableLayoutPanel.Controls.Add(_statusLabel);
	   
	    _mainTableLayoutPanel.Dock = DockStyle.Fill;
		
	
	   this.Controls.Add(_mainTableLayoutPanel);
	   this.StartPosition = FormStartPosition.CenterScreen;
	   this.Height = 400;
	  
		 
	 }
	 
	 
	
	
}