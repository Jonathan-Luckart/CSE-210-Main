using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        //----------------------

        //storing values and adding to lists
        #region 
        List<Comment> forVideo1 = new List<Comment>();
        List<Comment> forVideo2 = new List<Comment>();
        List<Comment> forVideo3 = new List<Comment>();

        Comment video1comment1 = new Comment("Jim", "It be Halpert yippie.");
        Comment video1comment2 = new Comment("Pam", "It be Beesly yippie.");
        Comment video1comment3 = new Comment("Stanely", "It be Hudson yippie.");
        Comment video2comment1 = new Comment("Dwight", "I am Schrute okay.");
        Comment video2comment2 = new Comment("Angela", "I am Martin okay.");
        Comment video2comment3 = new Comment("Oscar", "I am Martinez okay.");
        Comment video3comment1 = new Comment("Micheal", "This is Scott alright.");
        Comment video3comment2 = new Comment("Phyllis", "This is Vance alright.");
        Comment video3comment3 = new Comment("Creed", "No I didn't kill him, he was already dead.");

        forVideo1.Add(video1comment1);
        forVideo1.Add(video1comment2);
        forVideo1.Add(video1comment3);
        forVideo2.Add(video2comment1);
        forVideo2.Add(video2comment2);
        forVideo2.Add(video2comment3);
        forVideo3.Add(video3comment1);
        forVideo3.Add(video3comment2);
        forVideo3.Add(video3comment3);

        Video video1 = new Video("Robert California found footage", "The Lizard King", 12.6, forVideo1);
        Video video2 = new Video("Dwight's fire lesson", "SchruteTube", 5.4, forVideo2);
        Video video3 = new Video("Threat level midnight", "Micheal Scarn", 19.8, forVideo3);

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);
        #endregion

        //start
        Console.WriteLine();

        foreach (Video video in videoList)
        {
            Console.WriteLine();
            Console.WriteLine($"{video.GetTitle()} by {video.GetAuthor()}: {video.Getlength()}");
            Console.WriteLine($"Comment Amount: {video.CommentAmount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenter()} wrote: {comment.GetText()}");
            }

        }

        Console.WriteLine();
    }
}