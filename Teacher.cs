using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_c_kku_2026_Phat
{
    using System;

    public class Teacher : Person, ISpeaker
    {
        public string Major;
        public string AcademicRank;

        public Teacher(string fn, string ln, string phone, string email,
                       string major, string rank)
            : base(fn, ln, phone, email)
        {
            Major = major;
            AcademicRank = rank;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"สาขา: {Major}");
            Console.WriteLine($"ตำแหน่ง: {AcademicRank}");
            Console.WriteLine("----------------------");
        }

        public void Train()
        {
            Console.WriteLine($"อาจารย์ {FirstName} กำลังอบรม");
        }

        public void Approve(Person p)
        {
            Console.WriteLine($"อาจารย์ {FirstName} อนุมัติผลให้ {p.FirstName}");
        }
    }
}