using System;
using System.Windows.Forms;
using System.Drawing;

public class MainApp : Form {
  
  private ControlPanel _itsControlPanel;
  private Button       _showControlPanelButton;
  private Rat          _rat;
  private Floor        _floor;
  

  public MainApp(){
    _itsControlPanel = new ControlPanel(this);
	_itsControlPanel.Visible = false;
	
	
	_floor = new Floor();
	_floor.Text = "Robot Rat Floor";
	_floor.Visible = true;
	 
	 
	
	_rat = new Rat("rat.gif");
	
	_showControlPanelButton = new Button();
	_showControlPanelButton.Width = 200;
    _showControlPanelButton.Text = "Open Control Panel";
	_showControlPanelButton.Click += OpenControlPanelButtonHandler;
	this.Controls.Add(_showControlPanelButton);
	this.Height = 100;
	this.Width = 250;
  }

  public void ButtonOneHandler(object sender, EventArgs e){
   Console.WriteLine(((Button)sender).Text + " Clicked!");
     
      Graphics graphics = Graphics.FromImage(_floor.DrawingArea);
      _rat.Y -= 3;
	  graphics.Clear(Color.Gray);
      graphics.DrawImage(_rat.Image, _rat.Point);
      _floor.Invalidate();
  }
  
  public void ButtonTwoHandler(object sender, EventArgs e){
     Console.WriteLine(((Button)sender).Text + " Clicked!");
    
      Graphics graphics = Graphics.FromImage(_floor.DrawingArea);
      _rat.Y += 3;
	  graphics.Clear(Color.Gray);
      graphics.DrawImage(_rat.Image, _rat.Point);
      _floor.Invalidate();
  }
  
  public void ButtonThreeHandler(object sender, EventArgs e){
   Console.WriteLine(((Button)sender).Text + " Clicked!");
    
      Graphics graphics = Graphics.FromImage(_floor.DrawingArea);
      _rat.X += 3;
	  graphics.Clear(Color.Gray);
      graphics.DrawImage(_rat.Image, _rat.Point);
      _floor.Invalidate();
  }
  
  public void ButtonFourHandler(object sender, EventArgs e){
     Console.WriteLine(((Button)sender).Text + " Clicked!");
    
      Graphics graphics = Graphics.FromImage(_floor.DrawingArea);
      _rat.X -= 3;
	  graphics.Clear(Color.Gray);
      graphics.DrawImage(_rat.Image, _rat.Point);
      _floor.Invalidate();
  }
  

  public void OpenControlPanelButtonHandler(object sender, EventArgs e){
    _itsControlPanel.Visible = true;
	this.Visible = false;
  }







  public static void Main(){
    Application.Run( new MainApp());
  }

}