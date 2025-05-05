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
    
    private CompositeDisposable _disposable = new();
    private WaveSpawner _spawner;
    private WaveConfig _waveConfig;

    [Inject]
    private void Construct(WaveSpawner spawner, WaveConfig waveConfig)
    {
        _spawner = spawner;
        _waveConfig = waveConfig;
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
            Debug.Log("Starting wave " + wave);
            await UniTask.WaitForSeconds(_waveConfig.TimeOutBtwWaves);
        }
    }
}
