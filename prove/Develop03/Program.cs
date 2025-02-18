using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference("Doctrine and Covenants", 18, 10, 11);
        Scripture scripture = new Scripture(reference, "Remember the worth of souls is great in the sight of God; For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all med might repent and come unto him.");




        scripture.GetDisplayContent();
        // reference.GetDisplayContent();
    }
}