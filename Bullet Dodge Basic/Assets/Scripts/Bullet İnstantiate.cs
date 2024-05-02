using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] Transform[] BulletInstantiatePoint;
    [SerializeField] GameObject BulletPrefab;
    private float bolen;
    private float lastShotTime = 0f;
    private void Start()
    {
        bolen = Bullet.zaman;
    }
    void Update()
    {
        bolen += (Bullet.zaman/120f);
        if (bolen >= 1.9f)
            bolen = 1.9f;

        Debug.Log(bolen);

        if (Time.time - lastShotTime >= (2f - bolen))
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
