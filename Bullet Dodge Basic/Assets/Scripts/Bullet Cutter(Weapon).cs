using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCutter : MonoBehaviour
{
    [SerializeField] GameObject Bladepf;
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            StartCoroutine(BladeActivate());   
        }    
    }

    IEnumerator BladeActivate() 
    {
        Bladepf.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Bladepf.SetActive(false);
    }
}
