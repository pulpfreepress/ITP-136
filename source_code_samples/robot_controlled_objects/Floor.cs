using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

public class Floor : Form {

  private List<ControllableObject> _robots;
  
  public Floor(List<ControllableObject> robots){
    _robots = robots;
    this.InitializeComponent();
  }
  
  private void InitializeComponent(){
     this.Height = 400;
     this.Width = 400;
     this.Text = "Robot Floor";
    
  }
  
  public void Paint_Handler(Object sender, PaintEventArgs args){
    foreach(ControllableObject robot in _robots){
      args.Graphics.DrawImage(robot.Picture, robot.X, robot.Y);
    }
  }


}

