using System;
using System.Windows.Forms;
using System.Drawing;


namespace Person_Test {
   
  public class GUI : Form {
  
    private TextBox   textbox_1;
    private  Button    button_1;
    private MainApp   main_app;
    
    public GUI(MainApp ma){
      main_app = ma;
      setUpGUI();
    
    }
    
    
    public void setUpGUI(){
     
     textbox_1 = new TextBox();
     textbox_1.Location = new Point(10, 10);
     textbox_1.Multiline = true;
     textbox_1.ScrollBars = ScrollBars.Vertical;
     textbox_1.Height = 150;
     
     button_1 = new Button();
     button_1.Text = "Click Me!";
     button_1.Location = new Point(200, 200);
     button_1.Click += new EventHandler(main_app.OnButton1Click);
     
     this.Controls.Add(button_1);
     this.Controls.Add(textbox_1);
     //this.ShowDialog();
     
    }
    
    public string getText(){
       return textbox_1.Text;
    }
    
    public void showGUI(){
      this.ShowDialog();
    }

    
    public string TextBoxText {
       get { return textbox_1.Text; }
       set { textbox_1.Text = value;}
    
    
    }
 } 
} 