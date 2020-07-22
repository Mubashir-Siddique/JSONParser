using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Linq;

namespace JSONParserNew
{
    public struct Student
    {
        //creating student's atributes
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
        public int? Semester { get; set; }

        public Pupil Scholar;

    }
}
