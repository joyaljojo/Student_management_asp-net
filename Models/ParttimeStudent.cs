using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_7.Models
{
    public class ParttimeStudent
    {
        public static int MaxWeeklyHours = 3;
        public string Name { get; set; }
        public ParttimeStudent(string name)
        {

            this.Name = name;
        }
    }
}