using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;
using Zenject;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] private GameInitializerView _view;
    [SerializeField] private WaveConfig _waveConfig;
    
    private CompositeDisposable _disposable = new();
    private WaveSpawner _spawner;
   

    [Inject]
    private void Construct(WaveSpawner spawner)
    {
        _spawner = spawner;
    }

    private void OnEnable()
    {
        _view.StartButtonPressed.Subscribe(_ => StartGame())
            .AddTo(_disposable);
    }

    private void StartGame()
    {
        StartWaveSpawn().Forget();
    }

    private async UniTask StartWaveSpawn()
    {
        foreach (var wave in _waveConfig.Waves)
        {
            _spawner.SpawnWave(wave);
            await UniTask.WaitForSeconds(_waveConfig.TimeOutBtwWaves);
        }
    }
}
