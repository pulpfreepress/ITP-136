using System;

public class RobotRat {

  private bool[,] floor = null;
  private int rows = 0;
  private int cols = 0;
  private int current_row = 0;
  private int current_col = 0;


  private bool keep_going = true;

  public const char PEN_UP 	= '1';
  public const char PEN_DOWN 	= '2';
  public const char TURN_LEFT	= '4';
  public const char TURN_RIGHT 	= '3';
  public const char MOVE 	= '5';
  public const char PRINT_FLOOR = '6';
  public const char EXIT 	= '7';



  private enum PenPosition {UP, DOWN};
  private enum Direction {NORTH, SOUTH, EAST, WEST};

  PenPosition pen_position = PenPosition.UP;
  Direction direction = Direction.EAST;

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

  public void penUp(){
  	pen_position = PenPosition.UP;
  	Console.WriteLine("Pen is now {0}",pen_position);
  }


  public void turnLeft(){
  	switch(direction){
		case Direction.EAST	: direction = Direction.NORTH;
					  break;
		case Direction.SOUTH	: direction = Direction.EAST;
					  break;
		case Direction.WEST	: direction = Direction.SOUTH;
					  break;
		case Direction.NORTH	: direction = Direction.WEST;
					  break;
  	}
  	Console.WriteLine("RobotRate is now facing {0}", direction);
  }


  public void processMenuChoice(){
   string input = Console.ReadLine();

   switch(input[0]){
     case PEN_UP	: penUp();
     			  break;
     case PEN_DOWN	: break;
     case TURN_LEFT	: turnLeft();
     			  break;
     case TURN_RIGHT	: break;
     case MOVE		: break;
     case PRINT_FLOOR	: printFloor();
               		  break;
     case EXIT		: keep_going = false;
               		  break;
     default		: Console.WriteLine("Invalid Menu Choice!");
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

