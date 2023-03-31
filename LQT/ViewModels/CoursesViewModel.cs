using LQT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LQT.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { set; get; }
        public bool ShowAction { set; get; }
    }
}