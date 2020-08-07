using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SImplePhysicShooter : MonoBehaviour
{
    public Rigidbody shellPrefab;
    public GameObject shootEffectPrefab;
    public float lifetimeShootEffect;
    public Transform[] shootPoints;

    public float shootForceValue;
    public float shootPeriod;

    float shootLastTime;

    private void Start()
    {
        shootLastTime = Time.time;
    }

    public void Shoot()
    {
        if (Time.time - shootLastTime > shootPeriod)
        {
            foreach (var point in shootPoints)
            {
                Rigidbody newShell = Instantiate(shellPrefab);
                newShell.transform.position = point.position;
                newShell.transform.rotation = point.rotation;
                Vector3 shootForce = point.forward * shootForceValue;
                newShell.AddForce(shootForce);
                GameObject effect = Instantiate(shootEffectPrefab, point.position, point.rotation);
                Destroy(effect, lifetimeShootEffect);
            }
            shootLastTime = Time.time;
        }
    }
}
