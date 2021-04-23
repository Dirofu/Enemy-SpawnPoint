using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAllSpawnPoints : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _spawnTime;

    private SpawnEnemy[] _points;
    private int _currentPoint;
    private float _nextSpawnTime;

    private void Start()
    {
        _points = gameObject.GetComponentsInChildren<SpawnEnemy>();
        _nextSpawnTime = _spawnTime;
    }

    private void Update()
    {
        if (_nextSpawnTime <= 0 && _currentPoint < _points.Length)
        {
            _points[_currentPoint].Spawn(_enemy);
            _currentPoint++;
            _nextSpawnTime = _spawnTime;
        }
        else
        {
            _nextSpawnTime -= Time.deltaTime;
        }
    }
}
