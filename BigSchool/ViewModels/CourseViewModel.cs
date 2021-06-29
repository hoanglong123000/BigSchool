using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        [Display(Name = "Địa điểm")]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        [Display(Name = "Ngày tháng")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Thời gian:")]
        public string Time { get; set; }

        
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", this.Date, this.Time));
        }


    }
}