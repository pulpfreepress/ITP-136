using System;


public class RobotRat {
 
    // enumerations
    private enum Directions {NORTH, SOUTH, EAST, WEST }
    private enum PenPositions {UP, DOWN}
    
    
    
    
    // Fields
    private bool          _keep_going = true;
    private bool[,]       _floor = null;
    
    private int           _current_row = 0;
    private int           _current_column = 0;
    private Directions    _its_direction = Directions.EAST;
    private PenPositions  _its_pen_position = PenPositions.UP;
    
    
    
    
    // Constructors
  
    public RobotRat():this(20,20){
     
    }
    
    public RobotRat(int rows, int cols){
      _floor = new bool[rows, cols];
      
    }
    
    
  
  
  
  
  
   
   
   
   
  
  
  
  public void SetPenUp(){
    _its_pen_position = PenPositions.UP;
    Console.WriteLine("The pen is " + _its_pen_position);
  }
  
  
  public void SetPenDown(){
     _its_pen_position = PenPositions.DOWN;
    Console.WriteLine("The pen is " + _its_pen_position);
  }
  
  
  public void TurnLeft(){
    
    switch(_its_direction){
    
      case Directions.NORTH : _its_direction = Directions.WEST;
                              break;
      case Directions.WEST :  _its_direction = Directions.SOUTH;
                              break;
      case Directions.SOUTH : _its_direction = Directions.EAST;
                              break;
      case Directions.EAST : _its_direction = Directions.NORTH;
                              break;
                             
    }
    
    Console.WriteLine("RobotRat now faces " + _its_direction);
    
  }
  
  public void TurnRight(){
      switch(_its_direction){
        
          case Directions.NORTH : _its_direction = Directions.EAST;
                                  break;
          case Directions.WEST :  _its_direction = Directions.NORTH;
                                  break;
          case Directions.SOUTH : _its_direction = Directions.WEST;
                                  break;
          case Directions.EAST : _its_direction = Directions.SOUTH;
                                  break;
                                 
        }
        
    Console.WriteLine("RobotRat now faces " + _its_direction);
  }
  
  
  public void Move(int spaces_to_move){
    
    Console.WriteLine("Robot rat would have moved " + spaces_to_move + " spaces.");
    
    
  }
  
  
  public void PrintFloor(){
   
   for(int row = 0; row < _floor.GetLength(0); row++){
     for(int col = 0; col < _floor.GetLength(1); col++){
     
       if(_floor[row, col]){
         Console.Write('-');
       }else{
         Console.Write('0');
       }
     
     
     } // end inner for 
     Console.WriteLine();
   } // end outer for
   
  }
  

  
  
  
 
} // end class definition