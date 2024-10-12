using System;
using System.Security.AccessControl;

class clsPerson
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public int Age { get; set; }
    public string UserName {  get; set; }
    public string Password { get; set; }    
  



    //public static clsPerson Find(int Id)
    //{
    //    if(Id==10)
    //    {
    //        return new clsPerson(10, "Abdulwali", 20, "Awali", "A1234");
    //    }
    //    else
    //    {
    //        return null;
    //    }
    //}

    //public static clsPerson Find(string username,string password)
    //{
    //    if (username=="Awali"&& password=="A1234")
    //    {
    //        return new clsPerson(10, "Abdulwali", 20, "Awali", "A1234");
    //    }
    //    else
    //    {
    //        return null;
    //    }
    //}


    //public clsPerson(int id, string name, int age,string username,string password)
    //{
    //    Id = id;
    //    Name = name;
    //    Age = age;
    //    UserName = username;
    //    Password = password;
    //}

  
}


public class clsEmployee
{
    public float Salary = 1200; 
}
    internal class program
    {

        static void Main(string[] args)
        {
        clsEmployee Employee=new clsEmployee();

       

        //clsPerson person = clsPerson.Find(11);
        //clsPerson person2 = clsPerson.Find("Awali","A1234");

        //if(person != null)
        //{
        //    Console.WriteLine("Person Id: {0}",person.Id);
        //    Console.WriteLine("Person name: {0}",person.Name);
        //    Console.WriteLine("Person Age: {0}",person.Age);
        //}
        //else
        //{
        //    Console.WriteLine("not found any person ");
        //}

        //if (person2 != null)
        //{
        //    Console.WriteLine("\n\nPerson Id: {0}", person2.Id);
        //    Console.WriteLine("Person name: {0}", person2.Name);
        //    Console.WriteLine("Person Age: {0}", person2.Age);
        //}
        //else
        //{
        //    Console.WriteLine("not found any person ");
        //}

        Console.ReadKey();

        }




    }


