using System;
using UnityEngine;

public class SpawnWithTarget : MonoBehaviour
{
    public SetNavMeshTarget prefab;
    public float spawnPeriod;
    public Transform target;

    float lastSpawnTime;

    private void Awake()
    {
        lastSpawnTime = Time.time;
    }

    private void Update()
    {
        if(Time.time - lastSpawnTime > spawnPeriod)
        {
            SpawnOnce();
        }
    }

    private void SpawnOnce()
    {
        SetNavMeshTarget newObject = Instantiate(prefab);
        newObject.transform.position = transform.position;
        newObject.transform.rotation = transform.rotation;
        newObject.target = target;
        lastSpawnTime = Time.time;
    }
}
