using System;
using System.Collections.Generic;

public class StateMachine
{
    private Dictionary<Type, IState> _states = null;
    public IState currentStates { get; private set; }
    public bool isUpdate { get; private set; }

    public StateMachine(params IState[] states)
    {
        _states = new Dictionary<Type, IState>(states.Length);
        foreach (var state in states)
        {
            _states.Add(state.GetType(), state);
        }
    }

    public void SwitchStates<TState>() where TState : IState
    {
        isUpdate = false;
        TryExitStates();
        GetNewState<TState>();
        TryEnterStates<TState>();
        isUpdate = true;
    }

    private void TryEnterStates<TState>() where TState : IState
    {
        if (currentStates is TState objectBehaviour)
        {
            objectBehaviour.OnEnter();
        }
    }

    private void TryExitStates()
    {
        if (currentStates is { } objectBehaviour)
        {
            objectBehaviour.OnExit();
        }
    }

    private void GetNewState<TState>() where TState : IState
    {
        var newState = GetState<TState>();
        currentStates = newState;
    }

    private TState GetState<TState>() where TState: IState
    {
        return (TState)_states[typeof(TState)];
    }
}