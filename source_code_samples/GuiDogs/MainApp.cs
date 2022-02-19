using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;


public class MainApp {

  private Gui _its_gui = null;
  private List<Dog> _dog_list = null;
  
   
  public MainApp(){
    _its_gui = new Gui(this);
	_dog_list = new List<Dog>();
    Application.Run(_its_gui);
  }
  
  public void NewButtonClickHandler(Object sender, EventArgs e){
    Console.WriteLine(((Button)sender).Text + " Clicked!!");
	Dog tempDog = new Dog(_its_gui.NameText, _its_gui.Birthday);
	_dog_list.Add(tempDog);
	StringBuilder sb = new StringBuilder();
	foreach(Dog d in _dog_list){
	   sb.Append(d.ToString() + "\r\n");
	}
	_its_gui.MainText = String.Empty;
	_its_gui.MainText = sb.ToString();
	_its_gui.NameText = String.Empty;
	
  }
  
  public void LoadButtonClickHandler(Object sender, EventArgs e){
    Console.WriteLine(((Button)sender).Text + " Clicked!!");
  }
  
  public void SaveButtonClickHandler(Object sender, EventArgs e){
    Console.WriteLine(((Button)sender).Text + " Clicked!!");
  }
  
  public void UpdateButtonClickHandler(Object sender, EventArgs e){
    Console.WriteLine(((Button)sender).Text + " Clicked!!");
  }
  
  public void NextButtonClickHandler(Object sender, EventArgs e){
    Console.WriteLine(((Button)sender).Text + " Clicked!!");
  }


 public static void Main(String[] args){
   new MainApp();
 } // end Main() definition
} // end MainApp class definition