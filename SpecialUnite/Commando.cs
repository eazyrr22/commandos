using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialUnite
{
   
public class Commando
    {
        // fields
        public string Name { get; set; }
        public string NickName { get; set; }

        public string[] Tools = { "Hammer", "chisel", "rope", "bag", "water", "bottle" };

        public string Status { get; set; }

        public Commando(string name,string nickname,string status) 
        { 
            this.Name = name;
            this.NickName = nickname;
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

        public void Attack()
        {
            Console.WriteLine($"{NickName} is attacking");
        }


    }
}
