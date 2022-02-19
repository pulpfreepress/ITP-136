using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

public class Server {

   private Floor _floor;
   private List<ControllableObject> _robots;
   private int _currentRobot;
   private ControlPanel _controlPanel;
   
   public Server(){
     _robots = new List<ControllableObject>();
     _floor = new Floor(_robots);
     _floor.Paint += _floor.Paint_Handler;
     _currentRobot = 0;
     _controlPanel = new ControlPanel(this);
     _controlPanel.Show();
   }
   
   public void AddRobotHandler(object sender, EventArgs e){
     Console.WriteLine("Add Robot Handler Called!");
     ControllableObject r1 = new ControllableObject();
     r1.Picture = new Bitmap("rat.gif");
     _robots.Add(r1);
     _floor.Invalidate();
   }
   
   
   public void TurnLeftHandler(object sender, EventArgs e){
      Console.WriteLine("TurnLeft Handler Called!");
     _robots[_currentRobot].TurnLeft();
   }
   
   
   public void TurnRightHandler(object sender, EventArgs e){
   Console.WriteLine("TurnRight Handler Called!");
      _robots[_currentRobot].TurnRight();
   }
   
   public void MoveHandler(object sender, EventArgs e){
      Console.WriteLine("MoveHandler Handler Called!");
      _robots[_currentRobot].Move();
      _floor.Invalidate();
   }
   
   
   public void NextRobotHandler(object sender, EventArgs e){
     Console.WriteLine("NextRobot Handler Called!");
     if((++_currentRobot) >= _robots.Count){
       _currentRobot = 0;
     } 
   }
   
   
   
   
   public static void Main(){
     Server s = new Server();
     Application.Run(s._floor);
   }
   
}