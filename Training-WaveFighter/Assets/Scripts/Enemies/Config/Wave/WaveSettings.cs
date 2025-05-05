using System;
using UnityEngine;

[Serializable]
public class WaveSettings
{
    [field: SerializeField] public int EnemyCount { get; private set; }
    [field: SerializeField] public int WaveDuration { get; private set; }
}
