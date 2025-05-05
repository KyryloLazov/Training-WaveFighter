using UnityEngine;

public class WaveSpawner
{
    private EnemyConfig _enemyConfig;
    private Factory _factory;

    public WaveSpawner(EnemyConfig config, Factory factory)
    {
        _factory = factory;
        _enemyConfig = config;
    }
    
    public void SpawnEnemies(Vector3 position)
    {
        GameObject enemyGO = _factory.SpawnObject(_enemyConfig.EnemyPrefab, position);
        enemyGO.GetComponent<IEnemy>().Initialize(_enemyConfig);
    }
}
