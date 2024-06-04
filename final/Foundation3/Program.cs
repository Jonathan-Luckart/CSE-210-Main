using System;

class Program
{
    static void Main(string[] args)
    {
        #region 
        Address address1 = new Address("3564 Swick Hill Street", "Hammond", "Louisiana");
        Address address2 = new Address("4843 Hoffman Avenue", "New York", "New York");
        Address address3 = new Address("836 Hickman Street", "Bensenville", "Illinois");

        Lecture lecture = new Lecture("Lecture", "Into The Unknown", "A lecture about the vastness of space and our place in the universe", DateTime.Parse("10/22/2024 07:00:00 PM"), address1, "Tim Burton", 100);
        Reception reception = new Reception("Reception", "Shane & Sherry's Wedding Reception", "Shane and Sherry are married! Come join us for the celebration!", DateTime.Parse("07/23/2024 05:30:00 PM"), address2, "SherryDew@nomail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering", "Anchorway High School Graduation", "Please come celebrate our 2025 graduates with us!", DateTime.Parse("05/22/2025 12:00:00 PM"), address3, "75F Mostly Sunny");
        #endregion

        Console.WriteLine();
        Console.WriteLine(lecture.StandardText());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortText());
        Console.WriteLine();
        Console.WriteLine(lecture.FullText());
        Console.WriteLine(" \r\n \r\n ");
        Console.WriteLine(reception.StandardText());
        Console.WriteLine();
        Console.WriteLine(reception.ShortText());
        Console.WriteLine();
        Console.WriteLine(reception.FullText());
        Console.WriteLine(" \r\n \r\n ");
        Console.WriteLine(outdoorGathering.StandardText());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.ShortText());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.FullText());
        Console.WriteLine();
    }
}