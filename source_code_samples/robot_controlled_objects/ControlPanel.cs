using System;
using System.Windows.Forms;

public class ControlPanel : Form {

   private FlowLayoutPanel _panel;
   private Button _moveButton;
   private Button _turnLeftButton;
   private Button _turnRightButton;
   private Button _nextRobotButton;
   private Button _addRobotButton;
   
   public ControlPanel(Server s){
     this.InitializeComponent(s);
   }
   
   private void InitializeComponent(Server s){
     _panel = new FlowLayoutPanel();
     
     _moveButton = new Button();
     _moveButton.Text = "Move";
     _moveButton.Click += s.MoveHandler;
     
     _turnLeftButton = new Button();
     _turnLeftButton.Text = "Turn Left";
     _turnLeftButton.Click += s.TurnLeftHandler;
     
     _turnRightButton = new Button();
     _turnRightButton.Text = "Turn Right";
     _turnRightButton.Click += s.TurnRightHandler;
     
     _nextRobotButton = new Button();
     _nextRobotButton.Text = "Next Robot";
     _nextRobotButton.Click += s.NextRobotHandler;
     
     _addRobotButton = new Button();
     _addRobotButton.Text = "Add Robot";
     _addRobotButton.Click += s.AddRobotHandler;
     
     _panel.Controls.Add(_turnLeftButton);
     _panel.Controls.Add(_turnRightButton);
     _panel.Controls.Add(_moveButton);
     _panel.Controls.Add(_nextRobotButton);
     _panel.Controls.Add(_addRobotButton);
     _panel.Dock = DockStyle.Fill;
     
     this.Controls.Add(_panel);
     this.Text = "Robot Control Panel";
   }

}