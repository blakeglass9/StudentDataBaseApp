﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseApp
{
    public class Student
    {
        public int Id { get; set; } // Primary Key
        public required string Name { get; set; }
        public int Age { get; set; }
    }
}