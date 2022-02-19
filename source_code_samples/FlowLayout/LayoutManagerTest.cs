using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;



public class LayoutManagerTest : Form {


  private Button _button1;
  private Button _button2;
  private Button _button3;
  private Button _button4;
  private Button _button5;
  private FlowLayoutPanel _flowLayoutPanel;
  
  
  public LayoutManagerTest(){
    _button1 = new Button();
    _button2 = new Button();
    _button3 = new Button();
    _button4 = new Button();
    _button5 = new Button();
    
    _button1.Text = "Hello";
    _button2.Text = "Hello";
    _button3.Text = "Hello";
    _button4.Text = "Hello";
    _button5.Text = "Hello";
    
    _flowLayoutPanel = new FlowLayoutPanel();
    
    _flowLayoutPanel.SuspendLayout();
    this.SuspendLayout();
     _flowLayoutPanel.Height = 56;
    _flowLayoutPanel.Width = 20;
    _flowLayoutPanel.AutoSize = true;
    _flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    _flowLayoutPanel.WrapContents = true;
    _flowLayoutPanel.Dock = DockStyle.Top;
   
   
    
    _flowLayoutPanel.Controls.Add(_button1);
    _flowLayoutPanel.Controls.Add(_button2);
    _flowLayoutPanel.Controls.Add(_button3);
    _flowLayoutPanel.Controls.Add(_button4);
    _flowLayoutPanel.Controls.Add(_button5);
    
   
    
    
    this.Controls.Add(_flowLayoutPanel);
    
   _flowLayoutPanel.ResumeLayout();
   this.ResumeLayout();
  }

  static void Main(){
     Application.Run(new LayoutManagerTest());
  }
}