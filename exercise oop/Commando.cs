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
        string Name;
        private int CodeName;
        string[] Tool;
        string Status;

        public  Commando(string name,int codename, string[] tool, string status)
        {
            this.Name = name;
            this.CodeName = codename;
            this.Tool = tool;
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

            
            
            








    }
}
