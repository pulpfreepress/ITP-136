using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class MainApp {

   private GUI _its_gui;
   private List<ImageData> _image_data_list;
   private int _index;
   
   public MainApp(){
     _its_gui = new GUI(this);
	 _image_data_list = new List<ImageData>();
   _index = 0;
	 Application.Run(_its_gui);
   }
   
   public void AddButtonHandler(object sender, EventArgs e){
      _image_data_list.Add(new ImageData(_its_gui.Image, _its_gui.ImageName, _its_gui.ImageDescription));
      FileStream fs = null;
      try{
        fs = new FileStream("imagedatafile.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, _image_data_list);
      }catch(Exception ex){
        Console.WriteLine(ex);
      }
   }
   
   public void LoadButtonHandler(object sender, EventArgs e){
     FileStream fs = null;
     string filename = String.Empty;
     OpenFileDialog openDialog = new OpenFileDialog();
     if(openDialog.ShowDialog() == DialogResult.OK){
       try {
         fs = new FileStream(openDialog.FileName, FileMode.Open);
         BinaryFormatter bf = new BinaryFormatter();
         _image_data_list = (List<ImageData>)bf.Deserialize(fs);
       }catch(Exception){
     
       }
       finally{
         fs.Close();
       }
     }
   }
   
   public void NextButtonHandler(object sender, EventArgs e){
    
     Console.WriteLine("******************************");
     Console.WriteLine("imagedata list count = " + _image_data_list.Count);
     Console.WriteLine("_index = " + _index);
     Console.WriteLine("******************************");
   
     if(_index >= _image_data_list.Count) _index = 0;
     _its_gui.Image = _image_data_list[_index].Image;
     _its_gui.ImageName = _image_data_list[_index].Name;
     _its_gui.ImageDescription = _image_data_list[_index].Description;
     _index++;
   }
   
   
   
   /************** MAIN *************/
   public static void Main(){
     new MainApp();
   }
}