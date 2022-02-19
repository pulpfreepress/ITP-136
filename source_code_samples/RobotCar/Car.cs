using System;

public class Car {
  private int _row;
  private int _col;
  private Direction _direction;
  private SprayerState _sprayer_state;
  private char _symbol;
  
  public Car(char symbol){
    _symbol = symbol;
	_row = 0;
	_col = 0;
	_direction = Direction.EAST;
	_sprayer_state = SprayerState.OFF;
  }
  
  
  public int Row {
    get { return _row; }
	set { _row = value; }
  }
  
  public int Col {
    get { return _col; }
	set { _col = value; }
  }
  
  public Direction Direction {
    get { return _direction; }
	set { _direction = value; }
  }
  
  public SprayerState SprayerState {
    get { return _sprayer_state; }
	set { _sprayer_state = value; }
  }
  
  public char Symbol {
    get { return _symbol; }
	set { _symbol = value; }
  }
  
 
}