﻿class Program
{
    public static void SetPersonFirstName(Person person, string firstName){
        person.SetPersonFirstName(firstName);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey Bob");
        // Person bob = new Person("Bob", "Billy", 37);
        // Person betty = new("Betty", "Billy", 39);

        // Console.WriteLine(bob.GetPersonInfo());
        // Console.WriteLine(betty.GetPersonInfo());

        Doctor doctorBob = new Doctor("Bob", "Budge", 65, ["Hacksaw", "scalpel"]);
        // Console.WriteLine(doctorBob.GetDoctorInfo());
        Console.WriteLine(doctorBob.GetPersonInfo());

        
        Police policeDoug = new("Doug", "Billy", 37, ["Tazer", "battarang", "pistol"]);
        // Console.WriteLine(policeDoug.GetPoliceInfo());
        Console.WriteLine(policeDoug.GetPersonInfo());

        SetPersonFirstName(policeDoug, "Doug the second");
        // Console.WriteLine(policeDoug.GetPoliceInfo());
        Console.WriteLine(policeDoug.GetPersonInfo());

        // SetPersonFirstName(bob, "Bobby");
        // Console.WriteLine(bob.GetPersonInfo());

        List<Person> people = new List<Person>();
        // people.Add(bob);
        // people.Add(betty);
        people.Add(doctorBob);
        people.Add(policeDoug);

        foreach(Person person in people){
            Console.WriteLine(person.GetPersonInfo());
        }
        
        

        
    }
}
