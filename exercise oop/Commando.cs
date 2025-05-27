using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace exercise_oop
{
    internal class Commando
    {
       private string Name;
       private int CodeName;
       public  string[] Tool = { "Hammer", "chisel", "rope", " bag", "water bottle" };
       public string Status;

        public  Commando(string name,int codename, string status)
        {
            this.Name = name;
            this.CodeName = codename;
            this.Status = status;
        }
          
        public string Walk( )
        {   
            Status = "Walk";
            return Status;
        }
           
        public string Hide()
        {
            Status = "Hide";
            return Status;
        }

        public int Attack()
        {
            return CodeName;
        }

        public void SayName(string commenderRank)
        {
            if(commenderRank == "General")
            {
                Console.WriteLine( "it name is" + Name);
            }
            else
            {
                if(commenderRank == "Colonel")
                {
                    Console.WriteLine("it codename is " + CodeName); 
                }
                else
                {
                    Console.WriteLine("This is classified information");
                }
            }
        }
            
            
            








    }
}
