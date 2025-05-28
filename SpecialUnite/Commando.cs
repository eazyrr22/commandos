using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialUnite
{
   
public abstract class Commando
    {
        // fields
        public string Name { get; set; }
        public string CodeName { get; set; }

        public  string[] Tools;
        public string Status { get; set; }

        public Commando(string name,string nickname,string status) 
        {
            this.Name = name;
            this.CodeName = nickname;
            this.Status = status;
           
        }

        public void Walk()
        {
            this.Status = "moving";
            Console.WriteLine("the soldier is under way");
        }

        public void Hide()
        {
            this.Status = "hiding";
            Console.WriteLine("the soldier is hiding");
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{CodeName} is attacking");
        }

        public string SayName(string CommanderRank)
        {
            if (CommanderRank == "general")
            {
                return Name;
            }
            else if (CommanderRank == "colonel")
            {
                return CodeName ;
            }
            return "not allowed";
        }

    }
}
