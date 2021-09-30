using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFramework_SameCRUDTask.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public Joke()
        {

        }
    }
}