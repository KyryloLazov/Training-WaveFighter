using UnityEngine;
using Zenject;

public class Factory
{
    private DiContainer _container;
    
    public Factory(DiContainer container)
    {
        _container = container;
    }
    
    public GameObject SpawnObject(GameObject prefab, Vector3 spawnPoint)
    {
        GameObject gameObject = _container.InstantiatePrefab(prefab);
        gameObject.transform.position = spawnPoint;
        return gameObject;
    }
}