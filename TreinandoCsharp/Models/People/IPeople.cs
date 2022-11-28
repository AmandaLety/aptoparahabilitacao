using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoCsharp.Models.People
{
    internal interface IPeople
    {
        public double cpf { get; set; }
        public string name { get; set; }
        public int age { get; set; }

    }
}
