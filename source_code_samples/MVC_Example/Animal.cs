using System;


   public class Animal {
     private String _f_name;
     private String _l_name;
     
     
     public Animal(String f_name, String l_name){
       _f_name = f_name;
       _l_name = l_name;
       Console.WriteLine("Animal object created.");
     }
     
     
     public String FirstName {
       get{ return _f_name; }
       set{ _f_name = value; }
     }
     
     public String LastName {
       get{ return _l_name; }
       set{ _l_name = value; }
     }
     
   
   } // end class
