using System;
using System.Drawing;

public class RobotRat {

  // constants
  private const char PEN_UP = '1';
  private const char PEN_DOWN = '2';
  private const char TURN_LEFT = '3';
  private const char TURN_RIGHT = '4';
  private const char MOVE = '5';
  private const char PRINT_FLOOR = '6';
  private const char EXIT = '7';
  
  private bool keep_going = true;
  
  private enum PenPosition { UP, DOWN };
  private PenPosition pen_position = PenPosition.UP;
  
  private enum Direction { NORTH, SOUTH, EAST, WEST };
  private Direction direction = Direction.EAST;
  
  private bool[,] floor;
  
  
  


  // default constructor
  public RobotRat():this(20,20){}
  
  public RobotRat(int rows, int cols){
    floor = new bool[rows, cols];
	this.PrepScreen();
  }
  
  
  
  public void PrepScreen(){
    Console.BackgroundColor = ConsoleColor.Blue;
	Console.Clear();
	Console.Beep(4000,340);
  }
  
  public void PrintMenu(){
    Console.WriteLine("   RobotRat Control Menu\n\r");
	Console.WriteLine("      1. Pen Up");
	Console.WriteLine("      2. Pen Down");
	Console.WriteLine("      3. Turn Left");
	Console.WriteLine("      4. Turn Right");
	Console.WriteLine("      5. Move");
	Console.WriteLine("      6. Print Floor");
	Console.WriteLine("      7. Exit");
	Console.WriteLine();
	Console.Write("Please enter a menu choice: ");
  }
  
  public void ProcessMenuCommand(){
    string input = Console.ReadLine();
	
	switch(input[0]){
	  case PEN_UP:       SetPenUp();
	                     break;
	  case PEN_DOWN:     SetPenDown();
	                     break;
	  case TURN_LEFT :   TurnLeft();
	                     break;
	  case TURN_RIGHT :  TurnRight();
	                     break;
	  case MOVE :        Move();
	                     break;
	  case PRINT_FLOOR : PrintFloor();
	                     break;
	  case EXIT :        Exit();
	                     break;
	  default :          Console.Beep(3566, 500);
	                     break;
	
	}
  
  } // end ProcessMenuCommand()

  
  public void SetPenUp(){
    pen_position = PenPosition.UP;
  }  
  
  public void SetPenDown(){
    pen_position = PenPosition.DOWN;
  } 
  
  public void TurnLeft(){
    switch(direction){
	  case Direction.NORTH : direction = Direction.WEST;
	                         break;
	  case Direction.EAST : direction = Direction.NORTH;
	                        break;
	  case Direction.SOUTH : direction = Direction.EAST;
	                         break;
	  case Direction.WEST: direction = Direction.SOUTH;
	                       break;
	  default: break;
	}
	
  }
  
  public void TurnRight(){
      switch(direction){
	  case Direction.NORTH : direction = Direction.EAST;
	                         break;
	  case Direction.EAST : direction = Direction.SOUTH;
	                        break;
	  case Direction.SOUTH : direction = Direction.WEST;
	                         break;
	  case Direction.WEST: direction = Direction.NORTH;
	                       break;
	  default: break;
	}
  }
  
  public void Move(){
    Console.WriteLine("Move");
  }
  
  public void PrintFloor(){
     for(int i = 0; i<floor.GetLength(0); i++){
	   for(int j = 0; j<floor.GetLength(1); j++){
	    if(floor[i,j]){
		  Console.Write('-');
		}else {
		  Console.Write('0');
		}
	   }
	   Console.WriteLine();
	 }
  }
  
  public void Exit(){
    keep_going = false;
	Console.Clear();
	Console.WriteLine("Thank you for using RobotRat!");
  }
  
  
  public void Run(){
    while(keep_going){
	  PrintState();
	  PrintMenu();
	  ProcessMenuCommand();
	}
  }
  
  public void PrintState(){
    Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine("Rat is facing: " + direction + " Pen is: " + pen_position);
	Console.ForegroundColor = ConsoleColor.White;
	
  }
  
  public static void Main(String[] args){
    RobotRat rr = new RobotRat();
	rr.Run();
  } 
  
} // End class definition