using System;
using System.Collections.Generic;

namespace School 
{ 
    public class Student
    {
        private const double CREDITS_PER_YEAR = 24.0;
        //private string studentId;
        private static int nextStudentId = 1;
        public String Name { get; set; }
        public int StudentId { get; protected set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(String name, int studentid, int numberOfCredits, double gpa)
        {
            this.Name = name;
            this.StudentId = studentid;
            this.NumberOfCredits = numberOfCredits;
            this.Gpa = gpa;
        }
        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }




        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double totalGrade = (Gpa * NumberOfCredits) + (grade * courseCredits);
            NumberOfCredits += courseCredits;
            Gpa = totalGrade / NumberOfCredits;

            
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits > CREDITS_PER_YEAR * 3)
            {
                return "Senior";
            }
            else if(NumberOfCredits > CREDITS_PER_YEAR * 2)
            {
                return "Junior";
            }
            else if(NumberOfCredits > CREDITS_PER_YEAR)
            {
                return "Sophomore";
            }
            else
            {
                return "Freshman";
            }
        }
        public static double GetCreditPerYear()
        {
            return CREDITS_PER_YEAR;
        }

        public override string ToString()
        {
            return Name + " (Credits:" + NumberOfCredits + ", GPA:" + Gpa + ")";
        }
        public override bool Equals(object obj)
        {
            bool compare = false;
            Student studentObj = obj as Student;
            if(this.StudentId == studentObj.StudentId &&
                this.Name == studentObj.Name)
            {
                compare = true;
            }
            return compare;
        }

        public void SetStudentString(string id)
        {
            
        }
    }
    public class Course
    {
        public int CourseId { get; protected set; }
        public string Name { get; set; }
        public bool RequiresPrereq { get; set; }
        public decimal NumCredits { get; protected set; }
        public string Instructor { get; set; }
        public List<Student> ClassRoster { get; set; }

        public Course(int courseId, string name, bool requiresPrereq, decimal numCredits, 
            string instrutor)
        {
            this.CourseId = courseId;
            this.Name = name;
            this.RequiresPrereq = requiresPrereq;
            this.NumCredits = numCredits;
            this.Instructor = instrutor;
            this.ClassRoster = null;
        }

        public Course(int courseId, string name) 
            : this( courseId, name, false, 0, "") { } 
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Nancy", 0);
            Student student2 = new Student("Samuel", 1);
            Student student3 = new Student("Lois", 2);
            Student student4 = student1;


            Course c1 = new Course(10, "CodeCamp", false, 14, "Ben");
            Course c2 = new Course(451, "LC101");

            Console.WriteLine("Name:" + c1.Name + "; CourseID:" + c1.CourseId);

            List<Student> roster = new List<Student>() { student1, student2 };

            c1.ClassRoster = roster;

            Console.WriteLine("Credits per year:" + Student.GetCreditPerYear());

            student1.AddGrade(10, 3.0);
            student1.AddGrade(8, 4.0);
            student1.AddGrade(6, 2.5);

            Console.WriteLine("Student:" + student1.Name + ";" + " GPA: " + student1.Gpa);
            Console.WriteLine("Student level: " + student1.GetGradeLevel());

            Console.WriteLine("Student ToString: " + student1.ToString());
            Console.WriteLine("Student ToString: " + student1);
            Console.WriteLine("1 " + student1.Equals(student2));
            Console.WriteLine("2 " + student1.Equals(student4));
            Console.WriteLine("3 " + student1.Equals(new Student("Nancy", 0)));



            foreach (Student stu in c1.ClassRoster)
            {
                Console.WriteLine(stu.Name);
            }



            /*student1.Gpa = 3.9;
            student3.NumberOfCredits = 18;

            Console.WriteLine("{0} {1} {2}", student1.Gpa, student2.Name, student3.NumberOfCredits);*/
        }
    }

    
}
