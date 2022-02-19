using System;

[Serializable]
public class Dog {

   private String name = null;
   private DateTime date_of_birth;
   
   public Dog(String name, DateTime date_of_birth){
        this.name = name;
        this.date_of_birth = date_of_birth;
   }
   
   public Dog():this("Dog Joe", new DateTime(2005,01,01)){ }
   
   public Dog(String name):this(name, new DateTime(2005,01,01)){ }

   
   public int Age {
     get { return DateTime.Now.Year - date_of_birth.Year; }
   }
   
   public DateTime DateOfBirth {
    get { return date_of_birth; }
    set { date_of_birth = value; }
   }
   
   public String Name {
    get { return name; }
    set { name = value; }
   }


   public override String ToString(){
     return (name + "," + Age);     
   }

} // end class definition