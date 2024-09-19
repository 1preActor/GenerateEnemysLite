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
            int spawnPointNum = Random.Range(0,_spawnPoints.Length);
            Instantiate(_enemyPrefab, _spawnPoints[spawnPointNum]);

            yield return wait;
        }
    }
}