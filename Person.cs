using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_c_kku_2026_Phat
{
    using System;

    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string Phone;
        public string Email;

        public Person(string fn, string ln, string phone, string email)
        {
            FirstName = fn;
            LastName = ln;
            Phone = phone;
            Email = email;
        }

        public virtual void Register()
        {
            Console.WriteLine($"{FirstName} ลงทะเบียนอบรมแล้ว");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"ชื่อ: {FirstName} {LastName}");
            Console.WriteLine($"โทร: {Phone}");
            Console.WriteLine($"อีเมล: {Email}");
        }
    }
}