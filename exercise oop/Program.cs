using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando1 = new Commando("jon", 8339307, "standing");
            Weapon weapon1 = new Weapon("m16", "isral", 200);
            Console.WriteLine( commando1.Attack());
            Console.WriteLine(commando1.Walk());
            Console.WriteLine(commando1.Hide());
            Console.WriteLine(weapon1.Shoot());
        }

    }
}
