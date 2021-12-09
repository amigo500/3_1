using System;


    public class Program
    {
                    static void Main(string[] args)
        {
            Person person1 = new Person(6, "Leopold", "Bloom", 178, 67);
            Console.WriteLine("person1 Age = {0} Fname = {1}", person1.Age, person1.Fname);

            // Declare new person, assign person1 to it.
            Person person2 = person1;

            // Change the name of person2, and person1 also changes.
            person2.Fname = "Molly";
            person2.Age = 16;
        person2.Lname = "Sandén";
        person2.Height = 166;
        person2.Weight = 50;

        Console.WriteLine("person2 Age = {0} Fname = {1}", person2.Age, person2.Fname);
            Console.WriteLine("person1 Age = {0} Fname = {1}", person1.Age, person1.Fname);
        }
    }
