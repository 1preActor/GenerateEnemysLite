using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start() => transform?.Rotate(0, Random.Range(0,360), 0);
    
    private void Update() => transform?.Translate(Vector3.forward*Time.deltaTime);    
}