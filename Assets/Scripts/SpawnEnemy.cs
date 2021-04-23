using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private Transform transform;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    public void Spawn(GameObject enemy)
    {
        Instantiate(enemy, transform);
    }
}
