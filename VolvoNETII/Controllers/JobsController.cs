using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using VolvoNETII.DataAccess.Models;
using VolvoNETII.DataAccess.Repositories;

namespace VolvoNETII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private IJobRepository _jobRepository;

        public JobsController(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        // GET api/jobs
        //GET all jobs
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<Job> jobs;
            jobs = _jobRepository.GetAll().ToList();
            return Ok(jobs);
        }

        // GET api/jobs/ID
        //GET job by id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Job job;
            job = _jobRepository.FindBy(p => p.JobId == id).SingleOrDefault();
            return Ok(job);
        }

        // PUT api/jobs/salary
        //changes max salary by JobTitle
        [HttpPut("{title}")]
        public ActionResult Put(string title, int value)
        {
            Job job = _jobRepository.FindBy(p => p.JobTitle == title).SingleOrDefault();
            job.MaxSalary = value;
            _jobRepository.Edit(job);
            return RedirectToAction("Get");
        }

        // POST api/jobs/post
        [HttpPost("post")]
        public ActionResult PostNewJob(string jobTitle, int minSalary, int maxSalary)
        {
            Job job = new Job { JobTitle = jobTitle, MinSalary = minSalary, MaxSalary = maxSalary };
            _jobRepository.Add(job);
            return RedirectToAction("Get");
        }

        // DELETE api/jobs/ID
        // DELETE job by ID
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Job job;
            job = _jobRepository.FindBy(p => p.JobId == id).SingleOrDefault();
            if (job == null) return BadRequest();
            _jobRepository.Delete(job);
            return RedirectToAction("Get");
        }
    }
}