using System;
using System.Windows.Forms;

public class FormCloseApp : Form {

   
   
   public FormCloseApp(){
      this.FormClosing += this.FormClosingHandler;
   }   
   
   
   public void FormClosingHandler(object sender, FormClosingEventArgs args){
     
	  DialogResult result = MessageBox.Show("Do you really want to quit?", "Hello!", MessageBoxButtons.OKCancel);
	  if(result == DialogResult.Cancel){
	    args.Cancel = true;
	  }
   }
   
   public static void Main(){
     Application.Run(new FormCloseApp());
   }
}