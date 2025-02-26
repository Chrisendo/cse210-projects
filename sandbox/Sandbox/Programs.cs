// main

using System;

class Programs
{
    static void Main(string[] args)
    {
        Staff staf1 = new Staff("Unknown first name", "Unknown Last name", "Unknown");

        Teacher teach1 = new Teacher("Samantha", "Prance", "Female", 15);
        teach1.Display();

        Specialist spec1 = new Specialist("Steve", "Enderson", "Male", "math");
        spec1.Display();

        Volenteer vol1 = new Volenteer("Christian", "Gividen", "Male");
        vol1.Display();
    }
}