using System;
using System.Windows.Forms;

public class MyForm : Form {
  
  private Button _button1;
  private Delegate _button_1_delegate;
  
  
  public Delegate Button1Delegate {
    get { return _button_1_delegate; }
	set { _button_1_delegate = value;  }
  }
  
  public MyForm(){
     _button1 = new Button();
	 _button1.Text = "Click Me!";
	 _button1.Click += ButtonOneClickHandler;
	 this.Controls.Add(_button1);
	 this.Text = "Delegate Demo";
	 
  }
  
  public void ButtonOneClickHandler(object sender, EventArgs e){
     _button_1_delegate.DynamicInvoke();
  }
  
  
  
  
  
}