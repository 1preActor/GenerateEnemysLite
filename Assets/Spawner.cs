using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _repeatRate;

    private void Start() => StartCoroutine(SpawnEnemy());

    private IEnumerator SpawnEnemy()
    {
        var wait = new WaitForSeconds(_repeatRate);
        while (true)
        {
            _enemyPrefab.SetTarget(_spawnPoints[GetRandomSpawnPoint()]);
            Instantiate(_enemyPrefab, _spawnPoints[GetRandomSpawnPoint()]);
            yield return wait;
        }
    }

    private int GetRandomSpawnPoint() { return Random.Range(0, _spawnPoints.Length); }
}