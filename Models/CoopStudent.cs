using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_7.Models
{
    public class CoopStudent
    {
        public static int MaxWeeklyHours = 4;
        public static int MaxNumOfCourses = 2;
        public string Name { get; set; }
        public CoopStudent(string name)
        {

            this.Name = name;
        }
    }
}