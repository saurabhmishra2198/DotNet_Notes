﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8
{
    public interface IScholarStudent
    {
        public void FindScholarStudent();
        public void PrintAmount();
    }
    public sealed class Scholarship : IScholarStudent
    {
        ManageStudentCourse manageStudent = new ManageStudentCourse();
        private decimal _ScholarshipAmount;
        public void FindScholarStudent()
        {
            Console.WriteLine("Enter Your id: ");
            int StudId = Convert.ToInt32(Console.ReadLine());
            List<RegisterCourses> registers = manageStudent.GetRegisterCourses();
            decimal TotalAmountSum = 0;
            foreach(RegisterCourses register in registers)
            {
                if(register.StudentId == StudId)
                {
                    TotalAmountSum += register.CourseAmount;
                }
            }
            _ScholarshipAmount = (TotalAmountSum > 400) ? 100 : 0;
        }
        public void PrintAmount()
        {
            Console.WriteLine("Scholarship amount is: {0}", _ScholarshipAmount);
        }
    }
}
