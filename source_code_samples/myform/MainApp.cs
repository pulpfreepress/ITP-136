using System;
using System.Windows.Forms;
using System.Threading;

public class MainApp {

   private MyForm _itsform = null;
   
   public MainApp(){
	
   }
   
   public void Run(){
      Application.EnableVisualStyles();
     Application.SetCompatibleTextRenderingDefault(false);
	 _itsform = new MyForm(this);
     Application.Run(_itsform);
   }
     
	 
	  public void tableLayoutPanel1_Paint(object sender, PaintEventArgs e){

        }

        public void button1_Click(object sender, EventArgs e){
           _itsform.TextFieldText += "Hello\r\n";
        }

        public void button1_MouseClick(object sender, MouseEventArgs e){
            Console.WriteLine("Mouse Click");
        }
		
		
	  
		[STAThread]
        static void Main()
        {
		    MainApp ma1 = new MainApp();
			MainApp ma2 = new MainApp();
            Thread t1 = new Thread(ma1.Run);
			Thread t2 = new Thread(ma2.Run);
			t1.Start();
			t2.Start();
			new MainApp();
        }

}