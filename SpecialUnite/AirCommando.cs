 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialUnite
{
    public class AirCommando:Commando
    {
        public AirCommando(string name, string nickname, string status)
            :base(name, nickname, status)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"air force soldier {CodeName} is attacking");
        }

        public void parachute()
        {
            Console.WriteLine("parachuting");
        }




    }
}
