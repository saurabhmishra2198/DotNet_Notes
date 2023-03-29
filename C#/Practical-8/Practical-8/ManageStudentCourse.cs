using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8
{
    public abstract class StudentCourseRegister
    {
        public  abstract void TakeStudentDetails();
        public abstract void TakeCourseDetails();
        public abstract void TotalCourses();
    }
    public class ManageStudentCourse : StudentCourseRegister
    {
        HandleStudentDetails handleStudent = new HandleStudentDetails();
        HandleCourses handleCourses = new HandleCourses();

        List<RegisterCourses> TotalCourse = new List<RegisterCourses>();

        public int Id;
        public string Name;
        public string CourseId;
        public string CourseName;
        public decimal Amount;
        public override void TakeStudentDetails()
        {
            Console.WriteLine("Enter Your id: ");
            int StudId = Convert.ToInt32(Console.ReadLine());
            List<Student> students = handleStudent.GetStudent();
            foreach (Student student in students)
            {
                if(student.StudentId == StudId)
                {
                    Id = student.StudentId;
                    Name = student.StudentName;
                }
            }
        }
        public override void TakeCourseDetails()
        {
            Console.WriteLine("Enter course id: ");
            string CourseId = Console.ReadLine();
            List<Course> Courses = handleCourses.GetCourse();
            foreach (Course course in Courses)
            {
                if (course.CourseId == CourseId)
                {
                    CourseId = course.CourseId;
                    CourseName = course.CourseName;
                    Amount = course.CourseAmount;
                }
            }
        }
        public override void TotalCourses()
        {
            RegisterCourses registerCourses = new RegisterCourses()
            {
                StudentId = Id,
                StudentName = Name,
                CourseId = CourseId,
                CourseName = CourseName,
                CourseAmount = Amount,
            };
            TotalCourse.Add(registerCourses);
        }
        public List<RegisterCourses> GetRegisterCourses()
        {
            return TotalCourse;
        }

    }
    
}
