using System;
using System.ComponentModel;
using System.Windows.Forms;

public class ControlPanel : Form {
	
	private FlowLayoutPanel _panel;
	private Button _moveButton;
	private Button _turnLeftButton;
	private Button _turnRightButton;
	private Button _nextRobotButton;
	private Button _addRobotButton;
	
	public ControlPanel(IHandler handler){
		InitializeComponent(handler);
	}
	
	
	private void InitializeComponent(IHandler handler){
		_panel = new FlowLayoutPanel();
		
		_moveButton = new Button();
		_moveButton.Text = "Move";
		_moveButton.Click += handler.ButtonClickHandler;
		
		_turnLeftButton = new Button();
		_turnLeftButton.Text = "Turn Left";
		_turnLeftButton.Click += handler.ButtonClickHandler;
		
		_turnRightButton = new Button();
		_turnRightButton.Text = "Turn Right";
		_turnRightButton.Click += handler.ButtonClickHandler;
		
		_nextRobotButton = new Button();
		_nextRobotButton.Text = "Next Robot";
		_nextRobotButton.Click += handler.ButtonClickHandler;
		
		_addRobotButton = new Button();
		_addRobotButton.Text = "Add Robot";
		_addRobotButton.Click += handler.ButtonClickHandler;
		
		_panel.Controls.Add(_addRobotButton);
		_panel.Controls.Add(_turnLeftButton);
		_panel.Controls.Add(_turnRightButton);
		_panel.Controls.Add(_moveButton);
		_panel.Controls.Add(_nextRobotButton);
		_panel.Dock = DockStyle.Fill;
		
		this.Controls.Add(_panel);
		this.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Robot Control Panel";
	}
	
}