using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class GameInitializerView : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    
    public  ReactiveCommand<Unit> StartButtonPressed = new();
    
    void OnEnable()
    {
        _startButton.onClick.AddListener(() => StartButtonPressed.Execute(Unit.Default));
    }

    private void OnDisable()
    {
        _startButton.onClick.RemoveAllListeners();
    }
}
