using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp5_NetFramework.Models
{
    public class Post
    {
        public Post()
        {
            PostGenre = new HashSet<PostGenre>();
        }
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int AuthorId { get; set; }
        [Required]
        public Author Author { get; set; }
        public ICollection<PostGenre> PostGenre { get; set; }
    }
}
