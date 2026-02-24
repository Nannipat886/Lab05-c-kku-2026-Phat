using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_c_kku_2026_Phat
{
    using System;

    public class Student : Person
    {
        public string Major;
        public string StudentID;

        public Student(string fn, string ln, string phone, string email,
                       string major, string id)
            : base(fn, ln, phone, email)
        {
            Major = major;
            StudentID = id;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"สาขา: {Major}");
            Console.WriteLine($"รหัสนักศึกษา: {StudentID}");
            Console.WriteLine("----------------------");
        }
    }
}
