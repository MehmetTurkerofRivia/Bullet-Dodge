using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] GameObject Bulletpf;
    int zar;
    private void Update()
    {
        for (int i = 0; i < ; i++) { }
        Instantiate(Bulletpf);
        zar = UnityEngine.Random.Range(0, 10);
    }


}
