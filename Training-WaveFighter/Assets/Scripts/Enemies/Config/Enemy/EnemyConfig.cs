using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/Enemy/EnemyConfig")]
public class EnemyConfig : ScriptableObject
{
    [field: SerializeField] public GameObject EnemyPrefab { get; private set; }
    
    [field: SerializeField] public int Health { get; private set; }
    [field: SerializeField] public int Damage { get; private set; }
    [field: SerializeField] public int Speed { get; private set; }
}
