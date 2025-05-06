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
    
    public void SpawnEnemy(Vector3 position)
    {
        GameObject enemyGO = _factory.SpawnObject(_enemyConfig.EnemyPrefab, position);
        enemyGO.GetComponent<IEnemy>().Initialize(_enemyConfig);
    }

    public void SpawnWave(WaveSettings settings)
    {
        for (int i = 0; i < settings.EnemyCount; i++)
        {
            Vector3 sphere = Random.insideUnitSphere * settings.RandomPositionOffset;
            sphere.y = 0f;

            Vector3 spawnPos = settings.SpawnPoint.position + sphere;
            SpawnEnemy(spawnPos);
        }
    }

}
