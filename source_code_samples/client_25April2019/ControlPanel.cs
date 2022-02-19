using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Sockets;
using System.IO;
using System.Net;


public class ControlPanel : Form {
	
	// Fields
	private TableLayoutPanel _mainTableLayoutPanel;
	private TableLayoutPanel _upperTableLayoutPanel;
	private TableLayoutPanel _middleTableLayoutPanel;

	
	private Button _northButton;
	private Button _southButton;
	private Button _eastButton;
	private Button _westButton;
	
	private Button _connectButton;
	private Button _disconnectButton;
	private Label _ip_label;
	private Label _port_label;
	private TextBox _port_textbox;
	private TextBox _ip_textbox;
	
	private GroupBox _groupbox;
	private RadioButton _rat_radio_button;
	private RadioButton _tank_radio_button;
	private RadioButton _ship_radio_button;
	
	private Button _create_button;
	private TableLayoutPanel _upper_left_panel;
	
	
	
	private TextBox _messageTextBox;
	
	// Properties
	public String Message {
		get { return _messageTextBox.Text; }
		set { _messageTextBox.Text = value; }	
	}
	
	public IPAddress IpAddress {
		get { 
		  IPAddress address = null;
	      try {
		    address = IPAddress.Parse(_ip_textbox.Text); 
		  }catch(Exception){
			 address = IPAddress.Parse("127.0.0.1");
		  }
		  return address;
		}
	}
	
	
	public int Port {
	  get {
		   int port = 5000;
		   try {
		    port = Int32.Parse(_port_textbox.Text);
		   }catch(Exception){
			   _messageTextBox.Text += "Hey a-hole...enter a valid port!";
		   }
		   return port;  
	  }
	}
	
	
	public string RobotType {
		
		get {
			string type = String.Empty;
			foreach(Control c in _groupbox.Controls){
				if(((RadioButton)c).Checked){
					type = c.Text;
				}
			}
			return type;
			
		}
	}
	
	
	
	// Constructor
	public ControlPanel(IAppEventHandler e){
		
		InitializeComponent(e);
	}
	
	
	private void InitializeComponent(IAppEventHandler e){
		
	  _mainTableLayoutPanel = new TableLayoutPanel();
      _mainTableLayoutPanel.RowCount = 3;
      _mainTableLayoutPanel.ColumnCount = 2;	
	  _mainTableLayoutPanel.Dock = DockStyle.Fill;
	  
	  _middleTableLayoutPanel = new TableLayoutPanel();
	  _middleTableLayoutPanel.RowCount = 3;
	  _middleTableLayoutPanel.ColumnCount = 3;
	  _middleTableLayoutPanel.Dock = DockStyle.Fill;
	  
	  _upperTableLayoutPanel = new TableLayoutPanel();
	  _upperTableLayoutPanel.RowCount = 3;
	  _upperTableLayoutPanel.ColumnCount = 2;
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
	  
	  
	  _upper_left_panel = new TableLayoutPanel();
	  _upper_left_panel.RowCount = 2;
	  _upper_left_panel.ColumnCount = 1;
	  _upper_left_panel.Size = new Size(300, 150);
	  
	  _groupbox = new GroupBox();
	  _groupbox.Dock = DockStyle.Fill;
	  _groupbox.Size = new Size(100, 100);
	  _rat_radio_button = new RadioButton();
	  _rat_radio_button.Text = "Rat";
	  _rat_radio_button.Location = new Point(10, 10);
	  _rat_radio_button.Checked = true;
	  
	  
	  _tank_radio_button = new RadioButton();
	  _tank_radio_button.Text = "Tank";
	  _tank_radio_button.Location = new Point(10, 40);
	 
	  _ship_radio_button = new RadioButton();
	  _ship_radio_button.Text = "Ship";
	  _ship_radio_button.Location = new Point(10, 70);
	
	  
	  _create_button = new Button();
	  _create_button.Text = "Create";
	  _create_button.Click += e.UniversalClickHandler;
	  
	  _groupbox.Controls.Add(_rat_radio_button);
	  _groupbox.Controls.Add(_tank_radio_button);
	  _groupbox.Controls.Add(_ship_radio_button);
	  _upper_left_panel.SetRow(_groupbox, 0);
	  _upper_left_panel.SetRow(_create_button, 1);
	  
	  _upper_left_panel.Controls.Add(_groupbox);
	  _upper_left_panel.Controls.Add(_create_button);
	  
	  _mainTableLayoutPanel.SetRow(_upper_left_panel, 0);
	  _mainTableLayoutPanel.SetColumn(_upper_left_panel, 0);
	  _mainTableLayoutPanel.Controls.Add(_upper_left_panel);
	  
	  
	  
	  
	  
	  
	  
	  _ip_label = new Label();
	  _ip_label.Text = "IP Address: ";
	  _ip_label.Dock = DockStyle.Fill;
	  
	  _port_label = new Label();
	  _port_label.Text = "Port: ";
	  _port_label.Dock = DockStyle.Fill;
	  
	  _ip_textbox = new TextBox();
	  _ip_textbox.Text = "127.0.0.1";
	  _ip_textbox.Dock = DockStyle.Fill;
	  
	  _port_textbox = new TextBox();
	  _port_textbox.Text = "5000";
	  _port_textbox.Dock = DockStyle.Fill;
	  
	  _connectButton = new Button();
	  _connectButton.Text = "Connect";
	  _connectButton.Click += e.UniversalClickHandler;
	  _connectButton.Dock = DockStyle.Fill;
	  
	  _disconnectButton = new Button();
	  _disconnectButton.Text = "Disconnect";
	  _disconnectButton.Click += e.UniversalClickHandler;
	  _disconnectButton.Dock = DockStyle.Fill;
	  
	  
	  _upperTableLayoutPanel.SetRow(_ip_label, 0);
	  _upperTableLayoutPanel.SetColumn(_ip_label, 0);
	  _upperTableLayoutPanel.SetRow(_ip_textbox, 0);
	  _upperTableLayoutPanel.SetColumn(_ip_textbox, 1);
	  
	  _upperTableLayoutPanel.SetRow(_port_label, 1);
	  _upperTableLayoutPanel.SetColumn(_port_label, 0);
	  _upperTableLayoutPanel.SetRow(_port_textbox, 1);
	  _upperTableLayoutPanel.SetColumn(_port_textbox, 1);
	  
	  _upperTableLayoutPanel.SetRow(_connectButton, 2);
	  _upperTableLayoutPanel.SetColumn(_connectButton, 0);
	  _upperTableLayoutPanel.SetRow(_disconnectButton, 2);
	  _upperTableLayoutPanel.SetColumn(_disconnectButton, 1);
	  
	  _upperTableLayoutPanel.Controls.Add(_ip_label);
	  _upperTableLayoutPanel.Controls.Add(_ip_textbox);
	  _upperTableLayoutPanel.Controls.Add(_port_label);
	  _upperTableLayoutPanel.Controls.Add(_port_textbox);
	  _upperTableLayoutPanel.Controls.Add(_connectButton);
	  _upperTableLayoutPanel.Controls.Add(_disconnectButton);
	  
	  
	  
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
	  _messageTextBox.Click += e.NextRobotHandler;
		
	}
	
	
	
} 