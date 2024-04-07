using System.Collections.Generic;
using System.Security.Cryptography;
using ExercicioResolvido02.Entities;

namespace ExercicioResolvido02.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comment comments)
        {
            Comments.Add(comments);
        }
        public void RemoveComments(Comment comments)
        {
            Comments.Remove(comments);
        }

    }
}
