using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = new DateTime(2023, 12, 31, 5, 10, 20);
        Address address = new Address("720 Cornielson Ave", "Rexburg", "ID", "USA");
        Lecture lecture = new Lecture("AI and Machine Learning", "A Discusion on the basics of Artificial Inteligence and Machine Learning", dateTime, address, "J. Hathaway", 50);
        lecture.FullDescription();
        Console.WriteLine("");
        lecture.ShortDescription();
        Console.WriteLine("");
        lecture.StandardDetail();
        Console.WriteLine("");

        Reception reception = new Reception("Tyler and Julie's wedding reception", "Come celebrate Tyler and Julie's wedding", dateTime, address, "tylervistaunet@gmail.com");
        reception.FullDescription();
        Console.WriteLine("");
        reception.ShortDescription();
        Console.WriteLine("");
        reception.StandardDetail();
        Console.WriteLine("");

        OutdoorGathering gathering = new OutdoorGathering("Rafting the Snake River", "Come join us for a twilight rafting session down the snake river", dateTime, address, "Cloudy");
        gathering.FullDescription();
        Console.WriteLine("");
        gathering.ShortDescription();
        Console.WriteLine("");
        gathering.StandardDetail();
        Console.WriteLine("");
    }
}