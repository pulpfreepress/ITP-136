using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;



namespace FileIOTester {


  public class FileIOTester {
     private Form    main_form;
     private Button   button_1;
     private Button   button_2;
     private Button   button_3;
     private TextBox textbox_1;
     
     
     public FileIOTester(){
     
       this.setUpGUI();
     
     }
     
     public void setUpGUI(){
     
       main_form = new Form();
       main_form.Resize += new EventHandler(onWindowResize);
       
       textbox_1 = new TextBox();
       textbox_1.Location = new Point(10, 10);
       textbox_1.Multiline = true;
       textbox_1.ScrollBars = ScrollBars.Vertical;
       textbox_1.Height = 150;
            
       button_1 = new Button();
       button_1.Text = "Create Program File!";
       button_1.Location = new Point(main_form.Width - 180, main_form.Height-70);
       button_1.Width = 150;
       button_1.Click += new EventHandler(onButton1Click);
       
       button_2 = new Button();
       button_2.Text = "Load Program File!";
       button_2.Location = new Point(main_form.Width - 180, main_form.Height-100);
       button_2.Width = 150;
       button_2.Click += new EventHandler(onButton2Click);
       
       button_3 = new Button();
       button_3.Text = "Clear Textbox!";
       button_3.Location = new Point(main_form.Width - 180, main_form.Height-140);
       button_3.Width = 150;
       button_3.Click += new EventHandler(onButton3Click);
        
       main_form.Controls.Add(button_1);
       main_form.Controls.Add(button_2);
       main_form.Controls.Add(button_3);
       main_form.Controls.Add(textbox_1);
       main_form.ShowDialog();
     
     }
     
     
     public void onButton1Click(Object o, EventArgs ea){
        Console.WriteLine("Creating Program File");
        this.createProgramFile();
     
     }
     
     public void onButton2Click(Object o, EventArgs ea){
        Console.WriteLine("Loading Program File");
        this.loadProgramFile();
          
     }
     
     public void onButton3Click(Object o, EventArgs ea){
       Console.WriteLine("Clearing Textbox");
       textbox_1.Text = "";  
     }
     
     
     public void onWindowResize(Object o, EventArgs ea){
        button_1.Location = new Point(main_form.Width - 180, main_form.Height-70);
        button_2.Location = new Point(main_form.Width - 180, main_form.Height-100);
        button_3.Location = new Point(main_form.Width - 180, main_form.Height-140);
        textbox_1.Height = main_form.Height - 70;
        Console.WriteLine(main_form.Width);
        Console.WriteLine(main_form.Height);
     }
     
     public void createProgramFile(){
       try{
        StreamWriter sw = new StreamWriter("program.txt");
        sw.WriteLine(textbox_1.Text);
        sw.Close();
       }catch(Exception e){
          Console.WriteLine(e.ToString());
        }
     
     }
     
     
     public void loadProgramFile(){
      try{
          StreamReader sr = new StreamReader("program.txt");
          textbox_1.Text = sr.ReadToEnd();
          sr.Close();
      }catch(Exception e){
          Console.WriteLine(e.ToString());
        }
     
     }
  
  
    public static void Main(String[] args){
       new FileIOTester();
    
    } //end main
  } // end class
}//end namespace

