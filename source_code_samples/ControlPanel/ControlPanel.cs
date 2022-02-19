using System;
using System.Windows.Forms;
using System.Drawing;


public class ControlPanel : Form {
	
	// Fields
	private TableLayoutPanel _mainTableLayoutPanel;
	private TableLayoutPanel _upperTableLayoutPanel;
	private TableLayoutPanel _middleTableLayoutPanel;
	private Button _button1;
	
	private Button _northButton;
	private Button _southButton;
	private Button _eastButton;
	private Button _westButton;
	
	private TextBox _messageTextBox;
	
	// Properties
	public String Message {
		get { return _messageTextBox.Text; }
		set { _messageTextBox.Text = value; }	
	}
	
	
	// Constructor
	public ControlPanel(IAppEventHandler e){
		
		InitializeComponent(e);
	}
	
	
	private void InitializeComponent(IAppEventHandler e){
		
	  _mainTableLayoutPanel = new TableLayoutPanel();
      _mainTableLayoutPanel.RowCount = 3;
      _mainTableLayoutPanel.ColumnCount = 2;	
      //_mainTableLayoutPanel.BackColor = Color.Blue;
	  _mainTableLayoutPanel.Dock = DockStyle.Fill;
	  
	  _middleTableLayoutPanel = new TableLayoutPanel();
	  _middleTableLayoutPanel.RowCount = 3;
	  _middleTableLayoutPanel.ColumnCount = 3;
	  //_middleTableLayoutPanel.BackColor = Color.Red;
	  _middleTableLayoutPanel.Dock = DockStyle.Fill;
	  
	  _upperTableLayoutPanel = new TableLayoutPanel();
	  _upperTableLayoutPanel.RowCount = 3;
	  _upperTableLayoutPanel.ColumnCount = 2;
	  //_upperTableLayoutPanel.BackColor = Color.Pink;
	  _upperTableLayoutPanel.Dock = DockStyle.Fill;
	  
	  _northButton = new Button();
	  _northButton.Text = "North";
	  _northButton.Click += e.UniversalClickHandler;
	  _northButton.Dock = DockStyle.Fill;
	  
	  _southButton = new Button();
	  _southButton.Text = "South";
	  _southButton.Click += e.UniversalClickHandler;
	  _southButton.Dock = DockStyle.Fill;
	  
	  _eastButton = new Button();
	  _eastButton.Text = "East";
	  _eastButton.Click += e.UniversalClickHandler;
	  _eastButton.Dock = DockStyle.Fill;
	  
	  _westButton = new Button();
	  _westButton.Text = "West";
	  _westButton.Click += e.UniversalClickHandler;
	  _westButton.Dock = DockStyle.Fill;
	  
	  _middleTableLayoutPanel.SetRow(_northButton, 0);
	  _middleTableLayoutPanel.SetColumn(_northButton, 1);
	  _middleTableLayoutPanel.Controls.Add(_northButton);
	  
	  
	  _middleTableLayoutPanel.SetRow(_westButton, 1);
	  _middleTableLayoutPanel.SetColumn(_westButton, 0);
	  _middleTableLayoutPanel.Controls.Add(_westButton);
	  
	  _middleTableLayoutPanel.SetRow(_eastButton, 1);
	  _middleTableLayoutPanel.SetColumn(_eastButton, 2);
	  _middleTableLayoutPanel.Controls.Add(_eastButton);
	  
	  _middleTableLayoutPanel.SetRow(_southButton, 2);
	  _middleTableLayoutPanel.SetColumn(_southButton, 1);
	  _middleTableLayoutPanel.Controls.Add(_southButton);
	  
	  
	  
	  _messageTextBox = new TextBox();
	  _messageTextBox.Multiline = true;
	  _messageTextBox.ScrollBars = ScrollBars.Both;
	  _messageTextBox.Dock = DockStyle.Fill;
	 
	  
	  
	  _button1 = new Button();
	  _button1.Text = "Click Me!";
	  _button1.Dock = DockStyle.Fill;
	  
	  
	  _mainTableLayoutPanel.SetColumn(_button1, 0);
	  _mainTableLayoutPanel.SetRow(_button1, 0);
	  _mainTableLayoutPanel.Controls.Add(_button1);
	  
	  _mainTableLayoutPanel.SetColumn(_upperTableLayoutPanel, 1);
	  _mainTableLayoutPanel.SetRow(_upperTableLayoutPanel, 0);
	  _mainTableLayoutPanel.Controls.Add(_upperTableLayoutPanel);
	  
	  _mainTableLayoutPanel.SetRow(_middleTableLayoutPanel, 1);
	  _mainTableLayoutPanel.SetColumnSpan(_middleTableLayoutPanel,2);
	  _mainTableLayoutPanel.Controls.Add(_middleTableLayoutPanel);
	  
	  _mainTableLayoutPanel.SetRow(_messageTextBox, 2);
	  _mainTableLayoutPanel.SetColumnSpan(_messageTextBox, 2);
      _mainTableLayoutPanel.Controls.Add(_messageTextBox);
      
	  
	  
	  
	  this.Controls.Add(_mainTableLayoutPanel);
		
	}
	
	
	
} 