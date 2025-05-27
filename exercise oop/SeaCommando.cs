using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_oop
{
    internal class SeaCommando: Commando
    {
        public SeaCommando(string name , int codename ,string status):base(name, codename,status) { }
        public void Swim()
        {
            Status = "swim";
        }
    }
}
