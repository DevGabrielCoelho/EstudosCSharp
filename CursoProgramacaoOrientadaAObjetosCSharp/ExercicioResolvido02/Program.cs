using System;
using System.Collections.Generic;
using ExercicioResolvido02.Entities;

namespace ExercicioResolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> posts = new List<Post>()
            {
                new Post
                (
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12
                ),
                new Post
                (
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5
                )
            };

            posts[0].Comments.AddRange(new Comment[] { new Comment("Have a nice trip"), new Comment("Wow that's awesome!") });
            posts[1].Comments.AddRange(new Comment[] { new Comment("Good night"), new Comment("May the Force be with you") });

            foreach (Post posted in posts)
            {
                Console.WriteLine($"{posted.Title}\n" +
                                  $"{posted.Likes} - {posted.Moment}\n" +
                                  $"{posted.Content}\n" +
                                  $"Comments:");
                foreach (Comment commented in posted.Comments)
                {
                    Console.WriteLine(commented.Text);
                }
                Console.WriteLine();
            }
        }
    }
}