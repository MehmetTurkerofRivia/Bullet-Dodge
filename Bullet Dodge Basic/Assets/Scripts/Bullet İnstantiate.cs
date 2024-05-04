using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] Transform[] BulletInstantiatePoint;
    [SerializeField] GameObject BulletPrefab;
    private float lastShotTime = 0f;
    void Update()
    {
        if (Time.time - lastShotTime >= 0.5f)
        {
            ShootBullet();
            lastShotTime = Time.time;
        }
    }
    void ShootBullet()
    {
        int randomTP = UnityEngine.Random.Range(0, BulletInstantiatePoint.Length);
        Quaternion rotation = Quaternion.Euler(0, 0, 90); 
        Instantiate(BulletPrefab, BulletInstantiatePoint[randomTP].position, rotation);
    }
}
