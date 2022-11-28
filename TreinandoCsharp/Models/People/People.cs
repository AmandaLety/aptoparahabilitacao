using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoCsharp.Models.People
{
    internal class People : IPeople
    {
        public People()
        {
        }

        public People(double cpf, string name, int age)
        {
            this.cpf = cpf;
            this.name = name;
            this.age = age;
        }

        public double cpf { get; set; }
        public string name { get; set; }
        public int age { get; set; }

    }
}
