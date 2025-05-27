using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialUnite
{
    public class weapon
    {
        public string Name { get; set; }
        public string manufacturer { get; set; }
        public int Contain { get; set; }

        public weapon(string name, string manufacturer, int contain)
        {
            this.Name = name;
            this.manufacturer = manufacturer;
            this.Contain = contain;
        }
        public void Shoot()
        {
            this.Contain--;
            Console.WriteLine("shoot");
        }
    }
}
