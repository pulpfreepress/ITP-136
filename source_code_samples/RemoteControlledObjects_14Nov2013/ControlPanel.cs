using System;
using System.Windows.Forms;


public class ControlPanel : Form {
   
   private Button _add_rat_button;
   private Button _add_droid_button;
   private Button _move_button;
   private Button _speak_button;
   private Button _next_button;
   private FlowLayoutPanel _panel;
   


  public ControlPanel(MainApp ma){
    InitializeComponent(ma);
  
  }


  private void InitializeComponent(MainApp ma){
  
    _panel = new FlowLayoutPanel();
	_panel.Dock = DockStyle.Fill;
	
	_add_rat_button = new Button();
	_add_rat_button.Text = "Add Rat";
	_add_rat_button.Click += ma.AddRatHandler;
	
	_add_droid_button = new Button();
	_add_droid_button.Text = "Add Droid";
	_add_droid_button.Click += ma.AddDroidHandler;
	
	_speak_button = new Button();
	_speak_button.Text = "Speak";
	_speak_button.Click += ma.SpeakButtonHandler;
	
	
	_move_button = new Button();
	_move_button.Text = "Move";
	_move_button.Click += ma.MoveButtonHandler;
	
	_next_button = new Button();
	_next_button.Text = "Next";
	_next_button.Click += ma.NextButtonHandler;
	
	_panel.Controls.Add(_add_rat_button);
	_panel.Controls.Add(_add_droid_button);
	_panel.Controls.Add(_speak_button);
	_panel.Controls.Add(_next_button);
	_panel.Controls.Add(_move_button);
	
	this.Controls.Add(_panel);
	this.Text = "Control Panel";
	
  }


}