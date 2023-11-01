using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerText2
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Class: {Class}, Section: {Section}";
        }
    }
}

