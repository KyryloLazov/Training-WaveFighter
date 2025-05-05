using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveConfig", menuName = "Config/WaveConfig")]
public class WaveConfig : ScriptableObject
{
    [field: SerializeField] public List<WaveSettings> Waves { get; private set; } = new();
}
