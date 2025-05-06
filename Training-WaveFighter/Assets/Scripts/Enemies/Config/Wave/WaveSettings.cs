using System;
using UnityEngine;

[Serializable]
public class WaveSettings
{
    [field: SerializeField] public EnemyConfig EnemyConfig { get; private set; }
    [field: SerializeField] public int EnemyCount { get; private set; }
    [field: SerializeField] public int WaveDuration { get; private set; }
    [field: SerializeField] public Transform SpawnPoint { get; private set; }
    [field: SerializeField] public float RandomPositionOffset { get; private set; }
    
}
