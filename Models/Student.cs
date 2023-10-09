using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_7.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        Random random = new Random();
        public  Student( string name)
        {
            this.Id = random.Next(90000, 99999); ;    
            this.Name = name;
        }
    }
}