public interface IEnemyStats
{
    public int EnemyHealth { get; set; }
    public int EnemyPoints { get; set; }
    public int EnemyDamage { get; set; }

    public void OnDestroy();
}