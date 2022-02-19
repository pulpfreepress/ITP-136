using System;
using System.Windows.Forms;
using System.Drawing;

public class GUI : Form {

    private RadioButton rb1;
	private RadioButton rb2;
	private GroupBox gb;
	private Panel p1;


  public GUI(){
    this.InitializeComponent();
  }
  
  public void InitializeComponent(){
    rb1 = new RadioButton();
	rb1.Text = "CD";
	rb1.Checked = false;
	rb1.Location = new Point(10,20);
	rb1.Click += CD_Radio_Button_Handler;
	
	rb2 = new RadioButton();
	rb2.Text = "Tape";
	rb2.Location = new Point(10, 40);
	rb2.Checked = true;
	
	gb = new GroupBox();
	gb.Text = "Media Types";
	
	gb.Controls.Add(rb1);
	gb.Controls.Add(rb2);
	
	p1 = new Panel();
	p1.Visible = false;
	p1.BackColor = Color.Black;
	p1.Location = new Point(20, 60);
	
	this.Controls.Add(gb);
	this.Controls.Add(p1);
	
  }
  
  
  public void CD_Radio_Button_Handler(object sender, EventArgs e){
    p1.Visible = true;
  }
  
  public static void Main(){
     Application.Run(new GUI());
  }


}