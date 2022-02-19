/******************************************
Project: Robot Car
Author: Rick Miller
Date: 9 February 2012

*******************************************/
using System;


public class RobotCar {

  // Fields and Constants
     private bool keep_going = true;
	 private bool[,] track = null;
	 
	 private const char TURN_SPRAYER_ON = '1';
	 private const char TURN_SPRAYER_OFF = '2';
	 private const char TURN_LEFT = '3';
	 private const char TURN_RIGHT = '4';
	 private const char MOVE = '5';
	 private const char PRINT_TRACK = '6';
	 private const char EXIT = '7';
	 
	 enum SprayerState { Off, On }
	 SprayerState its_sprayer_state = SprayerState.Off;
	 
	 enum Directions { North, South, East, West }
	 Directions its_direction = Directions.East;


  public RobotCar():this(10, 10) { }
  
  
  public RobotCar(int rows, int cols) {
    Console.Clear();
    track = new bool[rows, cols];
  }
  
  public void DisplayMenu(){
   Console.WriteLine();
   Console.WriteLine("		RobotCar Control Menu");
   Console.WriteLine();
   Console.WriteLine("		1. Turn Sprayer On");
   Console.WriteLine("		2. Turn Sprayer Off");
   Console.WriteLine("		3. Turn Left");
   Console.WriteLine("		4. Turn Right");
   Console.WriteLine("		5. Move");
   Console.WriteLine("		6. Print Track");
   Console.WriteLine("		7. Exit");
   Console.WriteLine();
   Console.Write("		Please enter menu number 1-7: ");
  }
  
  
  public void ProcessMenuChoice(){
     string raw_input = Console.ReadLine();
	 char menu_choice; 
	 
	 try{
       menu_choice = raw_input[0];  // might throw an exception
	 }catch(Exception){
	   menu_choice = '0';           // set menu_choice to 0 if exception occurs
	 }
	 
	 switch(menu_choice){
	   case TURN_SPRAYER_ON : TurnSprayerOn();
	                          break;
	   case TURN_SPRAYER_OFF : TurnSprayerOff();
	                           break;
	   case TURN_LEFT        : TurnLeft();
	                           break;
	   case TURN_RIGHT       : TurnRight();
	                           break;
	   case MOVE             : Move();
	                           break;
	   case PRINT_TRACK      : PrintTrack();
	                           break;
	   case EXIT			 : Exit();
	                           break;
	 }
  
  } // end ProcessMenuChoice() 
  
  
  public void TurnSprayerOn(){
    its_sprayer_state = SprayerState.On;
    Console.WriteLine("Sprayer is now " + its_sprayer_state);
  }
  
  public void TurnSprayerOff(){
  
    its_sprayer_state = SprayerState.Off;
    Console.WriteLine("Sprayer is now " + its_sprayer_state);
  }
  
  public void TurnLeft() {
     switch(its_direction){
	   case Directions.North : its_direction = Directions.West;
	                           break;
	   case Directions.West : its_direction = Directions.South;
	                           break;
	   case Directions.South : its_direction = Directions.East;
	                           break;
	   case Directions.East : its_direction = Directions.North;
	                          break;
	 }
	 Console.WriteLine("The car is facing " + its_direction);
  }
  
  
  public void TurnRight() {
    switch(its_direction){
	   case Directions.North : its_direction = Directions.East;
	                           break;
	   case Directions.West : its_direction = Directions.North;
	                           break;
	   case Directions.South : its_direction = Directions.West;
	                           break;
	   case Directions.East : its_direction = Directions.South;
	                          break;
	 }
	 Console.WriteLine("The car is facing " + its_direction);
  }
  
  
  public void Move(){
     Console.WriteLine("Car is moving!");
  }
  
  public void PrintTrack(){
    for(int i = 0; i < track.GetLength(0); i++){
      for(int j = 0; j < track.GetLength(1); j++){
	    if(track[i,j] == true){
		  Console.Write("- ");
		}else {
		   Console.Write("0 ");
		  }
	  } // end inner for loop
      Console.WriteLine();
    } // end outer for loop
  }
  
  public void Exit(){
     keep_going = false;
  }
  
  
  public void Go(){
    while(keep_going){
	  DisplayMenu();
	  ProcessMenuChoice();
	}
  }
  


  public static void Main(string[] args){
  
    int rows = 20;
	int cols = 20;
  
    if(args.Length > 1){
	  try {
	    rows = Int32.Parse(args[0]);
		cols = Int32.Parse(args[1]);
	  }catch(Exception){
	     rows = 20;
		 cols = 20;
	  }
	}
        
	 RobotCar rc1 = new RobotCar(rows, cols);
	 rc1.Go();
	 
	 
	 
  }

} // End class definition









