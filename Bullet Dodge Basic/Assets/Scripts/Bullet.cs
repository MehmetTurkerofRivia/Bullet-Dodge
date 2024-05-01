using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    int speed;
    private void Start()
    {
        speed = Random.Range(3, 5);
    }
    void Update()
    {
        transform.localPosition -= new Vector3(speed * Time.deltaTime, 0f, 0f);

        if (transform.localPosition.x<=-21)
            Destroy(gameObject);
    }     

}
