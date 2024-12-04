using System;

class Program
{
    static void Main(string[] args)
    {
       Video video1 = new Video("Introduction to C#", "Alice", 300);
       Video video2 = new Video("Python Basic to Advanced Tutorial", "Deborah", 320);

    //    Adding comments to videos
        video1.AddComment(new Comment("John,", "I love how you breakdown the videos to make it simple to understand"));
        video1.AddComment(new Comment("John,", "Interesting, I love the tutorials. twas very explanatory"));

        video2.AddComment(new Comment("Vivian", "I learned a lot from this video."));
        video2.AddComment(new Comment("Sarah", "It looks advanced for me to understand."));

        // Adding videos to list
        List<Video> _videos = new List<Video> {video1, video2};

        foreach (var video in _videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Numbers of Comment: {video.GetCommentNumber()}");

            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComment())
            {
                Console.WriteLine($" - {comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }


    }
}