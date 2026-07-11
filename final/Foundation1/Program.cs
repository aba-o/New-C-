using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Video 1
        Video _aaoVideo1 = new Video(
            "Introduction to C# Classes",
            "Aba Amponsah",
            420
        );

        _aaoVideo1.AddComment(new Comment("John", "This helped me understand classes better."));
        _aaoVideo1.AddComment(new Comment("Sarah", "Great explanation!"));
        _aaoVideo1.AddComment(new Comment("Michael", "I learned a lot from this video."));

        
        // Create Video 2
        Video _aaoVideo2 = new Video(
            "Object-Oriented Programming Basics",
            "W3 Schools",
            600
        );

        _aaoVideo2.AddComment(new Comment("Emma", "Very clear and easy to follow."));
        _aaoVideo2.AddComment(new Comment("David", "The examples were helpful."));
        _aaoVideo2.AddComment(new Comment("Lisa", "Looking forward to more tutorials."));

        
        // Create Video 3
        Video _aaoVideo3 = new Video(
            "Understanding C# Lists",
            "Programming Hub",
            350
        );

        _aaoVideo3.AddComment(new Comment("Chris", "Lists make storing data much easier."));
        _aaoVideo3.AddComment(new Comment("Anna", "This was exactly what I needed."));
        _aaoVideo3.AddComment(new Comment("Mark", "Good explanation of collections."));

        
        // Create Video 4
        Video _aaoVideo4 = new Video(
            "Encapsulation in C#",
            "Software Engineering Channel",
            500
        );

        _aaoVideo4.AddComment(new Comment("James", "Encapsulation finally makes sense."));
        _aaoVideo4.AddComment(new Comment("Rachel", "Thanks for breaking it down."));
        _aaoVideo4.AddComment(new Comment("Peter", "Great programming tips."));


        // Store videos in a list
        List<Video> _aaoVideos = new List<Video>();

        _aaoVideos.Add(_aaoVideo1);
        _aaoVideos.Add(_aaoVideo2);
        _aaoVideos.Add(_aaoVideo3);
        _aaoVideos.Add(_aaoVideo4);


        // Display video information
        foreach (Video _aaoVideo in _aaoVideos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {_aaoVideo.GetTitle()}");
            Console.WriteLine($"Author: {_aaoVideo.GetAuthor()}");
            Console.WriteLine($"Length: {_aaoVideo.GetLength()} seconds");
            Console.WriteLine($"Comments: {_aaoVideo.GetCommentCount()}");

            Console.WriteLine("\nComments:");

            foreach (Comment _aaoComment in _aaoVideo.GetComments())
            {
                Console.WriteLine(
                    $"{_aaoComment.GetName()}: {_aaoComment.GetText()}"
                );
            }

            Console.WriteLine();
        }
    }
}