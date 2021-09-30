using ASPNET_MVC_Framework_EntityCRUD_2.Data;
using ASPNET_MVC_Framework_EntityCRUD_2.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace ASPNET_MVC_Framework_EntityCRUD_2.Controllers.Api
{
    public class JokesController : ApiController
    {
        //this should be in class library
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        [Route("api/Jokes/GetQuestions")]
        [HttpGet]
        public IHttpActionResult GetQuestions()
        {
            var questions = db.Jokes.Select(x => x.Question).Distinct().ToList();
            return Ok(questions);
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var jokes = db.Jokes.Include(x=>x.ApplicationUser).ToList();
            if (!jokes.Any()) return StatusCode(HttpStatusCode.NoContent);
            return Ok(jokes);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var joke = db.Jokes.Find(id);
            if (joke is null) return NotFound();
            return Ok(joke);
        }

        // POST api/<controller>
        public IHttpActionResult Post(Joke joke)
        {
            if (string.IsNullOrEmpty(joke.Question) || string.IsNullOrEmpty(joke.Answer)) return BadRequest();
            joke.ApplicationUser = db.Users.FirstOrDefault();
            db.Jokes.Add(joke);
            db.SaveChanges();
            return Created("",$"'{joke.Question} - {joke.Answer}' created!");
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var joke = db.Jokes.Find(id);
            if (joke is null) return BadRequest();
            db.Jokes.Remove(joke);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}