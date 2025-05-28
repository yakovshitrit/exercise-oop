using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
            commando1.Attack();
            Console.WriteLine(commando1.Walk());
            Console.WriteLine(commando1.Hide());
            Console.WriteLine(weapon1.Shoot());
            commando1.CodeName = 546544;
            Console.WriteLine(commando1.CodeName);
            AirCommando aircommando = new AirCommando("dan", 234546, "standing");
            aircommando.Attack();
            SeaCommando seacommando = new SeaCommando("arron", 345654, "standing") ;

            Commando number1 = CreateComndo.Create("air","yal" ,34567,"standing");


            Commando[] myarr = { commando1, aircommando , seacommando  };
            foreach(Commando c in myarr)
            {
                c.Attack();
            }
        }

    }
}
