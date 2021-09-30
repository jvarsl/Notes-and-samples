using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_NetFramework.Models
{
    public class PostGenre
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int PostId { get; set; }
        public Genre Genre { get; set; }
        public Post Post { get; set; }
    }
}
