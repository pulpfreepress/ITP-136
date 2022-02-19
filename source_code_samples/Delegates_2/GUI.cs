using System;
using System.Windows.Forms;


public class GUI : Form {

   private Button _button1;
   private Button _button2;
   private Button _button3;
   private Button _button4;
   
   TableLayoutPanel _tablePanel;
   
   
   private Delegate _buttonOneDelegate;
   private Delegate _buttonTwoDelegate;
   private Delegate _buttonThreeDelegate;
   private Delegate _buttonFourDelegate;
   
   
   
   public Delegate ButtonOneDelegate {
     get { return _buttonOneDelegate; }
     set { _buttonOneDelegate = value; }
   }
   
   
   
   public Delegate ButtonTwoDelegate {
      get { return _buttonTwoDelegate; }
      set { _buttonTwoDelegate = value; }
   
   }
   
   
   public Delegate ButtonThreeDelegate {
         get { return _buttonThreeDelegate; }
         set { _buttonThreeDelegate = value; }
      
   }
   
   public Delegate ButtonFourDelegate {
         get { return _buttonFourDelegate; }
         set { _buttonFourDelegate = value; }
      
   }
   
   
   
   
   
   
   public GUI(){
   
     InitializeComponent();
   }
   
   
   private void InitializeComponent(){
   
   _tablePanel = new TableLayoutPanel();
   _tablePanel.RowCount = 2;
   _tablePanel.ColumnCount = 2;
   _tablePanel.Dock = DockStyle.Fill;
   
   _button1 = new Button();
   _button1.Text = "Button1";
   _button1.Click += ButtonOneClickHandler;
   
   _button2 = new Button();
   _button2.Text = "Button2";
   _button2.Click += ButtonTwoClickHandler;
   
   _button3 = new Button();
   _button3.Text = "Button3";
   _button3.Click += ButtonThreeClickHandler;
   
   _button4 = new Button();
   _button4.Text = "Button4";
   _button4.Click += ButtonFourClickHandler;
   
   _tablePanel.Controls.Add(_button1);
   _tablePanel.Controls.Add(_button2);
   _tablePanel.Controls.Add(_button3);
   _tablePanel.Controls.Add(_button4);
   
   this.Controls.Add(_tablePanel);
   this.Text = "Remote Event Handler Demo";
   
 
   }
   
   
   
   public void ButtonOneClickHandler(object sender, EventArgs e){
     
      _buttonOneDelegate.DynamicInvoke();
     
     }
     
     public void ButtonTwoClickHandler(object sender, EventArgs e){
       
      _buttonTwoDelegate.DynamicInvoke();
       
     }
     
     public void ButtonThreeClickHandler(object sender, EventArgs e){
       
        _buttonThreeDelegate.DynamicInvoke();
       
     }
     
     public void ButtonFourClickHandler(object sender, EventArgs e){
       
        _buttonFourDelegate.DynamicInvoke();
       
     }



}