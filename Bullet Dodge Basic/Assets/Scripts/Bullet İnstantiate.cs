using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] Transform[] BulletInstantiatePoint;
    [SerializeField] GameObject Bulletpf;
    void Update()
    {

    }

    IEnumerator BulletInstantiate()
    {
        wait
        int randomTP = UnityEngine.Random.Range(0, BulletInstantiatePoint.Length);
        Instantiate(Bulletpf, BulletInstantiatePoint[randomTP]);
    }
}
