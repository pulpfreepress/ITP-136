using System;
using System.Windows.Forms;
using System.Drawing;

public class ButtonArray : Form {

   Button[,] floor = new Button[10,10];
   Bitmap bitmap;
   
   public ButtonArray(){
     for(int i = 0; i<floor.GetLength(0); i++){
       for(int j = 0; j<floor.GetLength(1); j++){
         floor[i,j] = new Button();
         floor[i,j].Click += new EventHandler(this.MarkSpace);
       }
       
        bitmap = new Bitmap("rat.gif");
       
     }
     
     TableLayoutPanel panel = new TableLayoutPanel();
     panel.ColumnCount = 10;
     panel.RowCount = 10;
    
    for(int i = 0; i<floor.GetLength(0); i++){
       for(int j = 0; j<floor.GetLength(1); j++){
         panel.Controls.Add(floor[i,j]);
       }
     }
    
    panel.Dock = DockStyle.Top;
    panel.AutoSize = true;
    panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.Width = 850;
    this.Height = 325;
    this.Controls.Add(panel);
   }
   
   
   public void MarkSpace(Object sender, EventArgs e){
     ((Button)sender).BackColor = Color.Blue;
     ((Button)sender).Image = bitmap;
   }





   static void Main(){
     Application.Run(new ButtonArray());
     
   }
}