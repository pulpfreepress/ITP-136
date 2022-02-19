using System;

public class RobotRat {

  private bool[,] floor = null;
  private int rows = 0;  
  private int cols = 0;
  bool keep_going = true;

  public RobotRat(int rows, int cols){
    floor = new bool[rows,cols];
    this.rows = rows;
    this.cols = cols;
  }
  
  
  public void printFloor(){
    for(int i = 0; i<floor.GetLength(0); i++){
      for(int j = 0; j<floor.GetLength(1); j++){
        if(floor[i,j]){
            Console.Write("-"); 
           }else{
             Console.Write("0");
             }
      }
     Console.WriteLine();
    }
  }
  
  public void displayMenu(){
    Console.WriteLine("1. Pen Up");
    Console.WriteLine("2. Pen Down");
    Console.WriteLine("3. Turn Right");
    Console.WriteLine("4. Turn Left");
    Console.WriteLine("5. Move");
    Console.WriteLine("6. Print Floor");
    Console.WriteLine("7. Exit");
    Console.WriteLine();
    Console.WriteLine("Enter Menu Number: ");
  }
  
  
  public void processMenuChoice(){
   string input = Console.ReadLine();
   
   switch(input[0]){
     case '1': break;
     case '2': break;
     case '3': break;
     case '4': break;
     case '5': break;
     case '6': printFloor();
               break;
     case '7': keep_going = false;
               break;
     default:   Console.WriteLine("Invalid Menu Choice!");
               break;
    }
  }
  
  
  
  public void run(){
   while(keep_going){
     displayMenu();
     processMenuChoice();
   }
  }
  
  public static void Main(String[] args){
    RobotRat rr = new RobotRat(20,20);
   rr.run();
  
  }


} // end RobotRat class definition