using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnivBE.Data;
using UnivBE.Filters;
using UnivBE.Models;

namespace UnivBE.Controllers
{
    [MyLogFilter]
    [SecurityFilter]
    public class StudentsController : ApiController
    {
        private UnivContext db = new UnivContext();

        //GET
        public IQueryable<Student> GetStudents()
        {
            var data = from n in db.Students select n;
            return data;

            //return db.Students;
        }

        // POST

        public IHttpActionResult PostStudent(Student student)
        {
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                return Ok(student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
