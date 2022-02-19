using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

public class Floor : Form {
	
	private List<IControllable> _robots;
	
	public Floor(List<IControllable> robots){
		_robots = robots;
		InitializeComponent();
	}
	
	private void InitializeComponent(){
		Height = 400;
		Width = 400;
		Text = "Robot Floor";
	}
	
	protected override void OnPaint(PaintEventArgs e){
		foreach(IControllable robot in _robots){
			e.Graphics.DrawImage(robot.Picture, robot.X, robot.Y);
		}
		//base.OnPaint(e);
		
	}
	
}