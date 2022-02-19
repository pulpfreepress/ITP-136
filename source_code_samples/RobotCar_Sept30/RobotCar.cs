using System;

public class RobotCar {

   
  private const char TURN_LEFT = '1';
  private const char TURN_RIGHT = '2';
  private const char TURN_SPRAYER_ON = '3';
  private const char TURN_SPRAYER_OFF = '4';
  private const char MOVE_CAR = '5';
  private const char PRINT_FLOOR = '6';
  private const char EXIT = '7';
  
  private const char FACING_EAST_CHAR = '>';
  private const char FACING_WEST_CHAR = '<';
  private const char FACING_NORTH_CHAR = '^';
  private const char FACING_SOUTH_CHAR = 'v';
  
  private bool keep_going = true;
  
  private char[,] floor;
  
  
   
   
   public RobotCar():this(20, 20){
     
   }
   
   public RobotCar(char[,] floor){
     this.floor = floor;
   }
   
   
   public RobotCar(int rows, int cols){
     floor = new char[rows, cols];
     InitializeFloor();
    
   }
   
   
   public RobotCar(int rows_n_cols):this(rows_n_cols, rows_n_cols){
   
   }
   
   
   
   
   private void DisplayMenu(){
     Console.Clear();
     Console.ForegroundColor = ConsoleColor.Yellow;
     Console.WriteLine("\n\n");
     Console.WriteLine("      1. Turn Left ");
     Console.WriteLine("      2. Turn Right ");
     Console.WriteLine("      3. Turn Sprayer On ");
     Console.WriteLine("      4. Turn Sprayer Off ");
     Console.WriteLine("      5. Move Car ");
     Console.WriteLine("      6. Print Floor ");
     Console.WriteLine("      7. Exit  ");
     Console.WriteLine("\n\n");
     
     Console.ResetColor();
   
   }
   
   
   
   public void ProcessMenuChoice(){
     Console.Write("Please select a menu item: ");
     string input = Console.ReadLine();
     
     switch(input[0]){
       case TURN_LEFT : TurnLeft();
                        break;
                  
       case TURN_RIGHT : TurnRight();
                         break;
                  
       case TURN_SPRAYER_ON : TurnSprayerOn();
                              break;
                              
       case TURN_SPRAYER_OFF : TurnSprayerOff();
                               break;
       
       case MOVE_CAR : MoveCar();
                       break;
                       
       case PRINT_FLOOR : PrintFloor();
                          break;
       
       case EXIT : Exit();
                   break;
                   
     
       default: Console.WriteLine("Invalid menu choice. Try again!"); 
                break;
                
       
                  
       
       
     
     
     } // end switch statement
     
   
   } // end ProcessMenuChoice()
   
   
   
   
   private void TurnLeft(){
     Console.WriteLine("Robot Car Turned Left!");
   }
   
   
   private void TurnRight(){
     Console.WriteLine("Robot Car Turned Right!");
   }
   
   
   private void TurnSprayerOn(){
     Console.WriteLine("Sprayer is on!");
   }
   
   
    private void TurnSprayerOff(){
        Console.WriteLine("Sprayer is off!");
   }
   
   
   private void MoveCar(){
   
      Console.WriteLine("Car is moved...");
   }
   
   
   
   
   
   
   private void PrintFloor(){
   
     for(int i = 0; i<floor.GetLength(0); i++){
       for(int j = 0; j < floor.GetLength(1); j++){
        Console.Write(floor[i,j]);
       
       }
       Console.WriteLine();
     }
   
   }
   
   private void Exit(){
     keep_going = false;
   }
   
   
   
   
   private void InitializeFloor(){
     for(int i = 0; i<floor.GetLength(0); i++){
       for(int j = 0; j < floor.GetLength(1); j++){
             floor[i,j] = '0';
            
            }
     }
     floor[0,0] = FACING_EAST_CHAR;    
   }
   
   
   public void Go(){
     
     while(keep_going){
       Console.Write("Press enter to continue..");
       Console.ReadLine();
       DisplayMenu();
       ProcessMenuChoice();
      }
   }
   
   
  

} // end class definition