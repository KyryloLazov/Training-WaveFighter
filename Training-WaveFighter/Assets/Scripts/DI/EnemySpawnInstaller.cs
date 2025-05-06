using UnityEngine;
using Zenject;

public class EnemySpawnInstaller : MonoInstaller
{
    [SerializeField] private EnemyConfig _enemyConfig;
    public override void InstallBindings()
    {
        Container.Bind<Factory>().AsSingle();
        Container.Bind<WaveSpawner>().AsSingle();
        Container.Bind<EnemyConfig>().FromInstance(_enemyConfig).AsSingle();
    }
}