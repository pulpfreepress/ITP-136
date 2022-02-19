using System;
using System.Windows.Forms;
using System.Drawing;

public class Floor : Form {

   private Bitmap _drawing_area;
   
   public Floor(){
     _drawing_area = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
	 this.Paint += this.updateGraphics;
   }
   
   public Bitmap DrawingArea {
     get { _drawing_area = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
           return _drawing_area;	 }
	 set { _drawing_area = value; }
   }

    public void updateGraphics(object sender, PaintEventArgs e){
       Graphics graphics = e.Graphics;
       graphics.DrawImage( _drawing_area, 0, 0, _drawing_area.Width, _drawing_area.Height);
    }

}