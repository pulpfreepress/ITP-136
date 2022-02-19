using System;
using System.Drawing;
using System.Windows.Forms;

public class RotateFlipDemo : Form {



   private Image    _image;
   private Bitmap  _drawing_area;
   private Button _button;
    
   
   
   
   public RotateFlipDemo(){
   
     InitializeComponent();
     
   }
   
   
   private void InitializeComponent(){
   
     _image = new Bitmap("Rat.gif");
     
     _button = new Button();
     _button.Text = "Flip Rat";
     _button.Click += ButtonHandler;
     _button.Location = new Point(50, 50);
     
     this.Controls.Add(_button);
     
     this.Paint += new PaintEventHandler(this.UpdateGraphics);
      _drawing_area   = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
   
   }



   public void UpdateGraphics(object sender, PaintEventArgs e){
         
       Graphics graphics1 = Graphics.FromImage(_drawing_area);
       Graphics graphics = e.Graphics;
       Point point = new Point(10, 10);
       graphics1.DrawImage(_image, point);
       graphics.DrawImage( _drawing_area, 0, 0, _drawing_area.Width, _drawing_area.Height);
    }
   


   public void ButtonHandler(object sender, EventArgs e){
    _drawing_area   = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
     _image.RotateFlip(RotateFlipType.Rotate90FlipNone);
     this.Invalidate();
   }


    public static void Main() {
    
      Application.Run(new RotateFlipDemo());
    }


}