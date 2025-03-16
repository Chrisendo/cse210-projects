using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void DisplayVideoMenu()
    {
        Console.WriteLine($"");
        Console.WriteLine($"1. View video 1");
        Console.WriteLine($"2. View video 2");
        Console.WriteLine($"3. View video 3");
        Console.WriteLine($"4. Quit");
        Console.WriteLine($"");
    }

    static void Main(string[] args)
    {
        Video videoA = new Video("Bob the builder ep. 1", "Bob", 6000);
        Video videoB = new Video("The Lego in Movies", "Dave", 10000);
        Video videoC = new Video("Are hamburgers sandwiches?", "Crazy Lary", 80);
        
        
        bool running = true;

        while (running)
        {
            DisplayVideoMenu();

            Console.Write("Please enter your choice here: ");
            string choice = Console.ReadLine();
            Console.WriteLine($"");

            if (choice == "1")
            {
                Comment commentA1 = new Comment("Caden", "Such a touching story... :')");
                videoA._comments.Add(commentA1);

                Comment commentA2 = new Comment("Nic", "Thank you for showing me the kind of person I aspire to be!");
                videoA._comments.Add(commentA2);

                Comment commentA3 = new Comment("Annie", "Amazing!");
                videoA._comments.Add(commentA3);

                videoA.DisplayVideo();
                Console.WriteLine($"");
                Console.WriteLine($"Total comments: {videoA.GetCommentCount()}");
            }

            else if (choice == "2")
            {
                Comment commentB1 = new Comment("Garnt", "So wholesome, so fun, amazingly spectacular. Peak cinema.");
                videoB._comments.Add(commentB1);

                Comment commentB2 = new Comment("Jacky-san Mosscow", "Look at dat brick maaaaan");
                videoB._comments.Add(commentB2);

                Comment commentB3 = new Comment("Aiden", "Nuh uh");
                videoB._comments.Add(commentB3);

                Comment commentB4 = new Comment("Gary", "...");
                videoB._comments.Add(commentB4);

                videoB.DisplayVideo();
                Console.WriteLine($"");
                Console.WriteLine($"Total comments: {videoB.GetCommentCount()}");
            }

            else if (choice == "3")
            {
                Comment commentA1 = new Comment("George", "Technically? Yes. Actually? No.");
                videoC._comments.Add(commentA1);

                Comment commentC2 = new Comment("John", "Maybe, not too sure.");
                videoC._comments.Add(commentC2);

                Comment commentC3 = new Comment("Chris", "Nahhhhh, found a better video (clean). https://youtu.be/xvFZjo5PgG0?si=psqhyyaGnBlSSia_ >:)");
                videoC._comments.Add(commentC3);

                Comment commentC4 = new Comment("Garnt", "Yes.");
                videoC._comments.Add(commentC4);

                Comment commentC5 = new Comment("Jacky-san Mosscow", "No.");
                videoC._comments.Add(commentC5);

                videoC.DisplayVideo();
                Console.WriteLine($"");
                Console.WriteLine($"Total comments: {videoC.GetCommentCount()}");
            }

            else if (choice == "4")
            {
                running = false;
            }

            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}