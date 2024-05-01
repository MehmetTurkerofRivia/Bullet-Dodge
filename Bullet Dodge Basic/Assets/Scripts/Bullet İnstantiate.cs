using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] Transform[] BulletInstantiatePoint;
    [SerializeField] GameObject Bulletpf;
    int zar;
    private void Update()
    {
        Instantiate(Bulletpf);
    }

    void BulletInstant()
    {
        zar =  
    }
}
