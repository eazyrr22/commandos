namespace enemy;

{
public  class EnemyFactory
{
   public List<Enemy> enemies { get; } = new List<Enemy>;

    public void CreateEnemy(string name,string status)
    {
        Enemy enemy = new Enemy(name, status);
        enemies.Add(enemy);
    }





















}


 public class Enemy
{
    public string Name { get; set; }
    public int vitality { get; set; } 
    public string Status {  get; set; }

    public Enemy(string name, string status)
    {
       this.Name = name;
       this.vitality = 100;
       this.Status = status;
    }



    public void scream()
    {
        Console.WriteLine("im an enemy");
    }
}






































}