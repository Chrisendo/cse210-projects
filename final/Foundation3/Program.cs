using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("435 Main St", "Corvallis", "MT", 59828);
        Lecture lecture1 = new Lecture("Wood Working with Chris", "We'll be carving logs and sticks using a variety of tools.", "3/21/2025", "1:00 pm", address1, "Christian Gividen", 15);


        Address address2 = new Address("1121 Main St", "Provo", "UT", 33333);
        Reception reception1 = new Reception("Wedding Reception", "This will be a wedding reception.", "2/3/2026", "11:00 am", address2, "somethingiscool@mail.com");


        Address address3 = new Address("3323 Main St", "Rexburg", "ID", 83440);
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Wintery Picnic", "Join us for a picnic in this winter wonderland!", "3/25/2025", "3:00 pm", address3, "Snow and ice all day, with a high of 20*F.");

        // This prints the lecture details
        Console.WriteLine("Lecture Messages");
        Console.WriteLine();
        Console.WriteLine($"Standard Details:\n{lecture1.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details:\n{lecture1.LectureFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{lecture1.LectureShortDescription()}");
        Console.WriteLine();



        // This prints the reception details
        Console.WriteLine("Reception Messages");
        Console.WriteLine();
        Console.WriteLine($"Standard Details:\n{reception1.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details:\n{reception1.ReceptionFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{reception1.ReceptionShortDescription()}");
        Console.WriteLine();



        // This prints the outdoor gathering details
        Console.WriteLine("Outdoor Gathering Messages");
        Console.WriteLine();
        Console.WriteLine($"Standard Details:\n{outdoorGathering1.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details:\n{outdoorGathering1.OutdoorGatheringFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{outdoorGathering1.OutdoorGatheringShortDescription()}");
        Console.WriteLine();
    }
}