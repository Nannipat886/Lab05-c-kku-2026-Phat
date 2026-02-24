using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_c_kku_2026_Phat
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<Person> participants = new List<Person>();
            List<ISpeaker> speakers = new List<ISpeaker>();

            // เพิ่มข้อมูลตัวอย่าง
            Student s = new Student("นายนันท์นิพัทธ์", "อ่วมอินทร์", "0623308720", "nannipat.o@kkumail.com", "cs", "683450431-9");
            Teacher t = new Teacher("สมชาย", "เก่ง", "0822", "t@mail.com", "CS", "ผศ.");
            GeneralPerson g = new GeneralPerson("มานะ", "ดีมาก", "0833", "g@mail.com", "ABC Co.", "Manager");

            participants.Add(s);
            participants.Add(t);
            participants.Add(g);

            speakers.Add(t);
            speakers.Add(g);

            Console.WriteLine("===== รายชื่อผู้เข้าอบรม =====");
            foreach (var p in participants)
            {
                p.ShowInfo();
            }

            Console.WriteLine("\n===== รายชื่อวิทยากร =====");
            foreach (var sp in speakers)
            {
                sp.Train();
            }

            Console.WriteLine("\n===== การอนุมัติผล =====");
            t.Approve(s);
        }
    }
}
