using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] Transform[] BulletInstantiatePoint;
    [SerializeField] GameObject Bulletpf;
    void Start()
    {
        StartCoroutine(BulletInstantiateRoutine());
    }

    IEnumerator BulletInstantiateRoutine()
    {
            yield return new WaitForSeconds(1f);
            int randomTP = UnityEngine.Random.Range(0, BulletInstantiatePoint.Length);
            Instantiate(Bulletpf, BulletInstantiatePoint[randomTP].position, Quaternion.identity);
    }
}
