using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JSONParserNew
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream Stream = new FileStream(@"C:\Users\Mubashir Siddique\source\repos\DailyPractice\JSONParserNew\Files\test.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter Writer = new StreamWriter(Stream))
                {
                    Student Std = new Student()
                    {
                        StudentId = 1,
                        StudentName = "Mubashir",
                        Semester = 8,
                        Scholar = new Pupil()
                        {
                            Age = 21,
                            CGPA = 3.5,
                            CoursesToCover = new int[] { 3, 5, 7, 8, 9 }
                        }
                    };

                    Type ObjectType = Std.GetType();

                    FieldInfo[] Fields = ObjectType.GetFields();                    // Getting all Fields (properties of sub object) of the Object.
                    PropertyInfo[] Properties = ObjectType.GetProperties();
                }
            }
        }
    }
}
