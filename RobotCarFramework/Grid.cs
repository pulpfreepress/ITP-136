using System;
using System.Collections.Generic;

public class Grid {

   private char[,] _grid;
   private List<Car> _car_list;
   
   public Grid():this(20, 20) {
   }
   
   public Grid(int rows, int cols){
     _grid = new char[rows, cols];
	 _car_list = new List<Car>();
   
   }
   
   public void AddCar(Car car){
     _car_list.Add(car);
   }
   
   public List<Car> CarList {
     get { return _car_list; }
   }
   
   
   public void PrintGrid(){
     foreach(Car c in _car_list){
	    _grid[c.Row, c.Col] = c.Symbol;
	 }
	 
	 for(int i = 0; i < _grid.GetLength(0); i++){
	   for(int j = 0; j < _grid.GetLength(1); j++){
	      Console.Write(_grid[i,j]);
	   }
	   Console.WriteLine();
	 }
   }
   


}
