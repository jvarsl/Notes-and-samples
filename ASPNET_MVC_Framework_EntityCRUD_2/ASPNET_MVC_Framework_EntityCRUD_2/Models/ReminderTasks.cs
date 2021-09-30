using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_Framework_EntityCRUD_2.Models
{
    public class ReminderTasks
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "day")]
        public DateTime DayAndTime { get; set; }
        [JsonProperty(PropertyName = "reminder")]
        public bool Reminder { get; set; }
    }
}