using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public void Spawn(GameObject enemy)
    {
        Instantiate(enemy, transform);
    }
}
