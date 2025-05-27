using SpecialUnite;
namespace SpecialUnite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando soldier = new Commando("john", "x", "standing");
            weapon gun = new weapon("gun", "glock", 10);
            soldier.Attack();
            Console.WriteLine(soldier.Status);
            gun.Shoot();
            Console.WriteLine(gun.Contain);

        }
    }
}
