using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
        v1.Title = "Forex Trading Basics";
        v1.Author = "John FX";
        v1.Length = 600;

        v1.Comments.Add(new Comment("Daniel", "Nice explanation"));
        v1.Comments.Add(new Comment("Grace", "Very helpful"));
        v1.Comments.Add(new Comment("Michael", "I understand now"));

        Video v2 = new Video();
        v2.Title = "C# for Beginners";
        v2.Author = "Code Tutor";
        v2.Length = 900;

        v2.Comments.Add(new Comment("Sarah", "Good teaching"));
        v2.Comments.Add(new Comment("James", "Clear and simple"));
        v2.Comments.Add(new Comment("Linda", "Thanks a lot"));

        Video v3 = new Video();
        v3.Title = "Daily Routine Tips";
        v3.Author = "Life Guide";
        v3.Length = 500;

        v3.Comments.Add(new Comment("Peter", "Very inspiring"));
        v3.Comments.Add(new Comment("Anna", "Loved it"));
        v3.Comments.Add(new Comment("Chris", "Helpful tips"));

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine("---------------------------");
        }
    }
}