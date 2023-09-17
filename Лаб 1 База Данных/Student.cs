
namespace Лаб_1_База_данных
{
    internal class Student
    {
        public string StLastName { get; set; }
        public string StFirstName { get; set; }
        public int Grade { get; set; }
        public int Classroom { get; set; }
        public int Bus { get; set; }
        public string TLastName { get; set; }
        public string TFirstName { get; set; }

        public override string ToString()
        {
            string data = "Student LastName:" + StLastName + Environment.NewLine;
            data += "Student FirstName:" + StFirstName + Environment.NewLine;
            data += "Student Grade:" + Grade + Environment.NewLine;
            data += "Student Classroom:" + Classroom + Environment.NewLine;
            data += "Student Bus:" + Bus + Environment.NewLine;
            data += "Teacher LastName:" + TLastName + Environment.NewLine;
            data += "Teacher FirstName:" + TFirstName + Environment.NewLine;
            return data;
        }
        public string ToStringStudentClassTeacher()//task1
        {
            string data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "Student Classroom: " + Classroom + Environment.NewLine;
            data += "Teacher LastName: " + TLastName + Environment.NewLine;
            data += "Teacher FirstName: " + TFirstName + Environment.NewLine;
            data += "================================" + Environment.NewLine;
            return data;
        }
        public string ToStringStudentBus()//task2
        {
            string data = "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "Student Bus: " + Bus + Environment.NewLine;
            data += "================================" + Environment.NewLine;
            return data;
        }
        public string ToStringTeachersStudentsList()//task3
        {
            string data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "================================" + Environment.NewLine;
            return data;
        }
        public string ToStringStudentsBus1()//task4
        {
            string data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "================================" + Environment.NewLine;
            return data;
        }

        public string ToStringStudentsGrade()//task5
        {
            string data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "================================" + Environment.NewLine;
            return data;
        }
    }
}