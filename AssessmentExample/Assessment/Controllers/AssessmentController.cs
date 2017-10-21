﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment.Domain;
using Assessment.Entities;

namespace Assessment.Controllers
{
    [Route("api/[controller]")]
    public class AssessmentController : Controller
    {
        AssessmentService _service;

        public AssessmentController()
        {
            _service = new AssessmentService();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Assessment.Entities.Assessment> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Assessment.Entities.Assessment Get(int id)
        {
            return _service.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Assessment.Entities.Assessment assessment)
        {
            _service.Insert(assessment);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Assessment.Entities.Assessment assessment)
        {
            _service.Update(assessment);
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete([FromBody]Assessment.Entities.Assessment assessment)
        {
            _service.Delete(assessment);
        }
    }
}
