using SpecialUnite;
using 
namespace factories
{
    public class EnemyFactory
    {
        public List<Enemy> enemies { get; } = new List<Enemy>;

        public void CreateEnemy(string name, string status)
        {
            Enemy enemy = new Enemy(name, status);
            enemies.Add(enemy);
        }
       
    }



    public class CommandoFactory
    {
        public List<Commando> soldiers { get; } = new List<Commando>;

        public void CreateSoldier()
        {
            Console.WriteLine("choose a unit\n 1:land\n2:sea\n3:air")
                switch (Console.ReadLine());
            {
                case 1:
                    
            }
            Enemy enemy = new Enemy(name, status);
            enemies.Add(enemy);
        }

    } 
    