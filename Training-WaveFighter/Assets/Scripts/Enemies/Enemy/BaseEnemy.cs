using UnityEngine;

public class BaseEnemy : MonoBehaviour, IEnemy
{
    private int _health;
    private int _damage;
    private int _speed;
    
    public void Initialize(EnemyConfig config)
    {
        _health = config.Health;
        _damage = config.Damage;
        _speed = config.Speed;
    }

    public void GetHit(int damage)
    {
        _health -= damage;
    }
}
