﻿using System;

namespace AddStudentAssignment
{
   public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grades { get; set; }
    }
}
