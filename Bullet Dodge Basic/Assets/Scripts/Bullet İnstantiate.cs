using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] GameObject BulletPrefab;
    float randomtime;
    void Update()
    {
        ShootBullet();
        randomtime = Random.Range
    }
    void ShootBullet()
    {
        
        Quaternion rotation = Quaternion.Euler(0, 0, 90); 
        Instantiate(BulletPrefab, transform.position, rotation);
    }
}
