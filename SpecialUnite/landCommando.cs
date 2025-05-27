using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialUnite
{
    public class LandCommando : Commando
    {

        public LandCommando(string name, string nickname, string status)
             : base(name, nickname, status)
       
        { }

        public override void Attack()
        {
            Console.WriteLine($"land force soldier{CodeName} is attacking");
        }

    }
}
      
