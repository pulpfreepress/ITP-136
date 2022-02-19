using System;
using System.Windows.Forms;
using System.Collections.Generic;

public class Floor : Form {

   private List<ControllableObject> _its_objects;
   
   public Floor(List<ControllableObject> its_objects){
     _its_objects = its_objects;
	 this.Paint += this.PaintEventHandler;
     this.Text = "Floor";
   }
   
   
  
   public void PaintEventHandler(object sender, PaintEventArgs p){
     foreach(ControllableObject o in _its_objects){
	   p.Graphics.DrawImage(o.Picture, o.X, o.Y);
	 }
   
   }
}