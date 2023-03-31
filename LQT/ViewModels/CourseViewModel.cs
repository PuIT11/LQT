using LQT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LQT.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Place { set; get; }


        [Required]
        [FutureDate]
        public string Date { set; get; }
        [Required]
        [ValidTime]
        public string Time { set; get; }
        [Required]
        public byte Category { set; get; }
        public IEnumerable<Category> Categories { set; get; }

        public string Heading { set; get; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}