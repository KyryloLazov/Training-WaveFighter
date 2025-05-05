using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveConfig", menuName = "Configs/Wave/WaveConfig")]
public class WaveConfig : ScriptableObject
{
    [field: SerializeField] public List<WaveSettings> Waves { get; private set; } = new();
    [field: SerializeField] public int TimeOutBtwWaves { get; private set; }
}
