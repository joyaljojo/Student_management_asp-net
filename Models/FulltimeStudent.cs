using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_7.Models
{
    public class FulltimeStudent
    {
        public static int MaxWeeklyHours = 16;
        public string Name { get; set; }
        public FulltimeStudent(string name)
        {
            
            this.Name = name;
        }
    }
}