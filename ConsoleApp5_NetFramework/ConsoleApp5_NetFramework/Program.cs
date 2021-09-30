using ConsoleApp5_NetFramework.Data;
using ConsoleApp5_NetFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp5_NetFramework
{
    partial class Program
    {
        static void Main(string[] args)
        {
            OutputEFPosts();
            Console.ReadKey();
        }
        static void OutputEFPosts()
        {
            var context = new AppDbContext();
            var posts = context.Posts.Include(x=>x.Author).ToList();
            foreach (var item in posts)
            {
                Console.WriteLine($"{item.Title}: {item.Body}; {item.DatePublished.Date}; Author: {item.Author.FullName}");
            }
        }
        static void SeedEFPosts()
        {
            var context = new AppDbContext();

            var cities = new List<City>() {
                new City() { Name = "Vilnius" },
                new City() { Name = "Kaunas" },
                new City() { Name = "Klaipeda" } };


            var authors = new List<Author>()
            {
                new Author(){FirstName="Tim", LastName="Corey",City=cities.First() },
                new Author(){FirstName="Bob",LastName="Gates",City=cities.Last() }
            };

            var genres = new List<Genre>()
            {
                new Genre(){Name="Horror"},
                 new Genre(){Name="Fantasy"},
                  new Genre(){Name="Science"}
            };

            var post1 = new Post()
            {
                DatePublished = DateTime.Now.Date,
                Body = "Look at me3",
                Title = "Look3",
                Author = authors.First()
            };
            var post2 = new Post()
            {
                DatePublished = DateTime.Now.Date,
                Body = "Look at me4",
                Title = "Look4",
                Author = authors.Last()
            };
            var post3 = new Post()
            {
                DatePublished = DateTime.Now.Date,
                Body = "Look at me5",
                Title = "Look5",
                Author = authors.First()
            };

            var postGenres = new List<PostGenre>()
            {
                new PostGenre(){Genre=genres.First(),Post=post1 },
                new PostGenre(){Genre=genres.Last(),Post=post1 },
                new PostGenre(){Genre=genres[1],Post=post1 },
                new PostGenre(){Genre=genres.First(),Post=post2 },
                new PostGenre(){Genre=genres.Last(),Post=post3 }
            };

            context.Cities.AddRange(cities);
            context.Authors.AddRange(authors);
            context.Genres.AddRange(genres);
            context.Posts.AddRange(new List<Post>() { post1, post2, post3 });
            context.PostGenres.AddRange(postGenres);
            context.SaveChanges();
            Console.WriteLine("done");
        }

        static void RandomTests()
        {
            var a = 5;
            var b = 99;
            (a, b) = (b, a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            var list = new List<string>() { "namas", "butas", "roze" };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
