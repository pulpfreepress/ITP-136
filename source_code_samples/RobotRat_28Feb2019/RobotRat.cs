/* *************************
 Project Name: RobotRat
 Author:       Rick Miller

*************************** */
using System;

public class RobotRat {


   private enum Directions {NORTH, SOUTH, EAST, WEST}
   private enum PenPositions {UP, DOWN}

   /*************************
     Constants
   *************************/
   private const char PEN_UP      = '1';
   private const char PEN_DOWN    = '2';
   private const char TURN_LEFT   = '3';
   private const char TURN_RIGHT  = '4';
   private const char MOVE		  = '5';
   private const char PRINT_FLOOR = '6';
   private const char EXIT		  = '7';
   private const int ROWS = 0;
   private const int COLS = 1;
   
   /******************************
     Fields
   *******************************/
   private bool _keep_going = true;
   private char[,] _floor;
   private int _current_row;
   private int _current_col;
   private Directions _its_direction;
   private PenPositions _its_pen_position;
   
   

   /**********************
    Constructors
	***********************/
   public RobotRat():this(20,20){}
   
   public RobotRat(int rows, int cols){
      Console.BackgroundColor = ConsoleColor.Blue;
	  Console.Clear();	  
	  _floor = new char[rows, cols];
	  _current_row = 10;
	  _current_col = 10;
	  _its_direction = Directions.EAST;
	  _its_pen_position = PenPositions.UP;
	  InitializeFloor();
   }
   
   /************************
    Methods
	************************/
	public void PrintMenu(){
		Console.WriteLine("\t\tRobot Control Menu\n");
		Console.WriteLine("\t1. Pen Up");
		Console.WriteLine("\t2. Pen Down");
		Console.WriteLine("\t3. Turn Left");
		Console.WriteLine("\t4. Turn Right");
		Console.WriteLine("\t5. Move");
		Console.WriteLine("\t6. Print Floor");
		Console.WriteLine("\t7. Exit");	
		Console.Write("\nPlease Enter Menu Choice: ");
	}
	
	
	public void ProcessMenuChoice(){
		string input = Console.ReadLine();
		if(input.Length == 0){
			input = "8";
		}
		
		switch(input[0]){
		  case PEN_UP : SetPenUp();
                        break;
		  case PEN_DOWN : SetPenDown();
		                  break;
		  case TURN_LEFT: TurnLeft();
						  break;
		  case TURN_RIGHT: TurnRight();
						   break;
		  case MOVE: Move();
					 break;
		  case PRINT_FLOOR: PrintFloor();
							break;
		  case EXIT: _keep_going = false;
		             break;
          
          default: Console.WriteLine("Please enter a valid menu choice!");
                   break;		  
			
			
			
		} // end switch
		
		
		
	} // end ProcessMenuChoice method
	

   public void SetPenUp(){
	  _its_pen_position = PenPositions.UP;
	  Console.WriteLine("Pen is " + _its_pen_position);
   }
   
   
   public void SetPenDown(){
	  _its_pen_position = PenPositions.DOWN;
	  Console.WriteLine("Pen is " + _its_pen_position);
   }
   
   public void TurnLeft(){
	  switch(_its_direction){
		  case Directions.NORTH: _its_direction = Directions.WEST;
		       break;
		  case Directions.SOUTH: _its_direction = Directions.EAST;
		       break;
		  case Directions.EAST: _its_direction = Directions.NORTH;
		       break;
		  case Directions.WEST: _its_direction = Directions.SOUTH;
		       break;
		  
	  }
	  Console.WriteLine("Rat is facing " + _its_direction);
   }
   
   
   public void TurnRight(){
	    switch(_its_direction){
		  case Directions.NORTH: _its_direction = Directions.EAST;
		       break;
		  case Directions.SOUTH: _its_direction = Directions.WEST;
		       break;
		  case Directions.EAST: _its_direction = Directions.SOUTH;
		       break;
		  case Directions.WEST: _its_direction = Directions.NORTH;
		       break;
		  
	  }
	  Console.WriteLine("Rat is facing " + _its_direction);
   }
   
   public void Move(){
	   Console.Write("Spaces to move: ");
	   int spaces_to_move = 0;
	   
	   try{
		  spaces_to_move = Int32.Parse(Console.ReadLine()); 
	   }catch(Exception){
		   spaces_to_move = 1;
	   }
	   
	   switch(_its_pen_position){
		   
		   case PenPositions.UP: 
		   
		          switch(_its_direction){
				     case Directions.NORTH: {
						  _current_row = _current_row - spaces_to_move;
						  if(_current_row < 0){
							 _current_row = 0;
						  }
					 }
					      break;
					 
					 case Directions.SOUTH:{
						  _current_row = _current_row + spaces_to_move;
						  if(_current_row > _floor.GetLength(ROWS)-1){
							 _current_row = _floor.GetLength(ROWS)-1;
						  }
					 }
					      break;
					 
					 case Directions.EAST:{
						  _current_col = _current_col + spaces_to_move;
						  if(_current_col > _floor.GetLength(COLS)-1){
							 _current_col = _floor.GetLength(COLS)-1;
						  }
					 }
					      break;
					 
					 case Directions.WEST:{
						  _current_col = _current_col - spaces_to_move;
						  if(_current_col < 0){
							 _current_col = 0;
						  }
					 }
					      break;
					 
					     
					
				  }
		          break;
				  
		   case PenPositions.DOWN:
		           switch(_its_direction){
				     case Directions.NORTH:
					      while((_current_row > 0) && (spaces_to_move-- > 0)){
							  _floor[_current_row--, _current_col] = '|';
							  
							  
						  }
					      break;
				   
					 case Directions.SOUTH:
					      break;
					 case Directions.EAST:
					      break;
					 case Directions.WEST:
					      break;
		          
				   }
				  break;
		   
		   
	   }
	   
	   
   }
   
   public void PrintFloor(){
	  
	  for(int row = 0; row < _floor.GetLength(0); row++){
		for(int col = 0; col < _floor.GetLength(1); col++) {
		  Console.Write(" " + _floor[row,col] + " ");
		} //inner for
		Console.WriteLine();
	  }// outer for
   
   } // end PrintFloor
   
   
   public void InitializeFloor(){
	   
	   for(int row = 0; row < _floor.GetLength(0); row++){
		for(int col = 0; col < _floor.GetLength(1); col++) {
		  _floor[row, col] = '0';
		} //inner for
	  }// outer for
	   
	   
	   _floor[0,0] = '|';
	   _floor[1,0] = '|';
	   _floor[2,0] = '|';
	   _floor[3,0] = '|';
	   _floor[3,1] = '-';
	   _floor[3,2] = '-';
	   _floor[3,3] = '-';
	   
   }
   
   
   
   public void Go(){
	 while(_keep_going){
	   PrintMenu();
	   ProcessMenuChoice();
	 }
   }
   
   public static void Main(string[] args){
	   
	 int rows = 20;
	 int cols = 20;
	 
	 if(args.Length > 1){
		try{
	     rows = Int32.Parse(args[0]);
		 cols = Int32.Parse(args[1]);
		}catch(Exception){
			Console.Beep();
			Console.WriteLine("Usage example: RobotRat 20 20");
			Console.WriteLine("Creating RobotRat with default floor dimensions.");
			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}
	 }
	   
	 RobotRat rat = new RobotRat();
	 rat.Go();
   }
	
} // end class definition