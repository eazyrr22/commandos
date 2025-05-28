using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialUnite
{
    public class SeaCommando:Commando
    {


        public SeaCommando(string name, string nickname, string status)
            : base(name, nickname, status)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"sea force soldier{CodeName} is attacking");
        }

        public void swim()
        {
            Console.WriteLine("swimming");
        }
    }
}
