using System;
using System.Windows.Forms;

public class MainApp {
  
  public static void Main(){
    
	EventProcessor ep = new EventProcessor();
    MyForm mf = new MyForm();
	mf.Button1Delegate = ep.ButtonHandlerDelegateProperty;
	
    Application.Run(mf);
  }
}