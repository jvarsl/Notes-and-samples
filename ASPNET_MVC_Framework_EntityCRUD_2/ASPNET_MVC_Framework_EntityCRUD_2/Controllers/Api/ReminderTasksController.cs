using ASPNET_MVC_Framework_EntityCRUD_2.Data;
using ASPNET_MVC_Framework_EntityCRUD_2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace ASPNET_MVC_Framework_EntityCRUD_2.Controllers.Api
{
    [EnableCors("*", "*", "*")]
    public class ReminderTasksController : ApiController
    {
        private readonly ApplicationDbContext dbContext = new ApplicationDbContext();

        // GET: ReminderTasks
        public IHttpActionResult GetReminderTasks()
        {
            var tasks = dbContext.ReminderTasks.ToList();
            return Ok(tasks);
        }

        //get/id
        public IHttpActionResult GetReminderTasks(int id)
        {
            var task = dbContext.ReminderTasks.Where(x => x.Id == id).FirstOrDefault();
            if (task is null) return BadRequest();
            return Ok(task);
        }

        public async Task<IHttpActionResult> DeleteAsync(int id)
        {
            var task = await dbContext.ReminderTasks.FindAsync(id);
            if (task is null) return BadRequest();
            dbContext.ReminderTasks.Remove(task);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [System.Web.Mvc.HttpPost]
        public async Task<IHttpActionResult> PostAsync(ReminderTasks task)
        {
            if (!ModelState.IsValid) return BadRequest();

            dbContext.ReminderTasks.Add(task);
            await dbContext.SaveChangesAsync();
            return Created("", task);
        }

        //update reminder
        [System.Web.Mvc.HttpPut]
        public async Task<IHttpActionResult> PutAsync(ReminderTasks updatedTask)
        {
            if (!ModelState.IsValid) return BadRequest();

            var task = dbContext.ReminderTasks.FirstOrDefault(x => x.Id == updatedTask.Id);
            if (task is null) return BadRequest();

            dbContext.Entry(task).CurrentValues.SetValues(updatedTask);
            await dbContext.SaveChangesAsync();
            return Ok(true);
        }
    }
}