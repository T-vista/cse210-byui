using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Video gangamStyle = new Video("Gangam Style", "Psy", 3);
        Comment gangamStyle1 = new Comment("boyo34", "This video is so good!");
        Comment gangamStyle2 = new Comment("tyler12334", "I actually think this video is bad");
        Comment gangamStyle3 = new Comment("piGgypoo", "Why is he dancing like that?");
        Comment gangamStyle4 = new Comment("Jacespencer1", "this is my fav song rn");
        gangamStyle.AddComment(gangamStyle1);
        gangamStyle.AddComment(gangamStyle2);
        gangamStyle.AddComment(gangamStyle3);
        gangamStyle.AddComment(gangamStyle4);

        gangamStyle.DisplayVideo();

        Video charlie = new Video("Charlie Bit My Finger", "Charlies Dad", 1);
        Comment charlie1 = new Comment("tyler12334", "I am crying laughing");
        Comment charlie2 = new Comment("AppleSauce4", "lame");
        Comment charlie3 = new Comment("bu5terrr", "the way he cries, lol");
        Comment charlie4 = new Comment("meow5er12", "lol");
        charlie.AddComment(charlie1);
        charlie.AddComment(charlie2);
        charlie.AddComment(charlie3);
        charlie.AddComment(charlie4);

        charlie.DisplayVideo();

        Video clickbate = new Video("I ate my dog??? (emotional)", "badYouTuber#1", 12);
        Comment click1 = new Comment("meow5er12", "This was not emotional at all");
        Comment click2 = new Comment("boyo34", "was their even a dog? I must have missed him");
        Comment click3 = new Comment("reeeeeno4", "This was nothing like the title");
        clickbate.AddComment(click1);
        clickbate.AddComment(click2);
        clickbate.AddComment(click3);

        clickbate.DisplayVideo();
    }
}