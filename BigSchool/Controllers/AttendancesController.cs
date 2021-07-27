using BigSchool.DTOs;
using BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext db;
        public AttendancesController()
        {
            db = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend ([FromBody] int id)
        {
            var userId = User.Identity.GetUserId();

            if (db.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == id))
                return BadRequest("RRR");

            var attendance = new Attendance
            {
                CourseId = id,
                AttendeeId = userId 
            };

            db.Attendances.Add(attendance);
            db.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (db.Attendances.Any(a => a.Attendee.Id == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("Lỗi trang web");

            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };

            db.Attendances.Add(attendance);
            db.SaveChanges();

            return Ok();
        }
    }
}
