using SpecialUnite;
namespace SpecialUnite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Commando> commandos = new List<Commando>();
            AirCommando soldierA = new AirCommando("john", "x", "standing");
            commandos.Add(soldierA);
            SeaCommando soldierB = new SeaCommando("alex", "y", "standing");
            commandos.Add(soldierB);
            LandCommando soldierC = new LandCommando("sergei", "z", "standing");
            commandos.Add(soldierC);

            foreach (Commando commando in commandos)
            {
                commando.Attack();
            }


           





        }
    }
}
