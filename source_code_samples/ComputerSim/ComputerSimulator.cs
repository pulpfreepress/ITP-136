using System.Windows.Forms;
using System;
using System.Drawing;


public class ComputerSimulator : Form {

  private int[] memory = null;
  private InputDialog input_dialog = null;
  
  private TextBox textbox1 = null;
  private Button button1 = null;
  private Button button2 = null;
  
  
  
  private const int READ = 10;
  private const int WRITE = 11;
  
  private const int HALT = 43;


  /***************************************************
     Constructor
  *************************************************/
  public ComputerSimulator(){
   memory = new int[100];
   input_dialog = new InputDialog(this);
   this.setUpGUI();
   
  }
  
  
   /****************************************************
     setUpGUI
   ****************************************************/
  public void setUpGUI(){
    textbox1 = new TextBox();
    textbox1.Location = new Point(10, 10);
    textbox1.Multiline = true;
    textbox1.ScrollBars = ScrollBars.Vertical;
    textbox1.Height = 150;
    
    button1 = new Button();
    button1.Text = "Load";
    button1.Location = new Point(150, 100);
    button1.Click += new EventHandler(this.loadButtonClick);
    
    
    button2 = new Button();
    button2.Text = "Run";
    button2.Location = new Point(150, 140);
    button2.Click += new EventHandler(this.runButtonClick);
    
    this.Controls.Add(textbox1);
    this.Controls.Add(button1);
    this.Controls.Add(button2);
  }


  
  /******************************************
     Input Dialog Enter button event handler
  ********************************************/
  public void onEnterButtonClick(Object source, EventArgs ea){
    
    
    input_dialog.Hide();
  }
  
  
  /****************************************
   Load button event handler
  *****************************************/
  public void loadButtonClick(Object source, EventArgs ea){
    Console.WriteLine(((Button)source).Text);
    Console.WriteLine();
    this.loadMemoryFromTextBox();
    this.dumpMemory();
  
  }
  
  
  public void runButtonClick(Object source, EventArgs ea){
    this.execute();
  }
  
  
  /****************************************
    showDialog method
  ***************************************/
  public void showDialog(){
     input_dialog.ShowDialog();
     
  }
  
  
  public void execute(){
    int instruction = 0;
    int operation_code = 0;
    int operand = 0;
    int program_counter = 0;
    bool keep_going = true;
    
    while(keep_going){
      instruction = memory[program_counter++]; 
      operation_code = instruction / 100;
      operand = instruction % 100;
  
      switch(operation_code){
       case READ : input_dialog.ShowDialog();
                   memory[operand] = input_dialog.Number;
                   break;
       case WRITE : Console.WriteLine(memory[operand]);
                    break;
                    
       case HALT:  keep_going = false;
                   break;
      
      }
  
    } // end while
  
  } // end execute method
  
  
  
  /**********************************
    showGUI method
  **********************************/
  public void showGUI(){
    this.ShowDialog();
  }


  private void loadMemoryFromTextBox(){
  
    char[] charSeparators = new char[] {'\n'};
    String instructionString = textbox1.Text;
    String[] instructions = instructionString.Split(charSeparators);
    
    
    for(int i=0; i<instructions.Length; i++){
      try{
       memory[i] = Convert.ToInt32(instructions[i]);
       }catch(FormatException ignored){
        Console.WriteLine(ignored.ToString());
       }
    }  
  }
  
  
  public void dumpMemory(){
    for(int i=0; i<memory.Length; i++){
      if((i%10) == 0){
       Console.WriteLine();
      }
        
      Console.Write(memory[i] + " ");
   
    }
  }
 
  
  /**********************************************
    Main method
  ***********************************************/
  public static void Main(String[] args){
     ComputerSimulator cs = new ComputerSimulator();
     cs.showGUI();
     
  } // end main
} // end class definition