using System;
using System.Windows.Forms;


public class GUI : Form {

   private RobotRat _itsRobotRat = null;


   //Gui Components
   private FlowLayoutPanel panel1 = null;
   private Button button1 = null;
   private Button button2 = null;
   private Button button3 = null;
   
   
   public GUI(){
     _itsRobotRat = new RobotRat(20, 20);
     InitializeComponent();
   }
   
   
   private void InitializeComponent(){
     button1 = new Button();
     button1.Text = "Turn Left";
     button1.Click += new EventHandler(TurnLeftButtonHandler);
     
     button2 = new Button();
     button2.Text = "Turn Right";
     button2.Click += TurnRightButtonHandler;
     
     
     button3 = new Button();
     button3.Text = "Print Floor";
     button3.Click += PrintFloorButtonHandler;
     
     panel1 = new FlowLayoutPanel();
     
     panel1.Controls.Add(button1);
     panel1.Controls.Add(button2);
     panel1.Controls.Add(button3);
     this.Controls.Add(panel1);
     
   }
   
   



   public void TurnLeftButtonHandler(object sender, EventArgs e){
       _itsRobotRat.TurnLeft();
   }
   
   
   public void TurnRightButtonHandler(object sender, EventArgs e){
        _itsRobotRat.TurnRight();
   }
   
   
   
   public void PrintFloorButtonHandler(object sender, EventArgs e){
       _itsRobotRat.PrintFloor();
   }
   
   
   
   
   




   public static void Main(){
   
     Application.Run(new GUI());
   }

}