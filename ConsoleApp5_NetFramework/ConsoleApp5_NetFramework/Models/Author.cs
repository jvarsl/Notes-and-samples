using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_NetFramework.Models
{
    public class Author
    {
        public Author()
        {
            Post = new HashSet<Post>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<Post> Post { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        
    }
}
