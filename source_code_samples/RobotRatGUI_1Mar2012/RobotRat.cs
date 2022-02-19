/********************************************************************************
  Copyright 2008 Rick Miller and Pulp Free Press - All Rights Reserved 
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
public class RobotRat
{

    private enum PenPositions { UP, DOWN };
    private enum Directions { NORTH, SOUTH, EAST, WEST };
    private PenPositions pen_position = PenPositions.UP;
    private Directions direction = Directions.EAST;
    private bool[,] floor;
    private int current_row = 0;
    private int current_col = 0;

    /// <summary>
    /// Constructor method. 
    /// </summary>
    /// <param name="rows">Integer value representing number of floor rows</param>
    /// <param name="cols">Integer value representing number of floor columns</param>
    public RobotRat(int rows, int cols)
    {
        Console.WriteLine("RobotRat Lives!");
        floor = new bool[rows, cols];
    }

    

    

    /// <summary>
    /// Sets the pen to the UP state.
    /// </summary>
    public void SetPenUp()
    {
        pen_position = PenPositions.UP;
        Console.WriteLine("The pen is " + pen_position);
    }

    /// <summary>
    /// Sets the pen to the DOWN state.
    /// </summary>
    public void SetPenDown()
    {
        pen_position = PenPositions.DOWN;
        Console.WriteLine("The pen is " + pen_position);
    }


    /// <summary>
    /// Turns the robot rat right.
    /// </summary>
    public void TurnRight()
    {
        switch (direction)
        {
            case Directions.NORTH: direction = Directions.EAST;
                break;
            case Directions.EAST: direction = Directions.SOUTH;
                break;
            case Directions.SOUTH: direction = Directions.WEST;
                break;
            case Directions.WEST: direction = Directions.NORTH;
                break;
        }

        Console.WriteLine("Direction is " + direction);
    }



    /// <summary>
    /// Turns the robot rat left.
    /// </summary>
    public void TurnLeft()
    {
        switch (direction)
        {
            case Directions.NORTH: direction = Directions.WEST;
                break;
            case Directions.WEST: direction = Directions.SOUTH;
                break;
            case Directions.SOUTH: direction = Directions.EAST;
                break;
            case Directions.EAST: direction = Directions.NORTH;
                break;
        }

        Console.WriteLine("Direction is " + direction);
    }


    /// <summary>
    /// Prints the floor pattern to the console.
    /// </summary>
    public void PrintFloor()
    {
        for (int i = 0; i < floor.GetLength(0); i++)
        {
            for (int j = 0; j < floor.GetLength(1); j++)
            {
                if (floor[i, j])
                {
                    Console.Write('-');
                }
                else
                {
                    Console.Write('0');
                }
            }
            Console.WriteLine();
        }
    }

   


   

    /// <summary>
    /// Called to move the robot rat forward.
    /// </summary>
    public void MoveForward(int spaces_to_move)
    {
         

        switch (pen_position)
        {
            case PenPositions.UP: switch (direction)
                {
                    case Directions.NORTH:
                        if ((current_row - spaces_to_move) < 0)
                        {
                            current_row = 0;
                        }
                        else
                        {
                            current_row = current_row - spaces_to_move;
                        }
                        break;
                    case Directions.SOUTH:
                        if ((current_row + spaces_to_move) > (floor.GetLength(0) - 1))
                        {
                            current_row = (floor.GetLength(0) - 1);
                        }
                        else
                        {
                            current_row = current_row + spaces_to_move;
                        }
                        break;
                    case Directions.EAST:
                        if ((current_col + spaces_to_move) > (floor.GetLength(1) - 1))
                        {
                            current_col = (floor.GetLength(1) - 1);
                        }
                        else
                        {
                            current_col = current_col + spaces_to_move;
                        }
                        break;
                    case Directions.WEST:
                        if ((current_col - spaces_to_move) < 0)
                        {
                            current_col = 0;
                        }
                        else
                        {
                            current_col = current_col - spaces_to_move;
                        }
                        break;
                }
                break;
            case PenPositions.DOWN: switch (direction)
                {
                    case Directions.NORTH:
                        while ((current_row > 0) && (spaces_to_move-- > 0))
                        {
                            floor[current_row--, current_col] = true;
                        }
                        break;
                    case Directions.SOUTH:
                        while ((current_row < floor.GetLength(0) - 1) && (spaces_to_move-- > 0))
                        {
                            floor[current_row++, current_col] = true;
                        }
                        break;
                    case Directions.EAST:
                        while ((current_col < floor.GetLength(1) - 1) && (spaces_to_move-- > 0))
                        {
                            floor[current_row, current_col++] = true;
                        }
                        break;
                    case Directions.WEST:
                        while ((current_col > 0) && (spaces_to_move-- > 0))
                        {
                            floor[current_row, current_col--] = true;
                        }
                        break;
                }
                break;


        }
    }

    


    

}
