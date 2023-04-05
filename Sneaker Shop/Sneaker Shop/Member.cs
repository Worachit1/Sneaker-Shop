using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Shop
{
    public class Member
    {
        private string name, lastname, mail, phone, sneaker;
        private int age = 0;
        public Member(string name, string lastname, string mail, string phone, int age, string sneaker)
        {
            this.name = name;
            this.lastname = lastname;
            this.mail = mail;
            this.phone = phone;
            this.age = age;
            this.sneaker = sneaker;
            
        }
        public string Name { get => name; } 
        public string Lastname { get => lastname;  }
        public string Phone { get => phone; }
        public string Sneaker { get => sneaker; }
    }
}