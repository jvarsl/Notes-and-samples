using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_Framework_EntityCRUD_2.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}