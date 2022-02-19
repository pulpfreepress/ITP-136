/**********************************************
   The purpose of the Model class is 
   to provide the single interface point
   into the functionality provided by itself
   the collection of application classes
   & components. A Model object will be
   created by the Contoller.
***********************************************/

using System;
using System.Collections;


  public class Model {
    private ArrayList array_list = null;
    private int current_element = 0;
    
  
    public Model(){
      Console.WriteLine("Model Object Created");
      array_list = new ArrayList();
  
    }
  
  
    public void save(String first_name, String last_name){
      Console.WriteLine("Model.Save() Method Called:" + " " + first_name + " " + last_name);
      array_list.Add(new LapDog(first_name, last_name));
    }
  
  
    public String[] getNext(){
      Console.WriteLine("Model.getNext() Method Called");
       String[] string_array = new String[2];
      if(current_element < array_list.Count){
        DomesticDog dog = (DomesticDog) array_list[current_element++];
        string_array[0] = dog.FirstName;
        string_array[1] = dog.LastName;
      }else {
            current_element = 0;
            DomesticDog dog = (DomesticDog) array_list[current_element++];
            string_array[0] = dog.FirstName;
            string_array[1] = dog.LastName;
            }
    
      return string_array;
    
    }
    
    public String getAllNames(){
      String names = "";
      for(int i = 0; i<array_list.Count; i++){
       names += ((DomesticDog)array_list[i]).FirstName + " " + ((DomesticDog)array_list[i]).LastName + "\r\n";
      }
      return names;
    }
  
  
  }
