﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud_application.Models
{
    public class Student
    {
        
        public string Subject { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Year { get; set; }

        public string Major { get; set; }

        public Char Sex { get; set; }
    }
}
