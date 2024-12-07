using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C#", "Peniel Sweet", 300);
        Video video2 = new Video("Python Basic to Advanced Tutorial", "Deborah S", 320);
        Video video3 = new Video("UI/UX Design - Advanced Lesson", "Ilerioluwase General", 220);

        //    Adding comments to videos
        video1.AddComment(new Comment("John,", "I love how you breakdown the videos to make it simple to understand"));
        video2.AddComment(new Comment("Damilola,", "Interesting, I love the tutorials. twas very explanatory"));
        video3.AddComment(new Comment("Bernard,", "Well concised and explanatory video"));

        video1.AddComment(new Comment("Vivian", "I learned a lot from this video."));
        video2.AddComment(new Comment("Sarah", "It looks advanced for me to understand."));
        video3.AddComment(new Comment("Gift", "Wow, now i understand ui/ux greatly."));

        video1.AddComment(new Comment("DeborahM", "well detailed video, Keep it up"));
        video2.AddComment(new Comment("Gift", "Epic.. Is there a video on the basics, I am kind of a slow learner"));
        video3.AddComment(new Comment("Sarah", "This is video is the best for last-minute review. I loveeee it"));
        

        // Adding videos to list
        List<Video> _videos = new List<Video> { video1, video2, video3 };

        foreach (var video in _videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
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