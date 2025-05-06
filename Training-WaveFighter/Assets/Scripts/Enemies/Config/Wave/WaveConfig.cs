using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WaveConfig
{
    [field: SerializeField] public List<WaveSettings> Waves { get; private set; } = new();
    [field: SerializeField] public int TimeOutBtwWaves { get; private set; }
}
