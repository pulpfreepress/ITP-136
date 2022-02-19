/********************************************************************************
  Copyright 2015 Rick Miller and Pulp Free Press - All Rights Reserved 
    The source code contained within this file is intended for educational 
  purposes only. No warranty as to the quality of the code is expressed or 
  implied. 
    Feel free to use this code provided you include the copyright notice in its
  entirety.
**********************************************************************************/ 

using System;

/// <summary>
/// RobotRat class lets a user control the movements
/// of a robot rat around a floor represented by
/// a 2-dimensional array.
/// </summary>
public class RobotRat {

	
	private enum PenPositions { UP, DOWN }
	private enum Directions { NORTH, SOUTH, EAST, WEST }
	private PenPositions _penPosition = PenPositions.UP;
	private Directions _direction = Directions.EAST;
	private bool[,] _floor;
	private int _currentRow = 0;
	private int _currentColumn = 0;

	/// <summary>
	/// Constructor method. 
	/// </summary>
	/// <param name="rows">Integer value representing number of floor rows</param>
	/// <param name="cols">Integer value representing number of floor columns</param>
	public RobotRat(int rows, int cols){
		Console.WriteLine("RobotRat Lives!");
		_floor = new bool[rows, cols];
	}

	

	

	/// <summary>
	/// Sets the pen to the UP state.
	/// </summary>
	public void SetPenUp(){
		_penPosition = PenPositions.UP;
		Console.WriteLine("The pen is " + _penPosition);
	}

	/// <summary>
	/// Sets the pen to the DOWN state.
	/// </summary>
	public void SetPenDown(){
		_penPosition = PenPositions.DOWN;
		Console.WriteLine("The pen is " + _penPosition);
	}
	
	
	public string TogglePen(){
		
		switch(_penPosition){
		  case PenPositions.UP : SetPenDown();
		                         break;
		  case PenPositions.DOWN : SetPenUp();
		                         break;
		  default : SetPenDown();
		            break;
			
		}
		
	   return "The pen is " + _penPosition;
	}

	/// <summary>
	/// Turns the robot rat right.
	/// </summary>
	public string TurnRight(){
		switch (_direction){
			case Directions.NORTH:	_direction = Directions.EAST;
															break;
			case Directions.EAST:		_direction = Directions.SOUTH;
															break;
			case Directions.SOUTH:	_direction = Directions.WEST;
															break;
			case Directions.WEST:		_direction = Directions.NORTH;
															break;
		}
		Console.WriteLine("Direction is " + _direction);
		return "Direction is " + _direction;
	}

	/// <summary>
	/// Turns the robot rat left.
	/// </summary>
	public string TurnLeft(){
		switch (_direction){
			case Directions.NORTH:	_direction = Directions.WEST;
															break;
			case Directions.WEST:		_direction = Directions.SOUTH;
															break;
			case Directions.SOUTH:	_direction = Directions.EAST;
															break;
			case Directions.EAST:		_direction = Directions.NORTH;
															break;
		}
		Console.WriteLine("Direction is " + _direction);
		return "Direction is " + _direction;
	}

	/// <summary>
	/// Prints the floor pattern to the console.
	/// </summary>
	public void PrintFloor(){
		Console.Clear();
		for (int i = 0; i < _floor.GetLength(0); i++){
			for (int j = 0; j < _floor.GetLength(1); j++){
				if (_floor[i, j]){
					Console.Write('-');
				} else {
						Console.Write('0');
				}
			}
			Console.WriteLine();
		}
	}

	/// <summary>
	/// Prints an error message. Called if a user enters an invalid
	/// menu choice.
	/// </summary>
	public void PrintErrorMessage(){
		Console.WriteLine("Please enter a valid RobotRat control option!");
	}

	

	/// <summary>
	/// Called to move the robot rat forward.
	/// </summary>
	public void MoveForward(int spaces_to_move){
		
		switch (_penPosition){
			case PenPositions.UP: 
				switch (_direction){
					case Directions.NORTH:
						if ((_currentRow - spaces_to_move) < 0){
							_currentRow = 0;
						} else {
								_currentRow = _currentRow - spaces_to_move;
						}
						break;
					case Directions.SOUTH:
						if ((_currentRow + spaces_to_move) > (_floor.GetLength(0) - 1)){
							_currentRow = (_floor.GetLength(0) - 1);
						} else {
								_currentRow = _currentRow + spaces_to_move;
						}
						break;
					case Directions.EAST:
						if ((_currentColumn + spaces_to_move) > (_floor.GetLength(1) - 1)){
							_currentColumn = (_floor.GetLength(1) - 1);
						} else {
								_currentColumn = _currentColumn + spaces_to_move;
						}
						break;
					case Directions.WEST:
						if ((_currentColumn - spaces_to_move) < 0){
							_currentColumn = 0;
						} else {
								_currentColumn = _currentColumn - spaces_to_move;
						}
						break;
				}
			break;
			case PenPositions.DOWN: 
				switch (_direction){
					case Directions.NORTH:
						while ((_currentRow > 0) && (spaces_to_move-- > 0)){
							_floor[_currentRow--, _currentColumn] = true;
						}
						break;
					case Directions.SOUTH:
						while ((_currentRow < _floor.GetLength(0) - 1) && (spaces_to_move-- > 0)){
							_floor[_currentRow++, _currentColumn] = true;
						}
						break;
					case Directions.EAST:
						while ((_currentColumn < _floor.GetLength(1) - 1) && (spaces_to_move-- > 0)){
							_floor[_currentRow, _currentColumn++] = true;
						}
						break;
					case Directions.WEST:
						while ((_currentColumn > 0) && (spaces_to_move-- > 0)){
							_floor[_currentRow, _currentColumn--] = true;
						}
						break;
				}
			break;
		}
	}

	

}
