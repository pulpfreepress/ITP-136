using System;

public class RobotCar {
 
  
  public static void Main(){
    Grid grid = new Grid();
	Car c1 = new Car('%');
	c1.Row = 3;
	c1.Col = 4;
	Car c2 = new Car('$');
	grid.AddCar(c1);
	grid.AddCar(c2);
	grid.PrintGrid();
	c1.Row++;
	grid.PrintGrid();
  }


}