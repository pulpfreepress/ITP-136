using System;

public class RobotRat {

  // constants
  private const char SET_PEN_UP = '1';
  private const char SET_PEN_DOWN = '2';
  private const char TURN_LEFT = '3';
  private const char TURN_RIGHT = '4';
  private const char MOVE = '5';
  private const char PRINT_FLOOR = '6';
  private const char EXIT = '7';
  
  // fields
  private bool keep_going = true;
  
  // Constructor
  public RobotRat(){
   Console.Clear();
   Console.Beep();
  }
  
  public void PrintMenu(){
    Console.WriteLine(" -- Robot Rat Control Menu --");
	Console.WriteLine("    1. Set Pen Up ");
	Console.WriteLine("    2. Set Pen Down ");
	Console.WriteLine("    3. Turn Left ");
	Console.WriteLine("    4. Turn Right ");
	Console.WriteLine("    5. Move ");
	Console.WriteLine("    6. Print Floor");
	Console.WriteLine("    7. Exit ");
  }
  
  
  public void ProcessMenuChoice(){
    Console.Write(" Please enter a command number: ");
	string input_string = Console.ReadLine();
	
	switch(input_string[0]){
	  case SET_PEN_UP: SetPenUp();
	                   break;
	  case SET_PEN_DOWN: SetPenDown();
	                     break;
	  case TURN_LEFT: TurnLeft();
	                  break;
	  case TURN_RIGHT: TurnRight();
	                   break;
	  case MOVE:  Move();
	              break;
	  case PRINT_FLOOR:  PrintFloor();
	                     break;
	  case EXIT:  Exit();
	              break;
	  default: Console.Write("Please enter a valid command choice: ");
	           break;
	
	}
  
  } // end ProcessMenuChoice() method
  
  
  
  public void SetPenUp() { 
     Console.WriteLine("The pen is up!");
  }
  
  public void SetPenDown(){
     Console.WriteLine("The pen is down!");
  }
  
  public void TurnLeft(){
     Console.WriteLine("Rat turned left!");
  }
  
  public void TurnRight(){
    Console.WriteLine("Rat turned right!");
  }
  
  public void Move(){
     Console.WriteLine("Rat moved...!");
  }
  
  public void PrintFloor(){
    Console.WriteLine("Printed the floor!");
  }
  
  public void Exit(){
    keep_going = false;
  }
  
  
  
  public void Go(){
    while(keep_going){
	  this.PrintMenu();
	  this.ProcessMenuChoice();
	}
  }
  
  
  public static void Main(){
    RobotRat rr = new RobotRat();
	rr.Go();
	
    
  } // end Main() method

} // end RobotRat class definition