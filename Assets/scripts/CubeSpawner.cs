using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    ObjectPool objectPool;

    void Start()
    {
        objectPool = ObjectPool.Instance;
    }

    void FixedUpdate()
    {
        objectPool.SpawnFromPool("Sword", transform.position, Quaternion.identity);
    }

}
